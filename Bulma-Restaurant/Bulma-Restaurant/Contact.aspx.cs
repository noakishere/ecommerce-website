using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bulma_Restaurant
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserDetails"];
            if (cookie != null)
            {
                nameTextBox.Text = cookie["Fname"];
            }
        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            using (BulmaDataClassesDataContext dbContext = new BulmaDataClassesDataContext())
            {
                Message newMessage = new Message
                {
                    name = nameTextBox.Text,
                    email = emailTextBox.Text,
                    phone = phoneTextBox.Text,
                    message1 = messageTextBox.Text
                };

                dbContext.Messages.InsertOnSubmit(newMessage);
                dbContext.SubmitChanges();

                nameTextBox.Text = "";
                emailTextBox.Text = "";
                phoneTextBox.Text = "";
                messageTextBox.Text = "";
                ResultLabel.Text = "Your message has been submitted !";
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            messageTextBox.Text = "";
        }
    }
}