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
    public partial class Sales : System.Web.UI.Page
    {
        OracleConnection oracleConnection;
        OracleCommand cmd;
        OracleDataReader dr;
        string y;
        private const string tns = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=176.0.7.18)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=epatest)));User ID=manoj;Password=manoj;Max Pool Size=1024";
          protected void Page_Load(object sender, EventArgs e)
        {
            oracleConnection = new OracleConnection(tns);
            cmd = new OracleCommand();
            cmd.CommandText = "select * from T_AGRICO_APP where STATUS='Pending'";
            cmd.Connection = oracleConnection;
            oracleConnection.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                /*Response.Write("<table border='1'>");
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
                    Response.Write("<td> <input type='button' id='Button4' value='Return'></td>");
                    Response.Write("<td> <input type='button' id='Button5' value='Reject'></td>");
                    Response.Write("</tr>");
                }
                Response.Write("</table>");*/
                Rows1();
            }
            else
            {
                Response.Write("No Data In DataBase");
            }
            oracleConnection.Close();
        }
        public void Rows1()
        {
            if (dr.Read())
            {
                y = dr["REF_NO"].ToString();
                Response.Write("<table border='1'>");
                Response.Write("<tr><th>REF_NO</th><td>" + y + " </td> </tr>");
                Response.Write("<tr><th>NAME</th><td>" + dr["NAME"].ToString() + " </td> </tr>");
                Response.Write("<tr><th>CATEGORY</th><td>" + dr["CATEGORY"].ToString() + " </td> </tr>");
                Response.Write("<tr><th>DT</th><td>" + dr["DT"].ToString() + " </td> </tr>");
                Response.Write("<tr><th>STATUS</th><td>" + dr["STATUS"].ToString() + " </td> </tr>");
                Response.Write("<tr><th>COMMENTS</th><td>" + dr["COMMENTS"].ToString() + " </td> </tr>");
                Response.Write("<tr><th>ATTACHMENT</th><td>" + dr["ATTACHMENT"].ToString() + " </td> </tr>");
                Sales_comment.Enabled = true;
                Response.Write("<tr><th><input type='button' id='Button4' value='Reject' onclick='Button4.Click'></th>" +
                    "<th><input type='button' id='Button5' value='Recommend' onclick='Button5.Click'></th></tr>");
                Response.Write("</table>");
            }
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            OracleCommand cm = new OracleCommand();
            cm.CommandText = "update T_AGRICO_APP set STATUS='Recommended' where REF_NO='" + y + "'";
            cm.Connection = oracleConnection;
            cm.ExecuteNonQuery();
            cm.CommandText = "update T_AGRICO_APP set COMSCOMMENT='" + Sales_comment.Text + "' where REF_NO='" + y + "'";
            cm.ExecuteNonQuery();
            Rows1();
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            OracleCommand cm = new OracleCommand();
            cm.CommandText = "update T_AGRICO_APP set STATUS='Rejected' where REF_NO='" + y + "'";
            cm.Connection = oracleConnection;
            cm.ExecuteNonQuery();
            cm.CommandText = "update T_AGRICO_APP set COMSCOMMENT='" + Sales_comment.Text + "' where REF_NO='" + y + "'";
            cm.ExecuteNonQuery();
            Rows1();
        }
    }
}