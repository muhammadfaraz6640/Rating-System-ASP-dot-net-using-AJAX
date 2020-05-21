using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarRating
{
    public partial class Rating : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Rating"].ToString());                               
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string query = "insert into Rating values('" + Rating1.CurrentRating.ToString() + "')";
            con.Open();
            SqlCommand com = new SqlCommand(query, con);            
            com.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Succssfully inserted')</script>");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string query = "insert into Rating values('" + Rating1.CurrentRating.ToString() + "')";
            con.Open();
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Succssfully inserted')</script>");
        }
    }
}