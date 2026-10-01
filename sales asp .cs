using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace commerce_inventaroy
{
    public partial class sales : System.Web.UI.Page
    {
        static DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt.Columns.Add("Sale ID");
                dt.Columns.Add("Product ID");
                dt.Columns.Add("Quantity");
                dt.Columns.Add("Total Amount");
            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            row["Sale ID"] = txtsalesid.Text;
            row["Product ID"] = txtproductid.Text;
            row["Quantity"] = txtquantity.Text;
            row["Total Amount"] = txtamount.Text;

            dt.Rows.Add(row);

            Response.Write("<script>alert('Sale Added Successfully');</script>");
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row["Sale ID"].ToString() == txtsalesid.Text)
                {
                    row["Product ID"] = txtproductid.Text;
                    row["Quantity"] = txtquantity.Text;
                    row["Total Amount"] = txtamount.Text;

                    Response.Write("<script>alert('Sale Updated Successfully');</script>");
                    return;
                }
            }

        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
           foreach(DataRow row in dt.Rows)
            {
                if (row["Sale ID"].ToString() == txtsalesid.Text)
                {
                    txtproductid.Text = row["Product ID"].ToString();
                    txtquantity.Text = row["Quantity"].ToString();
                    txtamount.Text = row["Total Amount"].ToString();

                    Response.Write("<script>alert('Sale Found');</script>");
                    return;
                }
            }

            Response.Write("<script>alert('Sale Not Found');</script>");
        }
    }
    }