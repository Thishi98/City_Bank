using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class Order
    {
      public string id { get; set; }
      public string Custnam_name { get; set; }
      public int Contact { get; set; }
      public string Address { get; set; }
      public string Function { get; set; }
      public string Flower_type { get; set; }
      public string Message { get; set; }
      public int  Quantity { get; set; }
      public string P_order { get; set; }


        public int OInsert()
        {
            try
            {
                String mysql = "INSERT INTO blacklotus.order_tbl VALUES (NULL,'" + Custnam_name + "'," + Contact + ",'" + Address + "','" + Function + "','" + Flower_type + "','" + Message + "'," + Quantity + ",'" + P_order + "')";
                return DB_Operations.ExcecuteQuery(mysql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int OUpdate()
        {
            try
            {
                string mysql = "UPDATE blacklotus.order_tbl SET Customer_Name='" + Custnam_name + "', Contact_No= " + Contact + ", Address= '" + Address + "', Flower_type= '" + Flower_type + "', Message= '" + Message + "', Quantity= " + Quantity + " WHERE Contact_No= " + Contact;
                return DB_Operations.ExcecuteQuery(mysql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int ODelete()
        {
            try
            {
                string mysql = "DELETE FROM blacklotus.order_tbl WHERE Contact_No= " + Contact;
                return DB_Operations.ExcecuteQuery(mysql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool OFind()
        {
            try
            {
                String mysql = "SELECT * FROM blacklotus.order_tbl WHERE Contact_No= " + Contact;
                DataSet ds = DB_Operations.ExcSelectQuery(mysql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Custnam_name = ds.Tables[0].Rows[0][1].ToString();
                    Address = ds.Tables[0].Rows[0][3].ToString();
                    Function = ds.Tables[0].Rows[0][4].ToString();
                    Flower_type = ds.Tables[0].Rows[0][5].ToString();
                    Message = ds.Tables[0].Rows[0][6].ToString();
                    Quantity =Convert.ToInt32(ds.Tables[0].Rows[0][7].ToString());
                   
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
        public DataSet SearchAll()
        {
            try 
            {
                string mysql = "SELECT * FROM blacklotus.order_tbl";
                return DB_Operations.ExcSelectQuery(mysql);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
         }
}
