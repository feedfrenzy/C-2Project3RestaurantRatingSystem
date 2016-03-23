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
    public partial class Reservation : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strSQL = "SELECT * FROM Restaurant";
                gvReservation.DataSource = objDB.GetDataSet(strSQL);
                gvReservation.DataBind();
                gvReservation.Columns[4].Visible = false;
            }
        }

        protected void gvReservation_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Reservation")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = gvReservation.Rows[index];
                TableCell id = selectedRow.Cells[4];
                TableCell name = selectedRow.Cells[1];
                string reviewID = id.Text;
                string reviewName = name.Text;

                Session["Name"] = reviewName;
                Session["ID"] = reviewID;

                Response.Redirect("ReservationDetail.aspx");
            }
            else if (e.CommandName == "ManageReservation")
            {
                Response.Redirect("ReservationManage.aspx");
            }

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Restaurant.aspx");
        }

    }
}