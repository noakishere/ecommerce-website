using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bulma_Restaurant
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            HttpCookie cookie = Request.Cookies["UserDetails"];
            if(cookie != null)
            {
                Label2.Text = "Hello " + cookie["Fname"] + "!";
            }
            else
            {
                Label2.Text = "";
            }
        }
    }
}