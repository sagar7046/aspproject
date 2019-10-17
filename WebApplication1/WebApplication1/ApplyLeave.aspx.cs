using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Routing;

namespace WebApplication1
{
    public partial class ApplyLeave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_apply_Click(object sender, EventArgs e)
        {
            RouteParameter parameter = new RouteParameter();
            parameter.Name = "name";
            parameter.DefaultValue = textbox1.Text;
            RouteValueDictionary dictionary = new RouteValueDictionary
            {
                {"name",textbox1.Text },{"desc",textbox2.Text}
            };
            Response.Redirect(GetRouteUrl("Leave",dictionary ));
        }
    }
}