using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_v2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection();

        string op = "";
        string username = "";
        string leagueId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            createBtn.Visible = false;
            joinBtn.Visible = false;
            op = Request.QueryString["name"].ToString();
            username = Request.QueryString["user"].ToString();
            if (op == "create")
                createBtn.Visible = true;
            else
            {
                leagueId = Request.QueryString["leagueId"].ToString();
                joinBtn.Visible = true;
            }

            con.ConnectionString = "server=localhost;user id=root; database=proiectis; Password=root";

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string teamName = nameTextBox.Text;
            string logoLink = linkTextBox.Text;

            int team1 = Int32.Parse(RadioButtonList1.SelectedValue);
            int team2 = Int32.Parse(RadioButtonList2.SelectedValue);
            int team3 = Int32.Parse(RadioButtonList3.SelectedValue);

            con.Open();

            MySqlCommand cmd;

            if (op == "create")
            {
                Random r = new Random();
                leagueId = r.Next(10000000, 100000000).ToString();

                string insertInLeague = "INSERT into league values (@leagueId, @userId, 1, 2, @data)";
                cmd = new MySqlCommand(insertInLeague, con);
                cmd.Parameters.AddWithValue("@leagueId", leagueId);
                cmd.Parameters.AddWithValue("@userId", username);
                cmd.Parameters.AddWithValue("@data", (DateTime.Now.Day - 1).ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString());
                cmd.ExecuteNonQuery();

                string updateManager = "UPDATE ulogin set tip=1 where userId=@userId";
                cmd = new MySqlCommand(updateManager, con);
                cmd.Parameters.AddWithValue("@userId", username);
                cmd.ExecuteNonQuery();


            }

            string insertInLUser = "INSERT into leagueuser values (@userId, @t1, @t2, @t3, 0, 0, 0, 0, @leagueId)";
            cmd = new MySqlCommand(insertInLUser, con);
            cmd.Parameters.AddWithValue("@userId", username);
            cmd.Parameters.AddWithValue("@t1", team1);
            cmd.Parameters.AddWithValue("@t2", team2);
            cmd.Parameters.AddWithValue("@t3", team3);
            cmd.Parameters.AddWithValue("@leagueId", leagueId);
            cmd.ExecuteNonQuery();

            string insertInTData = "INSERT into teamdata values (@userId, @tname, @logo)";
            cmd = new MySqlCommand(insertInTData, con);
            cmd.Parameters.AddWithValue("@userId", username);
            cmd.Parameters.AddWithValue("@tname", teamName);
            cmd.Parameters.AddWithValue("@logo", logoLink);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            string teamName = nameTextBox.Text;
            string logoLink = linkTextBox.Text;

            int team1 = Int32.Parse(RadioButtonList1.SelectedValue);
            int team2 = Int32.Parse(RadioButtonList2.SelectedValue);
            int team3 = Int32.Parse(RadioButtonList3.SelectedValue);

            con.Open();

            MySqlCommand cmd;

            string insertInLUser = "INSERT into leagueuser values (@userId, @t1, @t2, @t3, 0, 0, 0, 0, @leagueId)";
            cmd = new MySqlCommand(insertInLUser, con);
            cmd.Parameters.AddWithValue("@userId", username);
            cmd.Parameters.AddWithValue("@t1", team1);
            cmd.Parameters.AddWithValue("@t2", team2);
            cmd.Parameters.AddWithValue("@t3", team3);
            cmd.Parameters.AddWithValue("@leagueId", leagueId);
            cmd.ExecuteNonQuery();

            string insertInTData = "INSERT into teamdata values (@userId, @tname, @logo)";
            cmd = new MySqlCommand(insertInTData, con);
            cmd.Parameters.AddWithValue("@userId", username);
            cmd.Parameters.AddWithValue("@tname", teamName);
            cmd.Parameters.AddWithValue("@logo", logoLink);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}