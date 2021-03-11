using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bulma_Restaurant
{
    public partial class UserDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserDetails"];
            if(cookie != null)
            {
                Label1.Text = cookie["Fname"];
            }
            else if(cookie == null)
            {
                Server.Transfer("SignUp.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["UserDetails"].Expires = DateTime.Now;
            Response.Redirect("SignUp.aspx");
        }
    }
}