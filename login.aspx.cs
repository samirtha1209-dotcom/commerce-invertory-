using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace commerce_inventaroy
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtpassword.Text;
            string role = txtRollno.Text;
            if (username == "admin" && password == "1234" && role == "Admin")
            { 
                Response.Redirect("Dashbord.aspx");
            }
            else
            { 
                Response.Write("<script>alert('Invalid Login Details');</script>");
            }
        }
    }
    }
