using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace StarRating
{
    public partial class GetRating : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Rating"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select AVG(ALL RValue)AS RVal from Rating";
            con.Open();
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader rd = com.ExecuteReader();
            string value="";
            while(rd.Read())
            {
                value = rd["RVal"].ToString();
            }
            Label1.Text = value;
        }
    }
}