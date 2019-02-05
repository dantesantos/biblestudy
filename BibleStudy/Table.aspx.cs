using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BibleStudy
{
    public partial class Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Connecting to the Database
            string connStr = "data source=DANTE-7DEP7VH;initial catalog=BibleContent;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            //Utilizing the command
            SqlCommand cmd = new SqlCommand("SELECT [Verse], [VerseContent] FROM [dbo].[VerseContent]");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            string temp = "";

            //reading data from DB
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp += reader["Verse"].ToString();
                temp += reader["VerseContent"].ToString();
                temp += "<br/>";
            }
            conn.Close();

            lbl_test.Text = temp;
        }
    }
}