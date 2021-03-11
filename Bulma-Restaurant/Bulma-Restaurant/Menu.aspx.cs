using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Bulma_Restaurant
{
    public partial class Menu : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["val"] != null
                    && Session["val"].ToString() != "")
                {
                    Label1.Text = Session["val"].ToString();
                }

                else
                {
                    Label1.Text = Request.QueryString["id"];
                }

                if (Session["price"] != null)
                {
                    Label2.Text = Session["price"].ToString();
                }
            }

            PopulateMenu();
        }

        public void addToCartButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            BulmaDataClassesDataContext context = new BulmaDataClassesDataContext();


            var customer = from c in context.Meals
                           where c.Id == Int32.Parse(button.ID)
                           select c;

            if (customer.Any())
            {
                Meal c1 = customer.First();
                
                //orders.Add(c1);

                string newOrder = "<br />Product Name: " + c1.name
                                  + "<br />Product Price: $" + c1.price
                                  + "<br />---------------------";

                Label1.Text += newOrder;

                double price = Double.Parse(Label2.Text);
                price += Double.Parse(c1.price);

                Label2.Text = price.ToString();
            }
        }

        public void PopulateMenu()
        {
            BulmaDataClassesDataContext context = new BulmaDataClassesDataContext();

            List<Meal> products = context.Meals.ToList();
            HtmlTable table = new HtmlTable();
            table.Attributes.Add("class", "table table-hover");

            foreach (Meal c in products)
            {
                HtmlTableRow tr1 = new HtmlTableRow();
                tr1.Style.Add("border", "1px solid black"); tr1.Style.Add("padding", "5px");

                HtmlTableCell tr1_tc1 = new HtmlTableCell();
                tr1_tc1.Controls.Add(new LiteralControl(c.name));
                tr1_tc1.Style.Add("font-weight", "bold");

                HtmlTableCell tr1_tc2 = new HtmlTableCell();
                tr1_tc2.Controls.Add(new LiteralControl(c.description));

                HtmlTableCell tr1_tc3 = new HtmlTableCell();
                tr1_tc3.Controls.Add(new LiteralControl("<img width=\"250px\" height=\"150px\" src=\"" + c.image + "\" />"));

                HtmlTableCell tr1_tc4 = new HtmlTableCell();
                tr1_tc4.Controls.Add(new LiteralControl("$" + c.price));

                Button button = new Button
                {
                    ID = c.Id.ToString(),
                    CommandArgument = c.Id.ToString(),
                    Text = "Add to cart"
                };
                button.Attributes.Add("runat", "server");
                button.Attributes.Add("class", "btn btn-success");
                button.Click += new EventHandler(this.addToCartButton_Click);

                HtmlTableCell tr1_tc5 = new HtmlTableCell();
                tr1_tc5.Controls.Add(button);

                tr1.Controls.Add(tr1_tc1);
                tr1.Controls.Add(tr1_tc2);
                tr1.Controls.Add(tr1_tc3);
                tr1.Controls.Add(tr1_tc4);
                tr1.Controls.Add(tr1_tc5);

                table.Controls.Add(tr1);
                table.Attributes.Add("align", "center"); table.Style.Add("padding", "20px"); table.Style.Add("border-collapse", "collapse"); table.Attributes.Add("border", "1px solid black");
            }

            Panel1.Controls.Add(table);

            context.SubmitChanges();
        }

        protected void cartButton_Click(object sender, EventArgs e)
        {
            Session["val"] = Label1.Text;
            Session["price"] = Label2.Text;
            Server.Transfer("Cart.aspx");
        }
    }
}