using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class Register
    {
        public string Custfname { get; set; }
        public string Custlname { get; set; }
        public string Address { get; set; }
        public int Contact { get; set; }
        public string Email { get; set; }
        ///public string Password { get; set; }


        public int insert()
        {
            try
            {
                String mysql = "INSERT INTO blacklotus.customer VALUES (NULL,'" + Custfname + "','" + Custlname + "','" + Address + "'," + Contact + ",'" + Email + "')";
                return DB_Operations.ExcecuteQuery(mysql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Update()
        {
            try
            {
                string mysql = "UPDATE blacklotus.customer SET Cust_FName='" + Custfname + "', Cust_LName= '" + Custlname + "', Address= '" + Address + "', email= '" + Email + "' " +
                    "WHERE Contact_No= " + Contact;
                return DB_Operations.ExcecuteQuery(mysql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
          public int Delete()
            {
                try
                {
                string mysql = "DELETE FROM blacklotus.customer WHERE Contact_No= "+ Contact;
                    return DB_Operations.ExcecuteQuery(mysql);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        public bool Find()
        {
            try
            {
                String mysql = "SELECT * FROM blacklotus.customer WHERE Contact_No= " +Contact;
                DataSet ds = DB_Operations.ExcSelectQuery(mysql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Custfname = ds.Tables[0].Rows[0][1].ToString();
                    Custlname = ds.Tables[0].Rows[0][2].ToString();
                    Address = ds.Tables[0].Rows[0][3].ToString();
                    Email = ds.Tables[0].Rows[0][5].ToString();
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
