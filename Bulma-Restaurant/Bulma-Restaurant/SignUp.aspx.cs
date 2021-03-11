using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bulma_Restaurant
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserDetails"];
            if (cookie != null)
            {
                Response.Redirect("UserDashboard.aspx");
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            if(IsValidUser(TextBox1.Text, TextBox2.Text))
            {
                Response.Redirect("UserDashboard.aspx");
            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                resultLabel.Text = "Wrong input";
            }
        }

        private bool IsValidUser(string userName, string password)
        {
            BulmaDataClassesDataContext context = new BulmaDataClassesDataContext();

            var customer = from c in context.Customers
                           where c.username == userName
                           && c.password == password
                           select c;

            if (customer.Any())
            {
                Customer c = customer.First();
                HttpCookie cookie = new HttpCookie("UserDetails");
                cookie["Fname"] = TextBox1.Text;
                cookie["userID"] = c.Id.ToString();
                Response.Cookies.Add(cookie);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RegisterUser()
        {

            using (BulmaDataClassesDataContext dbContext = new BulmaDataClassesDataContext())
            {
                if (TextBox1.Text != "" && TextBox2.Text != "")
                {
                    Customer newCustomer = new Customer();
                    newCustomer.username = TextBox1.Text;
                    newCustomer.password = TextBox2.Text;
                    dbContext.Customers.InsertOnSubmit(newCustomer);
                    dbContext.SubmitChanges();

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    resultLabel.Text = "You have successfully registered";
                }
                else
                {
                    resultLabel.Text += "Wrong input";
                }
            }


        }
    }
}