﻿using System;
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
            if (Session["val"] != null)
            {
                answer.Text = Session["val"].ToString();
                Session.Remove("val");
            }
            else
            {
                answer.Text = "Your cart is empty!";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}