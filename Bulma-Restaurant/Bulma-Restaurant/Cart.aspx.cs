using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bulma_Restaurant
{
    public partial class Cart : System.Web.UI.Page
    {
        double price = 0.00;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["val"] != null && Session["val"].ToString() != "")
            {
                answer.Text = Session["val"].ToString();
                Session.Remove("val");

            }
            else
            {
                answer.Text = "Your cart is empty!";
            }

            if (Session["price"] != null)
            {
                priceLabel.Text = "Total price: $" + Session["price"].ToString();

                
                if(Double.Parse(Session["price"].ToString()) < 25)
                {
                    deliveryAmount.Text = "Delivery: $3.99";
                    price = Double.Parse(Session["price"].ToString()) + 3.99;
                }
                else
                {
                    deliveryAmount.Text = "Delivery: FREE SHIPPING";
                    price = Double.Parse(Session["price"].ToString());
                }
                
            }
            else
            {
                priceLabel.Text = "$0.00";
            }

            HttpCookie cookie = Request.Cookies["UserDetails"];
            if (cookie != null)
            {
                nameTextBox.Text = cookie["Fname"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            using (BulmaDataClassesDataContext dbContext = new BulmaDataClassesDataContext())
            {
                Order newOrder = new Order();
                newOrder.meals = price.ToString();
                newOrder.date = DateTime.Now;

                HttpCookie cookie = Request.Cookies["UserDetails"];
                if (cookie != null)
                {
                    newOrder.CustomerId = Int32.Parse(cookie["userID"].ToString());
                }
                dbContext.Orders.InsertOnSubmit(newOrder);
                dbContext.SubmitChanges();
            }

            answer.Text = "Your cart is empty!";
            priceLabel.Text = "$0.00";
            Response.Redirect("Index.aspx");
        }
    }
}