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
    class DB
    {
        //
        public SqlConnection WebMail()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Server=10.156.41.139;Database=webmail;UID=Webmail05;Password=prd1mail05";
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
            connetionString = "Data Source=hts7j6xf2y.database.windows.net;Initial Catalog=khuat15;User ID=khovweb;Password=Khoversm1n";
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
            
            //connetionString = "Data Source=hts7j6xf2y.database.windows.net;Initial Catalog=khuat15_301Redir;User ID=khovweb;Password=Khoversm1n";
             connetionString = "Data Source=njrdbkqdbba\\kqba;Initial Catalog=Perfmon;User Id=IncWebRead;Password=Welcome1$;";

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




            string connStr = "server=localhost;uid=kHovFeedUotpf;pwd='$=b7r@KtZqU{';database=kHovFeed;database=kHovFeed";
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




            string connStr = "Data Source=hts7j6xf2y.database.windows.net;Initial Catalog=KHAUTHPROD16;User ID=khovweb;Password=Khoversm1n";
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
