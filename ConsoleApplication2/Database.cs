using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using MySql.Data.MySqlClient;


namespace SQL_surfer
{
    class Database
    {
        //
        public SqlConnection WebMail()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "";
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                Console.WriteLine("webmail Connection Open ! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }
            return cnn;

        }
        //
        public SqlConnection GetAzure()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "";
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                Console.WriteLine("khuat15 Connection Open ! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }
            return cnn;

        }
        //
        public SqlConnection GetAzure301()
        {
            string connetionString = null;
            SqlConnection cnn;

            
            connetionString = "";

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                Console.WriteLine("khuat15_301Redir Connection Open ! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }
            return cnn;

        }
        //
        public MySqlConnection GetMatrix()
        {
            MySqlConnection conn;




            string connStr = "";
            conn = new MySqlConnection(connStr);


            try
            {
                conn.Open();
                Console.WriteLine("kHovFeed Connection Open ! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }


            return conn;
        }
        //
        public SqlConnection GetKhovProd()
        {
            SqlConnection conn;




            string connStr = "";
            conn = new SqlConnection(connStr);


            try
            {
                conn.Open();
                Console.WriteLine("kHovProd Connection Open ! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }


            return conn;
        }
        //
    }
}
