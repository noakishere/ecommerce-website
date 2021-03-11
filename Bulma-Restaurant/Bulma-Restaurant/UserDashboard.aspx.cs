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
                Label1.Text = cookie["Fname"] +"\'s dashboard";
            }
            else if(cookie == null)
            {
                Server.Transfer("SignUp.aspx");
            }

            BulmaDataClassesDataContext dataContext = new BulmaDataClassesDataContext();
            GridView1.DataSource = from Order in dataContext.Orders
                                   where Order.CustomerId == Int32.Parse(cookie["userID"].ToString())
                                   select Order;

            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["UserDetails"].Expires = DateTime.Now;
            Response.Redirect("Index.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserDetails"];
            using (BulmaDataClassesDataContext dbContext = new BulmaDataClassesDataContext())
            {
                Customer prod = dbContext.Customers.SingleOrDefault(x => x.Id == Int32.Parse(cookie["userID"].ToString()));
                dbContext.Customers.DeleteOnSubmit(prod);
                dbContext.SubmitChanges();
            }

            Response.Cookies["UserDetails"].Expires = DateTime.Now;
            Response.Redirect("Index.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserDetails"];

            userNameTextBox.Visible = true;
            pswrdTextBox.Visible = true;
            cancelBtn.Visible = true;
            confirmBtn.Visible = true;

            userNameTextBox.Text = cookie["Fname"].ToString();
        }

        protected void confirmBtn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserDetails"];
            using (BulmaDataClassesDataContext dbContext = new BulmaDataClassesDataContext())
            {
                Customer customer = dbContext.Customers.SingleOrDefault(x => x.Id == Int32.Parse(cookie["userID"].ToString()));
                customer.username = userNameTextBox.Text;
                customer.password = pswrdTextBox.Text;

                dbContext.SubmitChanges();
            }

            userNameTextBox.Visible = false;
            pswrdTextBox.Visible = false;
            cancelBtn.Visible = false;
            confirmBtn.Visible = false;

            userNameTextBox.Text = "";
            pswrdTextBox.Text = "";

            Label1.Text += " - Profile Updated!";
        }

        protected void cancelBtn_Click(object sender, EventArgs e)
        {
            userNameTextBox.Visible = false;
            pswrdTextBox.Visible = false;
            cancelBtn.Visible = false;
            confirmBtn.Visible = false;

            userNameTextBox.Text = "";
            pswrdTextBox.Text = "";
        }
    }
}