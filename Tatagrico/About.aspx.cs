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
    public partial class About : Page
    {
         String tns= "Data Source=(DESCRIPTION="+"(ADDRESS=(PROTOCOL=TCP)(HOST=176.0.7.18)(PORT=1521))"+"(CONNECT_DATA="+"(SERVER=dedicated)"+"(SERVICE_NAME=epatest)));"+"User ID=manoj;Password=manoj";
        private OracleConnection Con;
        byte[] bytes;
       

        protected void Page_Load(object sender, EventArgs e)
        {
            /*Con = new OracleConnection(tns);
            Con.Open();
            Response.Write("Connected to Oracle " + Con.ServerVersion);
            Con.Close();
            Con.Dispose();

            Response.Write(" Disconnected");*/
        }
        

        protected void Button1_Click1(object sender, EventArgs e)
        {
             try
             {
                 string sql = "Insert into T_AGRICO_APP(REF_NO,NAME,CATEGORY,DT,STATUS,COMMENTS,ATTACHMENT,FILENAME,ContentType,SALECOMMENT,COMSCOMMENT)";
                 sql = sql + "VALUES(:REF_NO,:NAME,:CATEGORY,:DT,:STATUS,:COMMENTS,:ATTACHMENT,:FILENAME,:ContentType,:SALECOMMENT,:COMSCOMMENT)";
                 Con = new OracleConnection(tns);
                 OracleCommand cmd = new OracleCommand();
                 cmd.CommandText = sql;
                cmd.Connection = Con;
                 string filename = Path.GetFileName(attachment.PostedFile.FileName);
                 string contentType = attachment.PostedFile.ContentType;
                 using (Stream fs = attachment.PostedFile.InputStream)
                 {
                     using (BinaryReader br = new BinaryReader(fs))
                     {
                         bytes = br.ReadBytes((Int32)fs.Length);
                        cmd.Parameters.AddWithValue(":ATTACHMENT", bytes);
                        cmd.Parameters.AddWithValue(":FILENAME", filename);
                        cmd.Parameters.AddWithValue(":ContentType", contentType);

                    }
                }
                cmd.Parameters.AddWithValue(":REF_NO", re.Text.Trim());
                cmd.Parameters.AddWithValue(":NAME", Name1.Text.Trim());
                cmd.Parameters.AddWithValue(":DT", System.DateTime.Now);
                cmd.Parameters.AddWithValue(":STATUS", "Pending");
                cmd.Parameters.AddWithValue(":COMMENTS", Comment1.Text.Trim());
               cmd.Parameters.AddWithValue(":SALECOMMENT", "");
                cmd.Parameters.AddWithValue(":COMSCOMMENT", "");
                Con.Open();
                int k = cmd.ExecuteNonQuery();
                if (k != 0)
                {

                    re.Text = "";
                    Name1.Text = "";
                    Comment1.Text = "";

                }
                Con.Close();
                Con.Dispose();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
             catch(Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 
             }
        }
    }
    
}