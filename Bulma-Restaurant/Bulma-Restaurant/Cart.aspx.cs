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
                }
                else
                {
                    deliveryAmount.Text = "Delivery: FREE SHIPPING";
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

        }
    }
}