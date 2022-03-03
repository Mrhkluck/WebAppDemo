using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;     //For ConnectionState enum
using System.Data.SqlClient;


namespace WebAppDemo.DatabaseWork
{
    
    public partial class DbConnection : System.Web.UI.Page
    {
        static SqlConnection con;
        String connectionString = "server=ROG_STRIX_SSD;database=pgdacsepdb;uid=sa;pwd=sql";
        //String connectionString = "server=ROG_STRIX_SSD;database=pgdacsepdb;integrated security=true";


        //ASP.NET Page Life Cycle
        /*
          
        Page_PreInit - Initialization
        Page_Init - Initialization
        Page_Load - Page specific work
        Page_Render - for Rending 
        Page_Unload- Memory cleanup

        */
        protected void Page_PreInit(object sender, EventArgs e)
        {
            //Object creation
            Response.Write("Preinit called<br/>");

        }
        protected void Page_Init(object sender, EventArgs e)
        {
            //Object properties intialization
            Response.Write("init called<br/>");

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("load called<br/>");
            if (!Page.IsPostBack)
            {
                Response.Write("Inside if load called<br/>");
                con = new SqlConnection(connectionString);
            }

        }

        //connect with database
        protected void Button1_Click(object sender, EventArgs e)
        {
           // con = new SqlConnection(connectionString);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                Response.Write("<b>Connected with Database server successfully!!!!<b>");
            }
            else
            {
                Response.Write("<b> Already Connected with Database!!!!<b>");

            }
        }

        //disconnect from databaase
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                Response.Write("<b>Disconnected with Database server successfully!!!!<b>");
            }
            else
            {
                Response.Write("<b> Already disconnected with Database!!!!<b>");

            }
        }
        //Check connection state
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            { 
                Response.Write("<b>Connection is open!!!!<b>");
            }
            else
            {
                Response.Write("<b> Connection is closed<b>");

            }

        }
        
    }
}