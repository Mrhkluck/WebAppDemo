using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace WebAppDemo.DatabaseWork
{
    public partial class AdapterDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Logic to fatch all users and display in Gridview
        protected void Button1_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection("server=ROG_STRIX_SSD;database=pgdacsepdb;uid=sa;pwd=sql");
            //DataSet ds = new DataSet();
           // DataTable dt = new DataTable();
            string qry = "select user_id,username,fullname,mobile from user_master";

            //initialize adapter wit query and connection
            // SqlDataAdapter adapter = new SqlDataAdapter(qry,con);
            //call adaptor fill() method to get data from database and fill it into dataset

            //adapter.Fill(ds);
            //adapter.Fill(dt);

            // It stablist connection with your database if all the database connection is correct else passes the comment for execution
            //passes the comment for execution
            //If query is ok it fills or add the data received from database server 
            //Closes the database


            // Label1.Text = "Total Record found:" + ds.Tables[0].Rows.Count;
            // Label1.Text = "Total Record found:" + dt.Rows.Count;

            //Disconnected envoironment
            //Response.Write("<br/>username:"+ds.Tables[0].Rows[0][1]);

            //Binding data with Gridview
            //  GridView1.DataSource = dt;
            //GridView1.DataSource = ds;
            // GridView1.DataBind();

            BusinessLogic.FillGrid(qry,GridView1);

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}