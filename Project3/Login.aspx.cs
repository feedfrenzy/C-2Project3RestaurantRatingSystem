using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Utilities;


namespace Project3
{
    public partial class Login : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand myCommand = new SqlCommand();
        SqlCommand objCommand = new SqlCommand();
        SqlCommand objCommand1 = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "retrieveAccount";

            myCommand.Parameters.AddWithValue("@theUserName", txtUsername.Text.Trim());
            myCommand.Parameters.AddWithValue("@thePassword", txtPassword.Text.Trim());

            SqlParameter outPut = new SqlParameter("@theCount", 0);
            outPut.Direction = ParameterDirection.Output;
            myCommand.Parameters.Add(outPut);

            DataSet ds = objDB.GetDataSetUsingCmdObj(myCommand);

            int count = int.Parse(myCommand.Parameters["@theCount"].Value.ToString());

            if (count == 1)
            {
                objCommand1.CommandType = CommandType.StoredProcedure;
                objCommand1.CommandText = "RestLogin";

                SqlParameter inputParameter = new SqlParameter("@userName", txtUsername.Text);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand1.Parameters.Add(inputParameter);


                inputParameter = new SqlParameter("@userPW", txtPassword.Text);
                inputParameter.Direction = ParameterDirection.Input;
                inputParameter.SqlDbType = SqlDbType.VarChar;
                objCommand1.Parameters.Add(inputParameter);

                DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand1);

                Session["Type"] = myDS.Tables[0].Rows[0]["AccountType"].ToString();
                Session["UserID"] = myDS.Tables[0].Rows[0]["AccountID"];

                lblShow.Text = Session["UserID"].ToString();
                Response.Redirect("Restaurant.aspx");

            }
            else
            {
                lblWarning.Text = "Incorrect username or password";
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewAccount.aspx");
        }
    }
}