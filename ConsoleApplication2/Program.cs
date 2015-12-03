using System;
using System.Net;
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
    class Program
    {
        static void Main(string[] args)
        {
            
          // fest.GetAzure301();// web mail fuction is for i leads...
                               
           Program prog = new Program();
            SqlTransaction test = null;
            MySqlTransaction probe = null;  
            //prog.QueryAzOld();
            
            ConsoleKeyInfo inf;
          
            do
            {
                Console.Write("SQL surfer top Menu: " + '\n' + "A.)Run Test Case [boyl_quick_move_in_home]" + '\n' + "B.)Update BOYL QMI [boyl_quick_move_in_home] " + '\n' +
                    "C.)Update BOYL Home Designs " + '\n' + "D.)Update Community QMI [cb_quick_move_in_home] " + '\n' + "E.)Update Community Home Designs!! [cb_community_home_design] " + '\n' + "H.)Collect From Above The Feed " + '\n' +
                    "I.)Update Community HD_AF [cb_community_home_design]* " + '\n' + "J.)Backup Azure* " + '\n' + "F.)Update ALL!!! " + '\n' + "G.)rollback changes " + '\n' + "X.) Exit ");
                inf = Console.ReadKey();
                switch (inf.Key) {
                    case ConsoleKey.F://F)Update ALL!!
                        Console.WriteLine("  Preparing to update DB");
                        Console.WriteLine("  Are you sure Y/N");
                        inf = Console.ReadKey();
                        switch (inf.Key) {
 
                            case ConsoleKey.Y:
                                try
                                {
                                    test = prog.ScrubAzureRd();//Update All
                                    Console.WriteLine("OK!");
                                }
                                catch (Exception e){
                                    Console.WriteLine("Un-handled Program Failure ! " + e);
                                }
                            break;
                            case ConsoleKey.N:
                            break;
                            default:
                            Console.ReadKey();
                            break;
                            }
                        break;

                    case ConsoleKey.A:// Test Case 
                        Console.WriteLine("  Preparing to test DB");
                        Console.WriteLine("  Are you sure Y/N");
                        inf = Console.ReadKey();
                        switch (inf.Key)
                        {

                            case ConsoleKey.Y:
                                try
                                {
                                    test = prog.TestAzureRd();//Test Case 
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Un-handled Program Failure ! " + e);
                                }
                                Console.WriteLine("OK!");
                                break;
                            case ConsoleKey.N:
                                break;                            
                        }
                        break;
                    case ConsoleKey.B://B)Update BOYL QMI
                        Console.WriteLine("  Preparing to test DB");
                        Console.WriteLine("  Are you sure Y/N");
                        inf = Console.ReadKey();
                        switch (inf.Key)
                        {

                            case ConsoleKey.Y:
                                try
                                {
                                    test = prog.AzureBOYL_QMI();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Un-handled Program Failure ! " + e);
                                }
                                Console.WriteLine("OK!");
                                break;
                            case ConsoleKey.N:
                                break;
                        }
                        break;
                    case ConsoleKey.C://C) Update BOYL Home Designs 
                        Console.WriteLine("  Preparing to test DB");
                        Console.WriteLine("  Are you sure Y/N");
                        inf = Console.ReadKey();
                        switch (inf.Key)
                        {

                            case ConsoleKey.Y:
                                try
                                {
                                    test = prog.AzureBOYL_HD();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Un-handled Program Failure ! " + e);
                                }
                                Console.WriteLine("OK!");
                                break;
                            case ConsoleKey.N:
                                break;
                        }
                        break;
                    case ConsoleKey.D:// D)Update Community QMI
                        Console.WriteLine("  Preparing to test DB");
                        Console.WriteLine("  Are you sure Y/N");
                        inf = Console.ReadKey();
                        switch (inf.Key)
                        {

                            case ConsoleKey.Y:
                                try
                                {
                                    test = prog.AzureComm_QMI();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Un-handled Program Failure ! " + e);
                                }
                                Console.WriteLine("OK!");
                                break;
                            case ConsoleKey.N:
                                break;
                        }

                        break;
                    case ConsoleKey.E://E)Update Community Home Designs!!
                        Console.WriteLine("  Preparing to test DB");
                        Console.WriteLine("  Are you sure Y/N");
                        inf = Console.ReadKey();
                        switch (inf.Key)
                        {

                            case ConsoleKey.Y:
                                try
                                {
                                    test = prog.AzureComm_HD();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Un-handled Program Failure ! " + e);
                                }
                                Console.WriteLine("OK!");
                                break;
                            case ConsoleKey.N:
                                break;
                        }
                        break;
                    case ConsoleKey.H:// Collect Above the feed
                        Console.WriteLine("  Preparing to test DB");
                        Console.WriteLine("  Are you sure Y/N");
                        inf = Console.ReadKey();
                        switch (inf.Key)
                        {

                            case ConsoleKey.Y:
                                try
                                {
                                    probe = prog.SwapAzureRd(0);//comm_hd
                                    prog.CommitMatrixRd(probe);

                                    //probe = prog.SwapAzureRd(1);//boyl_hd
                                    //prog.CommitMatrixRd(probe);

                                    //probe = prog.SwapAzureRd(2);//com_qmi
                                    //prog.CommitMatrixRd(probe);

                                    //probe = prog.SwapAzureRd(3);//boyl_qmi
                                    //prog.CommitMatrixRd(probe);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Un-handled Program Failure ! " + e);
                                }
                                Console.WriteLine("OK!");
                                break;
                            case ConsoleKey.N:
                                break;
                        }
                        break;
                    case ConsoleKey.I:// Update Azure
                        Console.WriteLine("  Preparing to test DB");
                        Console.WriteLine("  Are you sure Y/N");
                        inf = Console.ReadKey();
                        switch (inf.Key)
                        {

                            case ConsoleKey.Y:
                                try
                                {
                                    test = prog.SwapMatrixRd(0);//comm_hd
                                    prog.CommitAzureRd(test);

                                    //test = prog.SwapMatrixRd(1);//boyl_hd
                                    //prog.CommitAzureRd(test);

                                    //test = prog.SwapMatrixRd(2);//com_qmi
                                    //prog.CommitAzureRd(test);

                                    //test = prog.SwapMatrixRd(3);//boyl_qmi
                                    //prog.CommitAzureRd(test);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Un-handled Program Failure ! " + e);
                                }
                                Console.WriteLine("OK!");
                                break;
                            case ConsoleKey.N:
                                break;
                        }
                        break;
                    case ConsoleKey.J:// Back up Azure
                        Console.WriteLine("  Preparing to test DB");
                        Console.WriteLine("  Are you sure Y/N");
                        inf = Console.ReadKey();
                        switch (inf.Key)
                        {

                            case ConsoleKey.Y:
                                try
                                {
                                    probe = prog.BackUpAzure(0);//com_hd
                                    prog.CommitMatrixRd(probe);

                                    //probe = prog.BackUpAzure(1);//com_qmi
                                    //prog.CommitMatrixRd(probe);

                                    //probe = prog.BackUpAzure(2);//boyl_qmi
                                    //prog.CommitMatrixRd(probe);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Un-handled Program Failure ! " + e);
                                }
                                Console.WriteLine("OK!");
                                break;
                            case ConsoleKey.N:
                                break;
                        }
                        break;
                    case ConsoleKey.G:
                        Console.WriteLine("  Preparing to rollback DB");
                        try
                        {
                            if (test != null)
                            {
                                test = prog.RollBackAzureRd(test);
                            }
                            if (probe != null)
                            {
                                probe = prog.RollBackMatrixRd(probe);
                            }
                        }
                        catch (Exception e) {
                            Console.WriteLine("Un-handled Program Failure ! " + e);
                        }
                        break;                  
                }

            } while (inf.Key != ConsoleKey.X) ;
            Console.WriteLine("Commit Before Exit?('Y')");
            inf = Console.ReadKey();
            if (inf.Key == ConsoleKey.Y)
            {
                try
                {
                    if (test != null)
                    {
                        prog.CommitAzureRd(test);
                    }
                    if (probe != null)
                    {
                        prog.CommitMatrixRd(probe);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Un-handled Program Failure ! " + e);
                }
            }
            else
            {
                try
                {
                    if (test != null)
                    {
                        test = prog.RollBackAzureRd(test);
                    }
                    if (probe != null)
                    {
                        prog.RollBackMatrixRd(probe);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Un-handled Program Failure ! " + e);
                }
            }
        }//end main
//        
//
        public void QueryAzOld(){// Query azure for old urls and ping for live links 

            var ping = new System.Net.NetworkInformation.Ping();

            DB azure = new DB();
            SqlConnection cnn = azure.GetAzure();
            SqlDataReader azdata;
            SqlCommand azcom = new SqlCommand();


            string az_hm_ifp_redirup_q = "select distinct cb_community_home_design.interative_floor_plan,cb_community_home_design.title_,cb_community.salesCenterState from cb_community_home_design join cb_community on  cb_community.ownr= cb_community_home_design.ownr where DATALENGTH(interative_floor_plan) >0  AND (not((interative_floor_plan like '%[?]%')))";
            azcom.CommandText = az_hm_ifp_redirup_q;
            azcom.Connection = cnn;

            azdata = azcom.ExecuteReader();
            while (azdata.Read())
            {
                string data = azdata["interative_floor_plan"].ToString();

                try
                    {
                        HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(data);
                        request.Timeout = 600;
                        request.AllowAutoRedirect = false; // find out if this site is up and don't follow a redirector
                        request.Method = "HEAD";
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Console.WriteLine(data);
                        Console.WriteLine((int)response.StatusCode);
                        Console.WriteLine(response.StatusCode);                   
                        
                    }
                    catch (WebException wex)
                    {
                        Console.WriteLine(wex);
                        Console.WriteLine(data);
                        //set flag if there was a timeout or some other issues
                    }                
                }
                           
            Console.ReadKey();
    
    
    }

 //
        public void 
            CommitAzureRd(SqlTransaction upTrans)
        {
            Console.WriteLine("Start Commit! ");
            
            try
            {
                upTrans.Commit();             
                upTrans.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Un-handled Program Failure ! ");
                Console.WriteLine(e);
            }
            Console.WriteLine("Finished Tracaction ! ");
            Console.ReadKey();            
        }       
//
        public void  CommitMatrixRd(MySqlTransaction upTrans){
            
            Console.WriteLine("Start Commit! ");                                
                            try
                            {
                                upTrans.Commit();
                                upTrans.Dispose();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Un-handled Program Failure ! ");
                                Console.WriteLine(e);
                            }

                            Console.WriteLine("Finished Transaction ! ");
                            Console.ReadKey();            
    }
//
        public SqlTransaction RollBackAzureRd(SqlTransaction upTrans)
        {
            Console.WriteLine("Start DB Rollback! ");
          
            upTrans.Rollback("Point_A");

            Console.WriteLine("Finished DB Rollback!! ");
            return upTrans;
        }
//
        public MySqlTransaction RollBackMatrixRd(MySqlTransaction upTrans)
        {
            Console.WriteLine("Start DB Rollback! ");

            upTrans.Rollback();

            Console.WriteLine("Finished DB Rollback!! ");      
            return upTrans;
        }
//
        public SqlTransaction  TestAzureRd() { // test azure simple update
            Console.WriteLine("Start ! ");
            
            DB azure = new DB();
            DB matrix = new DB();

            //SqlConnection cnn = azure.GetAzure();
            SqlConnection cnn = azure.GetAzure301();
            SqlTransaction upTrans = null;//= new SqlTransaction("Trans");
            upTrans = cnn.BeginTransaction("Trans");

            MySqlConnection khov = matrix.GetMatrix();
            SqlDataReader azdata;
            MySqlDataReader mxdata;
          
            string new_url = null;
            string old_url = null;
            string data = null;

            List<string> NewUrl = new List<string>();
            List<string> OldUrl = new List<string>();

            int numrow = 0;
            int count = 0;
            
            //string sql_test = "UPDATE boyl_quick_move_in_home  SET [interactive_floor_plan] = @new WHERE [interactive_floor_plan] = @old";
            string count_sql_test = "SELECT DISTINCT COUNT ([interactive_floor_plan]) FROM boyl_quick_move_in_home WHERE (NOT((interactive_floor_plan IN(''))))";
            string sel_sql_test = "SELECT ([interactive_floor_plan]) FROM boyl_quick_move_in_home WHERE (NOT((interactive_floor_plan IN(''))))";
            string sql_test = "SELECT TickerTXT FROM tbl_INC_Ticker WHERE ID=1";

            
           
            SqlCommand azcom2 = new SqlCommand(sql_test,cnn,upTrans);
           
            try
            {        
                azcom2.Parameters.AddWithValue("@new", new_url);
                azcom2.Parameters.AddWithValue("@old", old_url);
               
               
                int i = 0;

                //NewUrl.Add("test");// populate replacement list
                //OldUrl.Add("http://nochrome.parksideatmartinsrun.khov.ml3ds-cloud.com/index.html#/floorplan/3538?floorId=7170");


                OldUrl.Add("http://nochrome.parksideatmartinsrun.khov.ml3ds-cloud.com/FloorPlan/details/3538/!");// populate replacement list
                NewUrl.Add("http://nochrome.parksideatmartinsrun.khov.ml3ds-cloud.com/FloorPlan/details/3538/");             
                
                    new_url = NewUrl[0];   
                    old_url= OldUrl[0];

                    azcom2.Parameters["@new"].Value = new_url;
                    azcom2.Parameters["@old"].Value = old_url;                   

                   data = (string)khov.Database;
                   Console.WriteLine(data);            
                 
                    azcom2.CommandText = sql_test;
                    azcom2.Transaction.Save("Point_A");
                    numrow =  azcom2.ExecuteNonQuery(); // Execute Query

                    Console.WriteLine(new_url);
                    Console.WriteLine(old_url);
                    Console.WriteLine();
                    
               
            }

            catch (Exception ex)
            {
                Console.WriteLine("Un-handled Program Failure ! " + ex);
                upTrans = this.RollBackAzureRd(upTrans);
            }

                azcom2.CommandText = sel_sql_test;
                azdata = azcom2.ExecuteReader();

                while (azdata.Read())
                {
                    Console.WriteLine("*"+azdata["interactive_floor_plan"].ToString()+"*");
                }

                azdata.Close();
                Console.WriteLine("Query: " + "UPDATE boyl_quick_move_in_home  SET [interactive_floor_plan] = @new WHERE [interactive_floor_plan] = @old");

            azcom2.CommandText = count_sql_test;
            count = (int)azcom2.ExecuteScalar();
            Console.WriteLine("number of rows scheduled" + " " + count);
            Console.WriteLine("number of rows affected"+" "+numrow);
            Console.WriteLine("Finished !");
            return upTrans;        
        }
//
        public MySqlTransaction SwapAzureRd(int x) // copy azure old style url's not in the feed to MYSQL in Matrix
        { 

            Console.WriteLine("Start ! ");

            DB azure = new DB();
            DB matrix = new DB();
            SqlConnection cnn = azure.GetKhovProd
                ();
            MySqlConnection khov = matrix.GetMatrix();
            SqlDataReader azdata;
            MySqlDataReader mxdata;
            SqlCommand azcom2 = new SqlCommand();
            SqlCommand azcom = new SqlCommand();
            MySqlCommand mxcom2 = new MySqlCommand();
            MySqlTransaction upTrans = null;

            mxcom2.Connection = khov;
            azcom2.Connection = cnn;

            mxcom2.Transaction = khov.BeginTransaction();
            upTrans = mxcom2.Transaction;
            string new_url = null;            
            List<string> NewUrl = new List<string>();
            
            int numrow = 0;
            int count = 0;

            

           
            string count_az_old_url_q = "SELECT COUNT (DISTINCT [interative_floor_plan])  FROM [cb_community_home_design] WHERE (NOT(([interative_floor_plan] LIKE '%[?]%' ))) AND (NOT(([interative_floor_plan] IN('')))) AND (NOT(([interative_floor_plan] LIKE '%bit%' )))";
            string az_old_url_q = "SELECT DISTINCT  [interative_floor_plan]  FROM [cb_community_home_design] WHERE (NOT(([interative_floor_plan] LIKE '%[?]%' ))) AND (NOT((interative_floor_plan IN('')))) AND (NOT(([interative_floor_plan] LIKE '%bit%' )))";

            string az_old_boylhd_url_q = "SELECT DISTINCT  [interative_floor_plan]  FROM [boyl_home_design] WHERE (NOT(([interative_floor_plan] LIKE '%[?]%' ))) AND (NOT((interative_floor_plan IN('')))) AND (NOT(([interative_floor_plan] LIKE '%bit%' )))";           
            string count_az_old_boylhd_url_q = "SELECT COUNT (DISTINCT [interative_floor_plan])  FROM [boyl_home_design] WHERE (NOT(([interative_floor_plan] LIKE '%[?]%' ))) AND (NOT(([interative_floor_plan] IN('')))) AND (NOT(([interative_floor_plan] LIKE '%bit%' )))";

            string az_old_cbqmi_url_q = "SELECT DISTINCT  [interactive_floor_plan]  FROM [cb_quick_move_in_home] WHERE (NOT(([interactive_floor_plan] LIKE '%[?]%' ))) AND (NOT((interactive_floor_plan IN('')))) AND (NOT(([interactive_floor_plan] LIKE '%bit%' )))";           
            string count_az_old_cbqmi_url_q = "SELECT COUNT (DISTINCT [interactive_floor_plan])  FROM [cb_quick_move_in_home] WHERE (NOT(([interactive_floor_plan] LIKE '%[?]%' ))) AND (NOT(([interactive_floor_plan] IN('')))) AND (NOT(([interactive_floor_plan] LIKE '%bit%' )))";

            string az_old_boylqmi_url_q = "SELECT DISTINCT  [interactive_floor_plan]  FROM [boyl_quick_move_in_home] WHERE (NOT(([interactive_floor_plan] LIKE '%[?]%' ))) AND (NOT((interactive_floor_plan IN('')))) AND (NOT(([interactive_floor_plan] LIKE '%bit%' )))";           
            string count_az_old_boylqmi_url_q = "SELECT COUNT (DISTINCT [interactive_floor_plan])  FROM [boyl_quick_move_in_home] WHERE (NOT(([interactive_floor_plan] LIKE '%[?]%' ))) AND (NOT(([interactive_floor_plan] IN('')))) AND (NOT(([interactive_floor_plan] LIKE '%bit%' )))";

            string mx_nf_redir_q = "INSERT INTO nf_redirected_url_db  (old_url) VALUES  (@old)";//modifies a record

            string[] query = { az_old_url_q, az_old_boylhd_url_q, az_old_cbqmi_url_q, az_old_boylqmi_url_q };
            
            string[] count_q = { count_az_old_url_q, count_az_old_boylhd_url_q, count_az_old_cbqmi_url_q, count_az_old_boylqmi_url_q };
            
            try
            {
                int i = 0;
                mxcom2.Parameters.AddWithValue("@old", new_url);                               
//0
                azcom2.CommandText = query[x];
                azdata = azcom2.ExecuteReader();

                                          

                while (azdata.Read())
                {// while sill reading from repacement values
                    if (azdata.GetName(0) == "interative_floor_plan")
                    {
                    NewUrl.Add(azdata["interative_floor_plan"].ToString());// populate replacement list
                    }

                    if (azdata.GetName(0) == "interactive_floor_plan")
                    {
                        NewUrl.Add(azdata["interactive_floor_plan"].ToString());// populate replacement list
                    }

                    new_url = NewUrl[i];// set repalcemet variable                    
                    
                    mxcom2.Parameters["@old"].Value = new_url.Replace(" ","");

                    mxcom2.CommandText = mx_nf_redir_q;
                    numrow = numrow + mxcom2.ExecuteNonQuery(); // Execute Query comm hd

                    
                   Console.WriteLine(new_url);
                    
                    i++;
                }               
                azdata.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Un-handled Program Failure ! " + ex);                
                upTrans = this.RollBackMatrixRd(upTrans);
            }

            azcom2.CommandText = query[x];
            azdata = azcom2.ExecuteReader();

            while (azdata.Read())
            {
                if (azdata.GetName(0) == "interative_floor_plan")
                {
                    Console.WriteLine("*" + azdata["interative_floor_plan"].ToString() + "*");
                }
                if (azdata.GetName(0) == "interactive_floor_plan")
                {
                    Console.WriteLine("*" + azdata["interactive_floor_plan"].ToString() + "*");
                }
            }

            azdata.Close();
            Console.WriteLine("Query: " + query[x]);
           
            azcom2.CommandText = count_q[x];
            count = (int)azcom2.ExecuteScalar();
            Console.WriteLine("number of rows scheduled" + " " + count);
            Console.WriteLine("number of rows affected ="+" "+numrow);
            Console.WriteLine("Finished !");
            Console.ReadLine();
            return upTrans;
        }
//
        public SqlTransaction SwapMatrixRd(int x) // copy Matrix new style url's to Azure SQL Server db 
        {

            Console.WriteLine("Start ! ");

            DB azure = new DB();
            DB matrix = new DB();

            SqlConnection cnn = azure.GetKhovProd();
            MySqlConnection khov = matrix.GetMatrix();

            SqlDataReader azdata;
            MySqlDataReader mxdata;

            SqlCommand azcom2 = new SqlCommand(); 
            MySqlCommand mxcom2 = new MySqlCommand();

            SqlTransaction upTrans = null;
            azcom2.Connection = cnn;
            mxcom2.Connection = khov;

            azcom2.Transaction = cnn.BeginTransaction("Trans");
            upTrans = azcom2.Transaction;

            string new_url = null;
            string old_url = null;
            string data = null;

            List<string> NewUrl = new List<string>();
            List<string> OldUrl = new List<string>();

            int numrow = 0;
            int count = 0;

            string count_az_old_url_q = "SELECT COUNT ([interative_floor_plan]) FROM cb_community_home_design  WHERE ([interative_floor_plan]= @old) AND (NOT(([interative_floor_plan] IN(''))))";
            string sel_az_old_url_q = "SELECT ([interative_floor_plan]) FROM cb_community_home_design  WHERE ([interative_floor_plan]= @old) AND (NOT(([interative_floor_plan] IN(''))))";
            string az_old_url_q = "UPDATE cb_community_home_design SET [interative_floor_plan] = @new WHERE [interative_floor_plan]= @old";
            string clean_az_old_url_q = "UPDATE cb_community_home_design SET [interative_floor_plan] = LTRIM([interative_floor_plan])";

            string count_az_old_boylhd_url_q = "SELECT COUNT ([interative_floor_plan]) FROM boyl_home_design  WHERE ([interative_floor_plan]= @old) AND (NOT(([interative_floor_plan] IN(''))))";
            string sel_az_old_boylhd_url_q = "SELECT ([interative_floor_plan]) FROM boyl_home_design  WHERE ([interative_floor_plan]= @old) AND (NOT(([interative_floor_plan] IN(''))))";
            string az_old_boylhd_url_q = "UPDATE boyl_home_design SET [interative_floor_plan] = @new WHERE [interative_floor_plan]= @old";
            string clean_az_old_boylhd_url_q = "UPDATE boyl_home_design SET [interative_floor_plan] = LTRIM([interative_floor_plan])";

            string count_az_old_cbqmi_url_q = "SELECT DISTINCT COUNT ([interactive_floor_plan]) FROM cb_quick_move_in_home  WHERE ([interactive_floor_plan]= @old) AND (NOT(([interactive_floor_plan] IN(''))))";
            string sel_az_old_cbqmi_url_q = "SELECT ([interactive_floor_plan]) FROM cb_quick_move_in_home  WHERE ([interactive_floor_plan]= @old) AND (NOT(([interactive_floor_plan] IN(''))))";
            string az_old_cbqmi_url_q = "UPDATE cb_quick_move_in_home SET [interactive_floor_plan] = @new WHERE [interactive_floor_plan]= @old";
            string clean_az_old_cbqmi_url_q = "UPDATE cb_quick_move_in_home SET [interactive_floor_plan] = LTRIM([interactive_floor_plan])";

            string count_az_old_boylqmi_url_q = "SELECT DISTINCT COUNT ([interactive_floor_plan]) FROM boyl_quick_move_in_home  WHERE ([interactive_floor_plan]= @old) AND (NOT(([interactive_floor_plan] IN(''))))";
            string sel_az_old_boylqmi_url_q = "SELECT ([interactive_floor_plan]) FROM boyl_quick_move_in_home  WHERE ([interactive_floor_plan]= @old) AND (NOT(([interactive_floor_plan] IN(''))))";
            string az_old_boylqmi_url_q = "UPDATE boyl_quick_move_in_home SET [interactive_floor_plan] = @new WHERE [interactive_floor_plan]= @old";
            string clean_az_old_boylqmi_url_q = "UPDATE boyl_quick_move_in_home SET [interactive_floor_plan] = LTRIM([interactive_floor_plan])";

            string mx_nf_redir_q = "SELECT * FROM nf_redirected_url_db";
            
            string[] query = { az_old_url_q, az_old_boylhd_url_q,az_old_cbqmi_url_q,az_old_boylqmi_url_q };
            string[] count_q = { count_az_old_url_q, count_az_old_boylhd_url_q, count_az_old_cbqmi_url_q, count_az_old_boylqmi_url_q };
            string[] disp_q = { sel_az_old_url_q, sel_az_old_boylhd_url_q, sel_az_old_cbqmi_url_q, sel_az_old_boylqmi_url_q };
            string[] clean_q = { clean_az_old_url_q, clean_az_old_boylhd_url_q, clean_az_old_cbqmi_url_q, clean_az_old_boylqmi_url_q };

            azcom2.CommandText = clean_q[x];
            numrow = azcom2.ExecuteNonQuery(); // Execute Query 
          
            Console.WriteLine("number of rows cleaned =" + " " + numrow);
            numrow = 0;

            try
            {
                azcom2.Parameters.AddWithValue("@new", new_url);
                azcom2.Parameters.AddWithValue("@old", old_url);

                MySqlCommand mxcom = new MySqlCommand(mx_nf_redir_q, khov);
                azcom2.Transaction.Save("Point_A");
                mxdata = mxcom.ExecuteReader();

                int i = 0;
                            
                data = (string)khov.Database;
                Console.WriteLine(data);

                while (mxdata.Read())
                {// while sill reading from repacement values

                    NewUrl.Add(mxdata["new_url"].ToString());// populate replacement list
                    OldUrl.Add(mxdata["old_url"].ToString());

                    new_url = NewUrl[i];// set repalcemet variable
                    old_url = OldUrl[i];

                    azcom2.Parameters["@old"].Value = old_url; // set replacement parameter
                    azcom2.Parameters["@new"].Value = new_url;                                     

                    azcom2.CommandText = query[x];// az_old_url_q;//[az_old_url_q,az_old_boylqmi_url_q, az_old_cbqmi_url_q, az_old_boylhd_url_q]
                    numrow = numrow + azcom2.ExecuteNonQuery(); // Execute Query Commumity Home Design
                    Console.WriteLine(new_url);
                    
                    i++;

                }
                 mxcom2.Dispose();
               
                 Console.WriteLine("Query: " + query[x]);
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine("Un-handled Program Failure ! " + ex);
                     upTrans = this.RollBackAzureRd(upTrans);
                 }
             
                 count = OldUrl.Count;
                 Console.WriteLine("number of rows scheduled" + " " + count);
                 Console.WriteLine("number of rows affected =" + " " + numrow);
                 Console.WriteLine("Finished !");

                 return upTrans;
            
        }
//
        public SqlTransaction ScrubAzureRd(){ // scrub azure of old style url's updated from the feed

            Console.WriteLine("Start ! ");
            
            DB azure = new DB();
            DB matrix = new DB();
            SqlConnection cnn = azure.GetAzure301();
            MySqlConnection khov = matrix.GetMatrix();
            SqlDataReader azdata;
            MySqlDataReader mxdata;
            SqlCommand azcom2 = new SqlCommand();
            SqlTransaction upTrans = null;

            azcom2.Connection = cnn;

            azcom2.Transaction = cnn.BeginTransaction("Trans");
            upTrans = azcom2.Transaction;
            string new_url = null;
            string old_url = null;
            List<string> NewUrl = new List<string>();
            List<string> OldUrl = new List<string>();

            int numrow = 0;
            

            string mx_revised_url_q = "SELECT * FROM redirected_url_db";            
            string az_boylqmi_ifp_update_q = "UPDATE boyl_quick_move_in_home  SET [interactive_floor_plan] = @new WHERE [interactive_floor_plan]= @old";
            string az_boylhd_ifp_update_q = "UPDATE boyl_home_design  SET [interative_floor_plan] = @new WHERE [interative_floor_plan]= @old";
            string az_cb_lqmi_ifp_update_q = "UPDATE cb_quick_move_in_home  SET [interactive_floor_plan] = @new WHERE [interactive_floor_plan]= @old";
            string az_cb_comm_hd_ifp_update_q = "UPDATE cb_community_home_design SET [interative_floor_plan] = @new WHERE [interative_floor_plan]= @old";

            try
            {
                azcom2.Parameters.AddWithValue("@new", new_url);
                azcom2.Parameters.AddWithValue("@old", old_url);
              
                MySqlCommand mxcom = new MySqlCommand(mx_revised_url_q, khov);
                mxdata = mxcom.ExecuteReader();
                
                int i = 0;
                azcom2.Transaction.Save("Point_A");

                while (mxdata.Read()){// while sill reading from repacement values

                    NewUrl.Add(mxdata["new_url"].ToString());// populate replacement list
                    OldUrl.Add(mxdata["old_url"].ToString());

                    new_url = NewUrl[i];// set repalcemet variable
                    old_url = OldUrl[i];

                    azcom2.Parameters["@old"].Value = old_url; // set replacement parameter
                    azcom2.Parameters["@new"].Value = new_url;

                    azcom2.CommandText = az_boylqmi_ifp_update_q;
                    azcom2.ExecuteNonQuery(); // Execute Query BOYL QMI

                    azcom2.CommandText = az_boylhd_ifp_update_q;
                    azcom2.ExecuteNonQuery(); // Execute Query BOYL HOME Design

                    azcom2.CommandText = az_cb_comm_hd_ifp_update_q;
                    azcom2.ExecuteNonQuery(); // Execute Query Community HOME Design

                    azcom2.CommandText = az_cb_lqmi_ifp_update_q;
                    numrow = azcom2.ExecuteNonQuery(); // Execute Query Community QMI

                    Console.WriteLine(old_url+" "
                        +new_url);

                    i++;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Un-handled Program Failure ! " + ex);
                upTrans = this.RollBackAzureRd(upTrans);
            }
            Console.WriteLine("number of rows affected =" + " " + numrow);
            Console.WriteLine("Finished !");
            return upTrans;
        }

//
        public SqlTransaction AzureBOYL_QMI()
        { // scrub azure of old style url's updated from the feed

            Console.WriteLine("Start ! ");

            DB azure = new DB();
            DB matrix = new DB();
            SqlConnection cnn = azure.GetKhovProd();
            MySqlConnection khov = matrix.GetMatrix();
            SqlDataReader azdata;
            MySqlDataReader mxdata;
            SqlCommand azcom2 = new SqlCommand();
            SqlCommand azcom = new SqlCommand();
            SqlTransaction upTrans = null;

            azcom2.Connection = cnn;
            azcom.Connection = cnn;

            azcom2.Transaction = cnn.BeginTransaction("Trans");
            upTrans = azcom2.Transaction;
                       
            
            string new_url = null;
            string old_url = null;
            string data = null;

            List<string> NewUrl = new List<string>();
            List<string> OldUrl = new List<string>();
            
            int numrow = 0;
            int count = 0;

            string mx_revised_url_q = "SELECT * FROM redirected_url_db";
            string az_boylqmi_ifp_update_q = "UPDATE boyl_quick_move_in_home  SET [interactive_floor_plan] = @new WHERE [interactive_floor_plan]= @old";
            string count_az_boylqmi_ifp_update_q = "SELECT DISTINCT COUNT ([interactive_floor_plan]) FROM boyl_quick_move_in_home WHERE (NOT(([interactive_floor_plan] IN(''))))";
            string sel_az_boylqmi_ifp_update_q = "SELECT ([interactive_floor_plan]) FROM boyl_quick_move_in_home WHERE (NOT(([interactive_floor_plan] IN(''))))";
                
            try
            {
                azcom2.Parameters.AddWithValue("@new", new_url);
                azcom2.Parameters.AddWithValue("@old", old_url);
               
                data = (string)khov.Database;
                Console.WriteLine(data);              
               
                int i = 0;
                
                MySqlCommand mxcom = new MySqlCommand(mx_revised_url_q, khov);
                mxdata = mxcom.ExecuteReader();

                while (mxdata.Read())
                {// while sill reading from repacement values

                    NewUrl.Add(mxdata["new_url"].ToString());// populate replacement list
                    OldUrl.Add(mxdata["old_url"].ToString());

                    new_url = NewUrl[i];// set repalcemet variable
                    old_url = OldUrl[i];

                    azcom2.Parameters["@old"].Value = old_url; // set replacement parameter
                    azcom2.Parameters["@new"].Value = new_url;

                    azcom2.CommandText = az_boylqmi_ifp_update_q;
                    numrow = azcom2.ExecuteNonQuery(); // Execute Query BOYL QMI

                    Console.WriteLine(old_url);
                    Console.WriteLine(new_url);
                    Console.WriteLine();
                   
                    i++;
                }
                mxdata.Close();

                azcom2.CommandText = sel_az_boylqmi_ifp_update_q;
                azdata = azcom2.ExecuteReader();

                while (azdata.Read())
                {
                    Console.WriteLine("*"+azdata["interactive_floor_plan"].ToString()+"*");
                }

                azdata.Close();
                Console.WriteLine("Query: " + "UPDATE boyl_quick_move_in_home  SET [interactive_floor_plan] = @new WHERE [interactive_floor_plan]= @old");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Un-handled Program Failure ! " + ex);
                upTrans = this.RollBackAzureRd(upTrans);
            }
            
            azcom2.CommandText = count_az_boylqmi_ifp_update_q;
            count = (int)azcom2.ExecuteScalar();
            Console.WriteLine("number of rows scheduled" + " " + count);
            Console.WriteLine("number of rows affected =" + " " + numrow);
            Console.WriteLine("Finished !");
            return upTrans;
        }
//
        public SqlTransaction AzureBOYL_HD()
        { // scrub azure of old style url's updated from the feed

            Console.WriteLine("Start ! ");

            DB azure = new DB();
            DB matrix = new DB();
            SqlConnection cnn = azure.GetKhovProd();
            MySqlConnection khov = matrix.GetMatrix();
            SqlDataReader azdata;
            MySqlDataReader mxdata;
            SqlCommand azcom2 = new SqlCommand();
            SqlTransaction upTrans = null;

            azcom2.Connection = cnn;

            azcom2.Transaction = cnn.BeginTransaction("Trans");
            upTrans = azcom2.Transaction;
            string new_url = null;
            string old_url = null;
            string data = null;

            List<string> NewUrl = new List<string>();
            List<string> OldUrl = new List<string>();

            int numrow = 0;
            int count = 0;

            string mx_revised_url_q = "SELECT * FROM redirected_url_db";            
            string az_boylhd_ifp_update_q = "UPDATE boyl_home_design  SET [interative_floor_plan] = @new WHERE [interative_floor_plan]= @old";
            string count_az_boylhd_ifp_update_q = "SELECT COUNT ([interative_floor_plan]) FROM boyl_home_design WHERE (NOT((interative_floor_plan IN(''))))";
            string sel_az_boylhd_ifp_update_q = "SELECT ([interative_floor_plan]) FROM boyl_home_design WHERE (NOT((interative_floor_plan IN(''))))";
            
            try
            {
                azcom2.Parameters.AddWithValue("@new", new_url);
                azcom2.Parameters.AddWithValue("@old", old_url);

                MySqlCommand mxcom = new MySqlCommand(mx_revised_url_q, khov);
                mxdata = mxcom.ExecuteReader();

                int i = 0;
                azcom2.Transaction.Save("Point_A");

                data = (string)khov.Database;
                Console.WriteLine(data);
              
                while (mxdata.Read())
                {// while sill reading from repacement values

                    NewUrl.Add(mxdata["new_url"].ToString());// populate replacement list
                    OldUrl.Add(mxdata["old_url"].ToString());

                    new_url = NewUrl[i];// set repalcemet variable
                    old_url = OldUrl[i];

                    azcom2.Parameters["@old"].Value = old_url; // set replacement parameter
                    azcom2.Parameters["@new"].Value = new_url;

                    azcom2.CommandText = az_boylhd_ifp_update_q;
                    azcom2.ExecuteNonQuery(); // Execute Query BOYL HOME Design


                    Console.WriteLine(old_url);
                    Console.WriteLine(new_url);
                    Console.WriteLine();
                                      

                    i++;
                }

                azcom2.CommandText = sel_az_boylhd_ifp_update_q;
                azdata = azcom2.ExecuteReader();

                while (azdata.Read())
                {
                    Console.WriteLine("*" + azdata["interative_floor_plan"].ToString() + "*");
                }

                azdata.Close();
                Console.WriteLine("Query: " + "UPDATE boyl_home_design  SET [interative_floor_plan] = @new WHERE [interative_floor_plan]= @old");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Un-handled Program Failure ! " + ex);
                upTrans = this.RollBackAzureRd(upTrans);
            }
            
            azcom2.CommandText = count_az_boylhd_ifp_update_q;
            count = (int)azcom2.ExecuteScalar();
            Console.WriteLine("number of rows scheduled" + " " + count);
            Console.WriteLine("number of rows affected =" + " " + numrow);
            Console.WriteLine("Finished !");
            return upTrans;
        }
//
        public SqlTransaction AzureComm_QMI()
        { // scrub azure of old style url's updated from the feed

            Console.WriteLine("Start ! ");

            DB azure = new DB();
            DB matrix = new DB();
            SqlConnection cnn = azure.GetKhovProd();
            MySqlConnection khov = matrix.GetMatrix();
            SqlDataReader azdata;
            MySqlDataReader mxdata;
            SqlCommand azcom2 = new SqlCommand();
            SqlTransaction upTrans = null;

            azcom2.Connection = cnn;

            azcom2.Transaction = cnn.BeginTransaction("Trans");
            upTrans = azcom2.Transaction;

            string new_url = null;
            string old_url = null;
            string data = null;
       
            List<string> NewUrl = new List<string>();
            List<string> OldUrl = new List<string>();

            int numrow = 0;
            int count = 0;

            string mx_revised_url_q = "SELECT * FROM redirected_url_db";
            string az_cb_lqmi_ifp_update_q = "UPDATE cb_quick_move_in_home  SET [interactive_floor_plan] = @new WHERE [interactive_floor_plan]= @old";
            string count_az_cb_lqmi_ifp_update_q = "SELECT COUNT ([interactive_floor_plan]) FROM cb_quick_move_in_home  WHERE (NOT((interactive_floor_plan IN(''))))";
            string sel_az_cb_lqmi_ifp_update_q = "SELECT ([interactive_floor_plan]) FROM cb_quick_move_in_home  WHERE (NOT((interactive_floor_plan IN(''))))";
            

            try
            {
                azcom2.Parameters.AddWithValue("@new", new_url);
                azcom2.Parameters.AddWithValue("@old", old_url);

                MySqlCommand mxcom = new MySqlCommand(mx_revised_url_q, khov);
                mxdata = mxcom.ExecuteReader();

                int i = 0;
                azcom2.Transaction.Save("Point_A");

                data = (string)khov.Database;
                Console.WriteLine(data);                

                while (mxdata.Read())
                {// while sill reading from repacement values

                    NewUrl.Add(mxdata["new_url"].ToString());// populate replacement list
                    OldUrl.Add(mxdata["old_url"].ToString());

                    new_url = NewUrl[i];// set repalcemet variable
                    old_url = OldUrl[i];

                    azcom2.Parameters["@old"].Value = old_url; // set replacement parameter
                    azcom2.Parameters["@new"].Value = new_url;

                    azcom2.CommandText = az_cb_lqmi_ifp_update_q;
                   count = count + azcom2.ExecuteNonQuery(); // Execute Query Community QMI


                    Console.WriteLine(old_url);
                    Console.WriteLine(new_url);
                    Console.WriteLine();
                    
                    i++;
                }
                /*azcom2.Transaction.Commit();
                azcom2.Dispose();
                khov.Close();*/
                azcom2.CommandText = sel_az_cb_lqmi_ifp_update_q;
                azdata = azcom2.ExecuteReader();

                while (azdata.Read())
                {
                    Console.WriteLine("*" + azdata["interactive_floor_plan"].ToString() + "*");
                }

                azdata.Close();
                Console.WriteLine("Query: " + "UPDATE cb_quick_move_in_home  SET [interactive_floor_plan] = @new WHERE [interactive_floor_plan]= @old");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Un-handled Program Failure ! " + ex);
                upTrans = this.RollBackAzureRd(upTrans);
            }

            azcom2.CommandText = count_az_cb_lqmi_ifp_update_q;
            count = (int)azcom2.ExecuteScalar();
            Console.WriteLine("number of rows scheduled" + " " + count);               
            Console.WriteLine("number of rows affected =" + " " + numrow);
            Console.WriteLine("Finished !");
            return upTrans;
        }
//
        public SqlTransaction AzureComm_HD()
        { // scrub azure of old style url's updated from the feed

            Console.WriteLine("Start ! ");

            DB azure = new DB();
            DB matrix = new DB();
            SqlConnection cnn = azure.GetKhovProd();
            MySqlConnection khov = matrix.GetMatrix();
            SqlDataReader azdata;
            MySqlDataReader mxdata;
            SqlCommand azcom2 = new SqlCommand();
            SqlTransaction upTrans = null;

            azcom2.Connection = cnn;

            azcom2.Transaction = cnn.BeginTransaction("Trans");
            upTrans = azcom2.Transaction;
            string new_url = null;
            string old_url = null;
            string data = null;

            List<string> NewUrl = new List<string>();
            List<string> OldUrl = new List<string>();

            int numrow = 0;
            int count = 0;
            

            string mx_revised_url_q = "SELECT * FROM redirected_url_db";
            string az_cb_comm_hd_ifp_update_q = "UPDATE cb_community_home_design SET [interative_floor_plan] = @new WHERE [interative_floor_plan]= @old";
            string count_az_cb_comm_hd_ifp_update_q = "SELECT COUNT ([interative_floor_plan]) FROM cb_community_home_design  WHERE (NOT((interative_floor_plan IN(''))))";
            string sel_az_cb_comm_hd_ifp_update_q = "SELECT ([interative_floor_plan]) FROM cb_community_home_design  WHERE (NOT((interative_floor_plan IN(''))))";

            try
            {
                azcom2.Parameters.AddWithValue("@new", new_url);
                azcom2.Parameters.AddWithValue("@old", old_url);

                MySqlCommand mxcom = new MySqlCommand(mx_revised_url_q, khov);
                mxdata = mxcom.ExecuteReader();

                int i = 0;
                azcom2.Transaction.Save("Point_A");

              

                data = (string)khov.Database;
                Console.WriteLine(data);
               
                    

                while (mxdata.Read())
                {// while sill reading from repacement values

                    NewUrl.Add(mxdata["new_url"].ToString());// populate replacement list
                    OldUrl.Add(mxdata["old_url"].ToString());

                    new_url = NewUrl[i];// set repalcemet variable
                    old_url = OldUrl[i];

                    azcom2.Parameters["@old"].Value = old_url; // set replacement parameter
                    azcom2.Parameters["@new"].Value = new_url;
                   
                    azcom2.CommandText = az_cb_comm_hd_ifp_update_q;
                    azcom2.ExecuteNonQuery(); // Execute Query Community HOME Design


                    Console.WriteLine(old_url);
                    Console.WriteLine(new_url);
                    Console.WriteLine();

                    i++;
                }
                /*azcom2.Transaction.Commit();
                azcom2.Dispose();
                khov.Close();*/
                azcom2.CommandText = sel_az_cb_comm_hd_ifp_update_q;
                azdata = azcom2.ExecuteReader();

                while (azdata.Read())
                {
                    Console.WriteLine("*" + azdata["interative_floor_plan"].ToString() + "*");
                }

                azdata.Close();
                Console.WriteLine("Query: " + "UPDATE cb_community_home_design SET [interative_floor_plan] = @new WHERE [interative_floor_plan]= @old");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Un-handled Program Failure ! " + ex);
                upTrans = this.RollBackAzureRd(upTrans);
            }
            azcom2.CommandText = count_az_cb_comm_hd_ifp_update_q;
            count = (int)azcom2.ExecuteScalar();
            Console.WriteLine("number of rows scheduled" + " " + count);
            Console.WriteLine("number of rows affected =" + " " + numrow);
            Console.WriteLine("Finished !");
            return upTrans;
        }
    //
        public MySqlTransaction BackUpAzure(int x) // copy azure old style url's not in the feed to MYSQL in Matrix
        {

            Console.WriteLine("Start ! ");

            DB azure = new DB();
            DB matrix = new DB();
            SqlConnection cnn = azure.GetAzure301();
            MySqlConnection khov = matrix.GetMatrix();
            SqlDataReader azdata;
            MySqlDataReader mxdata;
            SqlCommand azcom2 = new SqlCommand();
            SqlCommand azcom = new SqlCommand();
            MySqlCommand mxcom2 = new MySqlCommand();
            MySqlTransaction upTrans = null;

            mxcom2.Connection = khov;
            azcom2.Connection = cnn;

            mxcom2.Transaction = khov.BeginTransaction();
            upTrans = mxcom2.Transaction;
            string ifp = "0";
            string content_id = "";
            mxcom2.Parameters.AddWithValue("@ifp", ifp);
            mxcom2.Parameters.AddWithValue("@content_id", content_id);
            List<string> IFP = new List<string>();
            List<string> CONTENT_ID = new List<string>();

            int numrow = 0;
            int count = 0;

            string count_az_old_url_q = "SELECT COUNT ([interative_floor_plan])  FROM [cb_community_home_design]";
            string az_old_url_q = "SELECT [interative_floor_plan],[content_id]  FROM [cb_community_home_design]";

            string az_old_cbqmi_url_q = "SELECT [interactive_floor_plan],[content_id] FROM [cb_quick_move_in_home]";            
            string count_az_old_cbqmi_url_q = "SELECT COUNT ([interactive_floor_plan])  FROM [cb_quick_move_in_home]";

            string count_old_boylqmi_url_q = "SELECT COUNT ([interactive_floor_plan])  FROM [boyl_quick_move_in_home]";
            string az_old_boylqmi_url_q = "SELECT [interactive_floor_plan],[content_id] FROM [boyl_quick_move_in_home]";
            
            
            string mx_cb_commhd_q = "INSERT INTO cb_community_hd_db  (ifp,content_id) VALUES  (@ifp,@content_id)";//modifies a record
            string mx_cb_qmi_q = "INSERT INTO cb_community_qmi_db  (ifp,content_id) VALUES  (@ifp,@content_id)";//modifies a record
            string mx_boyl_qmi_q = "INSERT INTO boyl_qmi  (ifp,content_id) VALUES  (@ifp,@content_id)";//modifies a record

            string[] query = { az_old_url_q, az_old_cbqmi_url_q, az_old_boylqmi_url_q };
            string[] insert = { mx_cb_commhd_q, mx_cb_qmi_q, mx_boyl_qmi_q };
            string[] count_q = { count_az_old_url_q, count_az_old_cbqmi_url_q, count_old_boylqmi_url_q };

            try
            {
                int i = 0;
                
                //0
                azcom2.CommandText = query[x];
                azdata = azcom2.ExecuteReader();



                while (azdata.Read())
                {// while sill reading from repacement values
                    if (azdata.GetName(0) == "interative_floor_plan")
                    {
                        ifp = azdata["interative_floor_plan"].ToString();// populate replacement list
                        content_id = azdata["content_id"].ToString();// populate replacement list
                    }

                    if (azdata.GetName(0) == "interactive_floor_plan")
                    {
                        ifp = azdata["interactive_floor_plan"].ToString();// populate replacement list
                        content_id = azdata["content_id"].ToString();// populate replacement list


                    }

                    mxcom2.Parameters["@ifp"].Value = ifp; // set replacement parameter
                    mxcom2.Parameters["@content_id"].Value = content_id;

                    mxcom2.CommandText = insert[x];
                    numrow = numrow + mxcom2.ExecuteNonQuery(); // Execute Query comm hd                    
                    Console.WriteLine(ifp);
                    i++;
                }
                azdata.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Un-handled Program Failure ! " + ex);
                upTrans = this.RollBackMatrixRd(upTrans);
            }

          /*  azcom2.CommandText = query[x];
            azdata = azcom2.ExecuteReader();

            while (azdata.Read())
            {
                if (azdata.GetName(0) == "interative_floor_plan")
                {
                    Console.WriteLine("*" + azdata["interative_floor_plan"].ToString() + "*");
                }
                if (azdata.GetName(0) == "interactive_floor_plan")
                {
                    Console.WriteLine("*" + azdata["interactive_floor_plan"].ToString() + "*");
                }
            }
            
            azdata.Close();*/
            Console.WriteLine("Query: " + query[x]);

            azcom2.CommandText = count_q[x];
            count = (int)azcom2.ExecuteScalar();
            Console.WriteLine("number of rows scheduled" + " " + count);
            Console.WriteLine("number of rows affected =" + " " + numrow);
            Console.WriteLine("Finished !");
            Console.ReadLine();
            return upTrans;
        }               
        //
    }//end prog clas
}// end nmaespace
