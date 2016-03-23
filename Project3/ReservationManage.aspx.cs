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
    public partial class ReservationManage : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();

        protected void Page_Load(object sender, EventArgs e)
        {
            string sqlStr = "SELECT * FROM Reservation";

            gvReservation.DataSource = objDB.GetDataSet(sqlStr);
            gvReservation.DataBind();
            
        }
    }
}