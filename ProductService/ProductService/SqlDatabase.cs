using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductService
{
    class SqlDatabase:IRepository
    {
        Logger log = Logger.getInstance();
        public void SaveTheProduct(String name,int price, Boolean book,String producttype)
        {
            log.LogMessage("Call to Sql Database SaveTheProduct Method");
            SqlConnection connectionObject = new SqlConnection();
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.UserID = "sa";
                builder.Password = "test123!@#";
                builder.InitialCatalog = "Products";
                using (connectionObject = new SqlConnection(builder.ConnectionString))
                {
                    connectionObject.Open();
                    String command = "insert into " + producttype + "(Name,Booked,Price) values('" + name + "','" + book + "','" + price + "')";
                    SqlCommand cmd = new SqlCommand(command, connectionObject);
                    cmd.ExecuteNonQuery();
                    connectionObject.Close();
                }
            }
            catch(Exception e)
            {
                log.LogMessage("Entry to Catch Block");
                Console.WriteLine(e.Message);
                log.LogMessage("Exiting Catch Block");
            }
            log.LogMessage("Exiting SaveTheProduct Method of Sql Database");
        }
        public void BookTheProduct(String name,Boolean book,String producttype)
        {
            log.LogMessage("Call to Sql Database BookTheProduct Method");
            SqlConnection connectionObject = new SqlConnection();
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.UserID = "sa";
                builder.Password = "test123!@#";
                builder.InitialCatalog = "Products";
                using (connectionObject = new SqlConnection(builder.ConnectionString))
                {
                    connectionObject.Open();
                    String command = "UPDATE " + producttype + " SET Booked = '" + book + "' WHERE Name ='" + name+"'";
                    SqlCommand cmd = new SqlCommand(command, connectionObject);
                    cmd.ExecuteNonQuery();
                    connectionObject.Close();
                }
            }
            catch (Exception e)
            {
                log.LogMessage("Entry to Catch Block");
                Console.WriteLine(e.Message);
                log.LogMessage("Exiting Catch Block");
            }
            log.LogMessage("Exiting the BookTheProduct Method");
        }
    }
}