using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class SignIn
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public bool Loginn()
        {
            try
            {
                String mysql = "SELECT * FROM blacklotus.admin WHERE email = '" + Email + "' AND password = '" + Password + "';";
                DataSet ds = DB_Operations.ExcSelectQuery(mysql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Email = ds.Tables[0].Rows[0][3].ToString();
                    Password = ds.Tables[0].Rows[0][4].ToString();

                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public int AdminInsert()
        {
            try
            {
                String mysql = "INSERT INTO blacklotus.admin VALUES (NULL,'" + Fname + "','" + Lname + "','" + Email + "','" + Password + "')";
                return DB_Operations.ExcecuteQuery(mysql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AdminUpdate()
        {
            try
            {
                string mysql = "UPDATE blacklotus.admin SET First_Name='" + Fname + "', Last_Name= '" + Lname + "', password= '" + Password + "' WHERE email= '" + Email + "';";
                return DB_Operations.ExcecuteQuery(mysql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AdminDelete()
        {
            try
            {
                string mysql = "DELETE FROM blacklotus.admin WHERE email= '" + Email + "';";
                return DB_Operations.ExcecuteQuery(mysql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AdminFind()
        {
            try
            {
                String mysql = "SELECT * FROM blacklotus.admin WHERE email= '" + Email + "';";
                DataSet ds = DB_Operations.ExcSelectQuery(mysql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Fname = ds.Tables[0].Rows[0][1].ToString();
                    Lname = ds.Tables[0].Rows[0][2].ToString();
                    Password = ds.Tables[0].Rows[0][4].ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
