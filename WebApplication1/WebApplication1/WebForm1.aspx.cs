using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(Server.MapPath("~/CrystalReport1.rpt"));
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\WebApplication1\WebApplication1\App_Data\Database1.mdf;Integrated Security=True");

            SqlDataAdapter adapter = new SqlDataAdapter("select * from Demo", con);

            DataSet ds = new DataSet("Demo");

         //   adapter.Fill(ds,"Demo");

           // report.SetDataSource(ds);

            DataSet1 dataSet1 = new DataSet1();

            DataSet1TableAdapters.TestTableAdapter testTableAdapter = new DataSet1TableAdapters.TestTableAdapter();
            testTableAdapter.Fill(dataSet1.Test);

            DataSet1TableAdapters.DemoTableAdapter demoTable = new DataSet1TableAdapters.DemoTableAdapter();
            demoTable.Fill(dataSet1.Demo);

            DataSet1TableAdapters.RecordTableAdapter recordTableAdapter = new DataSet1TableAdapters.RecordTableAdapter();
            recordTableAdapter.RecordBy(dataSet1.Record, 23);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


           // dataSet1.Tables.Add(dataTable);
            report.SetDataSource(dataSet1);
            
            report.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat,Response,false,"abc");
        }
    }
}