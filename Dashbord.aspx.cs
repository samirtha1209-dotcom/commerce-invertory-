using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace commerce_inventaroy
{
    public partial class Dashbord : System.Web.UI.Page
    {
        protected void btnproduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        }

        protected void btnstock_Click(object sender, EventArgs e)
        {
            Response.Redirect("Stock.aspx");
        }

        protected void btnsales_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sales.aspx");
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
    }
    
