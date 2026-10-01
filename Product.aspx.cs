using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace commerce_inventaroy
{
    public partial class Product : System.Web.UI.Page
    {
        static DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt.Columns.Add("Product ID");
                dt.Columns.Add("Product Name");
                dt.Columns.Add("Category");
                dt.Columns.Add("Price");
                dt.Columns.Add("Quantity");
            }

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            row["Product ID"] = txtproductid.Text;
            row["Product Name"] = txtproductname.Text;
            row["Category"] = txtcategory.Text;
            row["Price"] = txtprice.Text;
            row["Quantity"] = txtquantity.Text;


            dt.Rows.Add(row);

            Response.Write("<script>alert('Product Added Successfully');</script>");
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row["Product ID"].ToString() == txtproductid.Text)
                {
                    row["Product Name"] = txtproductname.Text;
                    row["Category"] = txtcategory.Text;
                    row["Price"] = txtprice.Text;
                    row["Quantity"] = txtquantity.Text;

                    Response.Write("<script>alert('Product Updated Successfully');</script>");
                    return;
                }
            }
            Response.Write("<script>alert('Product Not Found');</script>");


        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Select(
               "Product ID = '" + txtproductid.Text + "'"))
            {
                dt.Rows.Remove(row);
                Response.Write("<script>alert('Product Deleted Successfully');</script>");
                return;
            }

            Response.Write("<script>alert('Product Not Found');</script>");
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row["Product ID"].ToString() == txtproductid.Text)
                {
                    txtproductname.Text = row["Product Name"].ToString();
                    txtcategory.Text = row["Category"].ToString();
                    txtprice.Text = row["Price"].ToString();
                    txtquantity.Text = row["Quantity"].ToString();

                    Response.Write("<script>alert('Product Found');</script>");
                    return;
                }
            }

            Response.Write("<script>alert('Product Not Found');</script>");
        }
    }
}
 