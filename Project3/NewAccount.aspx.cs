using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Utilities;
using System.Data.SqlClient;
using System.Data;
using RestaurantClass;

namespace Project3
{
    public partial class NewAccount : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        SqlCommand objCommandNew = new SqlCommand();
        Account newAccount = new Account();
        
        
        string select;


        protected void Page_Load(object sender, EventArgs e)
        {
            //string strSQL = "SELECT * FROM Account";

            //ddlAccountType.DataSource = objDB.GetDataSet(strSQL);
            //ddlAccountType.DataTextField = "AccountType";
            //ddlAccountType.DataBind();

            select = ddlAccountType.SelectedValue.ToString();
        }


        protected void btnCreate_Click(object sender, EventArgs e)
        {
            int validation = newAccount.validation(txtUsername.Text,txtPassword.Text,select);


            if (validation == -1)
            {
                lblWarning.Text = "Username can not be empty!";
            }
            else if (validation == -2)
            {
                lblWarning.Text = "Password can not be empty!";
            }
            else if (validation == -3)
            {
                lblWarning.Text = "Type can not be empty!";
            }
            else
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "CheckDuplicateName";

                objCommand.Parameters.AddWithValue("@theName", txtUsername.Text);

                SqlParameter outPut = new SqlParameter("@theCount", 0);
                outPut.Direction = ParameterDirection.Output;
                objCommand.Parameters.Add(outPut);

                DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);


                int count = int.Parse(objCommand.Parameters["@theCount"].Value.ToString());  //problems here!!!

                if (count > 0)
                {
                    lblWarning.Text = "Duplicate username, please pick another one!";
                }
                else
                {
                    objCommandNew.CommandType = CommandType.StoredProcedure;
                    objCommandNew.CommandText = "CreateAccount";

                    //SqlParameter inputParameter = new SqlParameter("@theAccountID", int.Parse(txtAccountID.Text));
                    //inputParameter.Direction = ParameterDirection.Input;
                    //inputParameter.SqlDbType = SqlDbType.Int;
                    //objCommandNew.Parameters.Add(inputParameter);

                    SqlParameter inputParameter = new SqlParameter("@theUsername", txtUsername.Text);
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    objCommandNew.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@thePassword", txtPassword.Text);
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    objCommandNew.Parameters.Add(inputParameter);

                    inputParameter = new SqlParameter("@theAccountType", select);
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.VarChar;
                    objCommandNew.Parameters.Add(inputParameter);

                    objDB.DoUpdateUsingCmdObj(objCommandNew);


                    lblShow.Text = "Account Created!";
                }
            }

        }


    }

}