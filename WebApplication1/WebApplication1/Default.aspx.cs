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
    public partial class _Default : Page
    {
        public string arr="";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\WebApplication1\WebApplication1\App_Data\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from ChartDemo",con);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            
            dob2.Text = "10/16/2019";
            
            if(ds.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<ds.Tables[0].Rows.Count-1;i++)
                {
                    arr = arr + ds.Tables[0].Rows[i][1].ToString() + ",";
                }
                arr = arr + ds.Tables[0].Rows[ds.Tables[0].Rows.Count-1][1].ToString();
            }
            Response.Write(arr);
        }
    }
}