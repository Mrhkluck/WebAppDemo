using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WebAppDemo.DatabaseWork
{
    public partial class ManageUser : System.Web.UI.Page
    {
        //Make a dao layer so that it cannot be use again and again just like in jave
        SqlConnection con = new SqlConnection("server=ROG_STRIX_SSD;database=pgdacsepdb;uid=sa;pwd=sql");
        DataSet ds;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader dtr;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillGrid();
            }
            if(Request.QueryString["name"] != null)
            {
                //Retrieving data from querystring
                Response.Write("Welcome:"+ Request.QueryString["name"]);
            }
            else
            {
                //Server.Transfer("Login.aspx");
                Response.Redirect("Login.aspx");
            }

        }


        protected void Btn_Click(object sender, EventArgs e)
        {
            //Working with Paratrize queries
            //string searchQry = "select username,Fullname,mbile where user_id=" + txtUserId.Text + txtName.Text+ txtUserName.Text+txtMobile.Text;
            string searchQry = "select username,Fullname,mobile from user_master where user_id=@id"; // In java We use ?
            cmd = new SqlCommand(searchQry, con);
            //Binding parameter value
            cmd.Parameters.AddWithValue("@id", txtUserId.Text);

            con.Open();
            //fetching data using DataReader
            dtr = cmd.ExecuteReader();

            //dtr.HasRows
            //while(dtr.Read()) { } //injava we use next() which read data one by one - For Multiple record
            if (dtr.Read())
            {
                //txtUserName.Text = dtr[0].ToString();
                //txtName.Text = dtr[1].ToString();
                //txtMobile.Text = dtr[2].ToString();
                txtUserName.Text = dtr.GetString(0);
               // dtr.Close(); it is not dumping on our memory as like dataset. Because it is geting data from datatabe directly so we have to maintain connection to
               //overcome it we use adapter 
               //Generally we use it for search recod of a single record not multirecord
                txtName.Text = dtr.GetString(1);
                txtMobile.Text = dtr.GetDecimal(2).ToString();


                Label1.Text = "";

            }
            else
            {
                Label1.Text = "No Record found";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            con.Close();


        }

        // protected asyns void btnUpdate_Click(object sender, EventArgs e)
        protected  void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQry = "update user_master set " +
                "username=@uname,fullname=@name,mobile=@mobile where user_id=@id";
            cmd = new SqlCommand(updateQry, con);
            //cmd.Parameters.AddWithValue("@id",txtUserId.Text);
            //cmd.Parameters.AddWithValue("@uname",txtUserName.Text);
            //cmd.Parameters.AddWithValue("@name",txtName.Text);
            //cmd.Parameters.AddWithValue("@mobile",txtMobile.Text);

            //Create SqlParameter Array
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id",txtUserId.Text),
                new SqlParameter("@uname",txtUserName.Text),
                new SqlParameter("@name",txtName.Text),
                new SqlParameter("@mobile",txtMobile.Text)
            };
            //cmd.Parameters.AddRange(parameters);
            //await con.OpenAsync();//asynchronous open call
            //int res =await cmd.ExecuteNonQueryAsync(); //asynchronous ExecuteNonQuery call
            //if (res>0)
            //{
            //    Label1.Text = "User detail Updated Successfully";
            //    FillGrid();
            //}
            //con.Close();

           int res =  BusinessLogic.ExecuteQry(updateQry, parameters);
            if (res > 0)
            {
                Label1.Text = "User detail Updated Successfully";
                  FillGrid();

            }


        }

       void FillGrid()
        {
            string qry = "select user_id,username,fullname,mobile from user_master";
            adapter = new SqlDataAdapter(qry, con);
            ds = new DataSet(); 
            adapter.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void btnVierAll_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
    
}