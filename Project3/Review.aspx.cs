using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data.SqlClient;
using System.Data;

namespace Project3
{
    public partial class Review : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strSQL = "SELECT * FROM Restaurant";
                gvReviewRestaurant.DataSource = objDB.GetDataSet(strSQL);
                gvReviewRestaurant.DataBind();
                gvReviewRestaurant.Columns[4].Visible = false;
            }
        }

        protected void gvReviewRestaurant_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow selectedRow = gvReviewRestaurant.Rows[index];
            TableCell id = selectedRow.Cells[4];
            TableCell name = selectedRow.Cells[1];
            string reserveID = id.Text;
            string reserveName = name.Text;
            Session["Name"] = reserveName;
            Session["ID"] = reserveID;   

            if (e.CommandName == "Review")
            {
                Response.Redirect("ReviewDetail.aspx");
            }
            else if(e.CommandName =="ManageReview")
            {
                string type = Session["Type"].ToString();

                if (type == "Representative")
                {
                    lblShow.Text = "Only reviewer allows to manage the reviews.";
                }
                else
                {
                    Response.Redirect("ReviewManage.aspx");
                }

            }
            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Restaurant.aspx");
        }

    }
}