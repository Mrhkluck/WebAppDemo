using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using System.Data;
using System.Data.SqlClient;

namespace WebAppDemo.DatabaseWork
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection("server=ROG_STRIX_SSD;database=pgdacsepdb;uid=sa;pwd=sql");
            String insertQry = "insert into user_master values('"+txtUserName.Text+ "','" + txtPassword.Text + "','" + txtName.Text + "'," +txtMobile.Text+")";
            //Geting value from direct text box here int value must written in "" and string Must be in '""'
            //SqlCommand cmd = new SqlCommand(insertQry,con);
            // con.Open();
            //int res = cmd.ExecuteNonQuery();
            int res = BusinessLogic.ExecuteQry(insertQry);
            if(res > 0)
            {
                Response.Write("User Details saved Successfully!!!");
                ClearText();
            }
           // con.Close();

        }

        void ClearText()
        {
            txtUserName.Text = "";
            txtName.Text = "";
            txtMobile.Text = "";

        }
    }
}