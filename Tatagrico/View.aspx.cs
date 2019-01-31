using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
using System.IO;
namespace Tatagrico
{
    public partial class View : System.Web.UI.Page
    {
        OracleConnection oracleConnection;
        String tns = "Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=176.0.7.18)(PORT=1521))" + "(CONNECT_DATA=" + "(SERVER=dedicated)" + "(SERVICE_NAME=epatest)));" + "User ID=manoj;Password=manoj";
        protected void Page_Load(object sender, EventArgs e)
        {
            oracleConnection = new OracleConnection(tns);
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select * from T_AGRICO_APP";
            cmd.Connection = oracleConnection;
            oracleConnection.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Response.Write("<table border='1' class='table'>");
                Response.Write("<tr><th>REF_NO</th><th>NAME</th><th>CATEGORY</th><th>DT</th><th>STATUS</th><th>COMMENTS</th><th>ATTACHMENT</th></tr>");
                while (dr.Read())
                {
                    Response.Write("<tr>");
                    Response.Write("<td>" + dr["REF_NO"].ToString() + "</td>");
                    Response.Write("<td>" + dr["NAME"].ToString() + "</td>");
                    Response.Write("<td>" + dr["CATEGORY"].ToString() + "</td>");
                    Response.Write("<td>" + dr["DT"].ToString() + "</td>");
                    Response.Write("<td>" + dr["STATUS"].ToString() + "</td>");
                    Response.Write("<td>" + dr["COMMENTS"].ToString() + "</td>");
                    Response.Write("<td>" + dr["ATTACHMENT"].ToString() + "</td>");

                    Response.Write("</tr>");
                }
                Response.Write("</table>");
            }
            else
            {
                Response.Write("No Data In DataBase");
            }
            oracleConnection.Close();
        }
    }
}