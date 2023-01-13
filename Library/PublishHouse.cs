using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Library
{
    class PublishHouse
    {
        private const string SQL = "SELECT A.id , A.name , A.email, CONCAT(A.City , '-' , A.Street) , A.phone FROM (SELECT id , name , email, City , Street , phone , ROW_NUMBER() OVER (PARTITION BY id ORDER BY phone) AS RN FROM Publish_house LEFT OUTER JOIN House_phone ON id = House_id ) A WHERE A.RN = 1";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string phone { get; set; }

        public static DataTable LoadDate(string sql = SQL)
        {
            var con = new DatabaseCon();
            var dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.close();
            return dt;
        }
        public static List<string> LoadData(string sql)
        {
            var con = new DatabaseCon();
            var list = new List<string>();
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string it;
                    it = dr.GetInt32(0).ToString();
                    it += "-";
                    it += dr.GetString(1);
                    list.Add(it);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.close();
            return list;
        }


        public int PublishHouseID()
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "SELECT IDENT_CURRENT('Publish_house')";
            int res = -1;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    res = int.Parse(dr.GetValue(0).ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
            return res;

        }

        public void InsertPhone(int id, string phone)
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "INSERT INTO House_phone VALUES(" + (id) + ",'" + (phone) + "')";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }
        public void DeletePhpne(int id)
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "DELETE FROM House_phone WHERE House_id = " + (id) + "";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }
        public void UpdatePhpne(int id, string phone)
        {
            var con = new DatabaseCon();
            string sql = "UPDATE House_phone SET phone = '" + (phone) + "' WHERE House_id = " + (id) + "";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }

        public void InsertPublishHouse(string name, string email,string city,string street)
        {
            var con = new DatabaseCon();
            string sql = "INSERT INTO Publish_house VALUES('" + (name) + "','" + (email) + "','" + (city) + "','" + (street) + "')";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }
        public void DeletePublishHouse(int id)
        {
            DatabaseCon con = new DatabaseCon();
            string sql = "DELETE FROM Publish_house WHERE id = " + (id) + "";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();
        }
        public void UpdatePublishHouse(int id,string name, string email, string city, string street,string phone,bool hasPhone)
        {
            if (hasPhone == false && phone != " ")
                InsertPhone(id, phone);
            else
            {
                if (phone != "")
                    UpdatePhpne(id, phone);
                else
                    DeletePhpne(id);
            }

            var con = new DatabaseCon();
            string sql = "UPDATE Publish_house SET name = '" + (name) + "' , email = '" + (email) + "' , City = '" + (city) + "' , Street = '" + (street) + "' WHERE id = " + (id) + "";
            try
            {
                var cmd = new SqlCommand(sql, con.open());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            con.close();

        }
    }
}
