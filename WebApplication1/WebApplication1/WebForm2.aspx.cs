using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\WebApplication1\WebApplication1\App_Data\Database1.mdf;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Test", con);
            DataSet data = new DataSet("Test");
            adapter.Fill(data);
            int cnt = data.Tables[0].Rows.Count;
            if(cnt>0)
            {

                GridView1.DataSource = data.Tables[0];
                GridView1.DataBind();
            }
        }

        protected void btn_route_Click(object sender, EventArgs e)
        {
            Response.Redirect(GetRouteUrl("HomeRoute", null));
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            byte[] text = System.Text.ASCIIEncoding.ASCII.GetBytes(TextBox1.Text);
                string t=Convert.ToBase64String(text);
            Response.Write(t);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}