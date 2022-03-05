using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo.DatabaseWork
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Object uname= BusinessLogic.AuthenticateUser(TxtUserName.Text,TxtPassword.Text);
            if (uname != null)
            {
                //passing data using querying 
                Response.Redirect("ManageUser.aspx?name="+uname);//local / global both url //in java sendRedirect()
               // Server.Transfer();//only for local url injava response(),Forward()
               //Server.Execute(); //in java we use include()// here we use it less because it get in master site
            }
            else
            {
                lblMessage.Text = "Invalid Username/Password!!";
            }
        }
    }
}