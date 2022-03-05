using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#region NamespacesForBusinessLogic
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
#endregion



namespace WebAppDemo
{
    public static class BusinessLogic
    {
        //DaO layer in java here it is called DataAccess Layar
        static SqlConnection con;
        static BusinessLogic()
        {
            //To Read the connection from web.config 
            String constring = ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString;
            //connection string
            // con = new SqlConnection("server;database;uid,pwd");

            con = new SqlConnection(constring);
        }
        public static void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public static void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public static int ExecuteQry(string qry)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            OpenConnection();
            int res = cmd.ExecuteNonQuery();
            CloseConnection();
            return res;
        }

        //Dll insert/update/delete
        public static int ExecuteQry(string pqry,SqlParameter[]parameters)
        {
            SqlCommand cmd = new SqlCommand(pqry,con);
            cmd.Parameters.AddRange(parameters);
            OpenConnection();
            int res= cmd.ExecuteNonQuery();
            CloseConnection();
            return res;
        }

        //Data Getter
        public static DataSet GetDataSet(string qry)
        {
            SqlDataAdapter adapter=new SqlDataAdapter(qry,con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        //Data reader
        public static SqlDataReader GetDataReader(string qry)
        {
            SqlCommand cmd= new SqlCommand(qry,con);
            OpenConnection();
            SqlDataReader dtr = cmd.ExecuteReader();
            //CloseConnection();
            return dtr;
        }
        public static void FillGrid(String qry,GridView gridView)
        {
            gridView.DataSource=GetDataSet(qry);   
            gridView.DataBind();
        }

        public static object AuthenticateUser(String username,string pwd)
        {
            //Single row single column so we use here cmd or we can use dataset or data adeptor
            string authQry = "select username from user_master " +
                "where username='" + username + "' and password= '" + pwd + "'";
            SqlCommand cmd = new SqlCommand(authQry, con);
            OpenConnection();
            object uname= cmd.ExecuteScalar();
            return uname;

        }
    }
}