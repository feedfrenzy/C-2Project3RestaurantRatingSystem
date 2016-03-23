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
    public partial class Restaurant : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string strSQL = "SELECT * FROM Restaurant";
                gvRestaurant.DataSource = objDB.GetDataSet(strSQL);
                gvRestaurant.DataBind();
            }
        }

        protected void btnAddRest_Click(object sender, EventArgs e)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddRestaurant";
            SqlParameter inputParameter = new SqlParameter();


            if (String.IsNullOrEmpty(txtRestName.Text)==false)
            {
                inputParameter = new SqlParameter("@theRestName", txtRestName.Text);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand.Parameters.Add(inputParameter);

                if (String.IsNullOrEmpty(txtRestType.Text)==false)
                {
                    inputParameter = new SqlParameter("@theRestType", txtRestType.Text);
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    objCommand.Parameters.Add(inputParameter);

                    if (String.IsNullOrEmpty(txtRestDesc.Text) == false)
                    {
                        inputParameter = new SqlParameter("@theRestDesc", txtRestDesc.Text);
                        inputParameter.Direction = ParameterDirection.Input;
                        inputParameter.SqlDbType = SqlDbType.VarChar;
                        objCommand.Parameters.Add(inputParameter);

                        objDB.DoUpdateUsingCmdObj(objCommand);

                        string strSQL = "SELECT * FROM Restaurant";
                        gvRestaurant.DataSource = objDB.GetDataSet(strSQL);
                        gvRestaurant.DataBind();

                        lblShow.Text = "New Restaurant added!";
                        lblWarning.Text = "";
                    }
                    else
                    {
                        lblWarning.Text = "Restaurant description can not be empty!";
                    }
                }
                else
                {
                    lblWarning.Text = "Restaurant type can not be empty!";
                }
            }
            else
            {
                lblWarning.Text = "Restaurant name can not be empty!";
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnReview_Click(object sender, EventArgs e)
        {
            Response.Redirect("Review.aspx");
        }

        protected void btnReservation_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reservation.aspx");
        }
    }
}