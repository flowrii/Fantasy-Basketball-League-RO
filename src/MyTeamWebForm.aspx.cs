using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_v2
{
    public partial class MyTeamWebForm : System.Web.UI.Page
    {
        string username = "";
        string leagueId = "";
        MySqlConnection con = new MySqlConnection();

        ResultJ r;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (editTextBox.Text == "Provide a new name")
            {
                editTextBox.Visible = true;
                saveNBtn.Visible = true;
                saveLBtn.Visible = false;
                editLogoBtn.Visible = false;
                editNameBtn.Visible = false;
            }
            else if (editTextBox.Text == "Provide a new logo url")
            {
                editTextBox.Visible = true;
                saveNBtn.Visible = false;
                saveLBtn.Visible = true;
                editLogoBtn.Visible = false;
                editNameBtn.Visible = false;
            }
            else
            {
                editTextBox.Visible = false;
                saveNBtn.Visible = false;
                saveLBtn.Visible = false;
                editLogoBtn.Visible = true;
                editNameBtn.Visible = true;
            }

            username = Request.QueryString["user"].ToString();

            con.ConnectionString = "server=localhost;user id=root; database=proiectis; Password=root";

            con.Open();

            string str = "select * from teamdata where userId=@user";
            MySqlCommand cmd = new MySqlCommand(str, con);
            cmd.Parameters.AddWithValue("@user", username);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                TeamNameLabel.Text = dt.Rows[0].Field<string>(1);
                Image1.ImageUrl = dt.Rows[0].Field<string>(2);
            }

            string strLeagueId = "select leagueId from leagueuser where userId=@user";
            cmd = new MySqlCommand(strLeagueId, con);
            cmd.Parameters.AddWithValue("@user", username);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                leagueId = dt.Rows[0].Field<string>(0);
            }

            string lastUpdate = "";
            string updateCheck = "select lastUpdate from league where leagueId=@leagueId";
            cmd = new MySqlCommand(updateCheck, con);
            cmd.Parameters.AddWithValue("@leagueId", leagueId);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
            {
                lastUpdate = dt.Rows[0].Field<string>(0);
            }
            if (lastUpdate != (DateTime.Now.Day).ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString())
            {
                getLastResults();
                string updateUpdate = "update league set lastUpdate=@today where leagueId=@leagueId";
                cmd = new MySqlCommand(updateUpdate, con);
                cmd.Parameters.AddWithValue("@today", DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString());
                cmd.Parameters.AddWithValue("leagueId", leagueId);
                cmd.ExecuteNonQuery();
            }

            string t1 = "select teamName as 'Team' from team join leagueuser on teamId=team1 where userId=@id";
            cmd = new MySqlCommand(t1, con);
            cmd.Parameters.AddWithValue("@id", username);
            sda = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);

            string t2 = "select teamName as 'Team' from team join leagueuser on teamId=team2 where userId=@id";
            cmd = new MySqlCommand(t2, con);
            cmd.Parameters.AddWithValue("@id", username);
            sda = new MySqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);

            string t3 = "select teamName as 'Team' from team join leagueuser on teamId=team3 where userId=@id";
            cmd = new MySqlCommand(t3, con);
            cmd.Parameters.AddWithValue("@id", username);
            sda = new MySqlDataAdapter(cmd);
            DataTable dt3 = new DataTable();
            sda.Fill(dt3);

            dt1.Merge(dt2);
            dt1.Merge(dt3);

            myTeamsGrid.DataSource = dt1;
            myTeamsGrid.DataBind();

            string clasament = "select teamData.teamName as 'Team', leagueUser.points as 'Points' from leagueuser join teamdata on leagueuser.userId=teamdata.userId where leagueId=@leagueId order by leagueuser.points desc";

            cmd = new MySqlCommand(clasament, con);
            cmd.Parameters.AddWithValue("@leagueId", leagueId);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            standingGrid.DataSource = dt;
            standingGrid.DataBind();

            string lastgame1 = "select team.teamName as 'Team', leagueuser.lastgame1 as 'Points' from team join leagueuser on teamId=team1 where userId=@id";
            cmd = new MySqlCommand(lastgame1, con);
            cmd.Parameters.AddWithValue("@id", username);
            sda = new MySqlDataAdapter(cmd);
            dt1 = new DataTable();
            sda.Fill(dt1);

            string lastgame2 = "select team.teamName as 'Team', leagueuser.lastgame2 as 'Points' from team join leagueuser on teamId=team2 where userId=@id";
            cmd = new MySqlCommand(lastgame2, con);
            cmd.Parameters.AddWithValue("@id", username);
            sda = new MySqlDataAdapter(cmd);
            dt2 = new DataTable();
            sda.Fill(dt2);

            string lastgame3 = "select team.teamName as 'Team', leagueuser.lastgame3 as 'Points' from team join leagueuser on teamId=team3 where userId=@id";
            cmd = new MySqlCommand(lastgame3, con);
            cmd.Parameters.AddWithValue("@id", username);
            sda = new MySqlDataAdapter(cmd);
            dt3 = new DataTable();
            sda.Fill(dt3);

            dt1.Merge(dt2);
            dt1.Merge(dt3);

            lastGameGrid.DataSource = dt1;
            lastGameGrid.DataBind();

            string checkAdmin = "select tip from ulogin where userId=@username";
            cmd = new MySqlCommand(checkAdmin, con);
            cmd.Parameters.AddWithValue("@username", username);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            settingsBtn.Visible = false;
            int tip = 0;

            if(dt.Rows.Count>0)
            {
                tip = dt.Rows[0].Field<int>(0);
            }
            if(tip==1)
            {
                settingsBtn.Visible = true;
            }

            con.Close();
        }

        public void getLastResults()
        {
            var TextRes = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Results.json");
            r = JsonConvert.DeserializeObject<ResultJ>(TextRes);

            if (r.Count != 0)
            {
                Iterator iterator = r.CreateIterator();
                iterator.Step = 1;

                for (Result item = iterator.First(); !iterator.IsDone; item = iterator.Next())
                {

                    Home hinfo = item.teams.home;
                    Away ainfo = item.teams.away;

                    if (item.scores.home.quarter_1 != null)
                    {
                        Home1 h = item.scores.home;
                        Away1 a = item.scores.away;

                        float scoreH = ScoreCalculator.CalculateScore(leagueId, h.total, a.total, h is Home1, h.quarter_1, a.quarter_1, h.quarter_2, a.quarter_2, h.quarter_3, a.quarter_3, h.quarter_4, a.quarter_4);
                        float scoreA = ScoreCalculator.CalculateScore(leagueId, h.total, a.total, a is Home1, h.quarter_1, a.quarter_1, h.quarter_2, a.quarter_2, h.quarter_3, a.quarter_3, h.quarter_4, a.quarter_4);

                        string plusH = scoreH >= 0 ? "+" : "-";
                        string plusA = scoreA >= 0 ? "+" : "-";

                        string updateH1 = "update leagueuser set lastgame1=@scoreH, points=points" + plusH + "@scoreH2 where leagueId=@leagueId and team1=@hid";
                        MySqlCommand cmd = new MySqlCommand(updateH1, con);
                        cmd.Parameters.AddWithValue("@scoreH", scoreH);
                        cmd.Parameters.AddWithValue("@leagueId", leagueId);
                        cmd.Parameters.AddWithValue("@hid", hinfo.id);
                        cmd.Parameters.AddWithValue("@scoreH2", Math.Abs(scoreH));
                        cmd.ExecuteNonQuery();

                        string updateH2 = "update leagueuser set lastgame2=@scoreH, points=points" + plusH + "@scoreH2 where leagueId=@leagueId and team2=@hid";
                        cmd = new MySqlCommand(updateH2, con);
                        cmd.Parameters.AddWithValue("@scoreH", scoreH);
                        cmd.Parameters.AddWithValue("@leagueId", leagueId);
                        cmd.Parameters.AddWithValue("@hid", hinfo.id);
                        cmd.Parameters.AddWithValue("@scoreH2", Math.Abs(scoreH));
                        cmd.ExecuteNonQuery();

                        string updateH3 = "update leagueuser set lastgame3=@scoreH, points=points" + plusH + "@scoreH2 where leagueId=@leagueId and team3=@hid";
                        cmd = new MySqlCommand(updateH3, con);
                        cmd.Parameters.AddWithValue("@scoreH", scoreH);
                        cmd.Parameters.AddWithValue("@leagueId", leagueId);
                        cmd.Parameters.AddWithValue("@hid", hinfo.id);
                        cmd.Parameters.AddWithValue("@scoreH2", Math.Abs(scoreH));
                        cmd.ExecuteNonQuery();

                        string updateA1 = "update leagueuser set lastgame1=@scoreA, points=points" + plusA + "@scoreA2 where leagueId=@leagueId and team1=@aid";
                        cmd = new MySqlCommand(updateA1, con);
                        cmd.Parameters.AddWithValue("@scoreA", scoreA);
                        cmd.Parameters.AddWithValue("@leagueId", leagueId);
                        cmd.Parameters.AddWithValue("@aid", ainfo.id);
                        cmd.Parameters.AddWithValue("@scoreA2", Math.Abs(scoreA));
                        cmd.ExecuteNonQuery();

                        string updateA2 = "update leagueuser set lastgame2=@scoreA, points=points" + plusA + "@scoreA2 where leagueId=@leagueId and team2=@aid";
                        cmd = new MySqlCommand(updateA2, con);
                        cmd.Parameters.AddWithValue("@scoreA", scoreA);
                        cmd.Parameters.AddWithValue("@leagueId", leagueId);
                        cmd.Parameters.AddWithValue("@aid", ainfo.id);
                        cmd.Parameters.AddWithValue("@scoreA2", Math.Abs(scoreA));
                        cmd.ExecuteNonQuery();

                        string updateA3 = "update leagueuser set lastgame3=@scoreA, points=points" + plusA + "@scoreA2 where leagueId=@leagueId and team3=@aid";
                        cmd = new MySqlCommand(updateA3, con);
                        cmd.Parameters.AddWithValue("@scoreA", scoreA);
                        cmd.Parameters.AddWithValue("@leagueId", leagueId);
                        cmd.Parameters.AddWithValue("@aid", ainfo.id);
                        cmd.Parameters.AddWithValue("@scoreA2", Math.Abs(scoreA));
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        protected void editNameBtn_Click(object sender, ImageClickEventArgs e)
        {
            editNameBtn.Visible = true;
            editTextBox.Visible = true;
            editLogoBtn.Visible = false;
            saveNBtn.Visible = true;
        }

        protected void saveNBtn_Click(object sender, ImageClickEventArgs e)
        {
            string newValue = editTextBox.Text;
            if (newValue == "")
            {
                editTextBox.Text = "Provide a new name";
            }
            else
            {
                con.Open();

                string updateQry = "update teamdata set teamName=@newName where userId=@username";
                MySqlCommand cmd = new MySqlCommand(updateQry, con);
                cmd.Parameters.AddWithValue("@newName", newValue);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();

                con.Close();

                Response.Redirect(Request.RawUrl);
            }
        }

        protected void editLogoBtn_Click(object sender, ImageClickEventArgs e)
        {
            editLogoBtn.Visible = true;
            editTextBox.Visible = true;
            editNameBtn.Visible = false;
            saveLBtn.Visible = true;
        }

        protected void saveLBtn_Click(object sender, ImageClickEventArgs e)
        {
            string newValue = editTextBox.Text;
            if (newValue == "")
            {
                editTextBox.Text = "Provide a new logo url";
            }
            else
            {
                con.Open();

                string updateQry = "update teamdata set logo=@newLogo where userId=@username";
                MySqlCommand cmd = new MySqlCommand(updateQry, con);
                cmd.Parameters.AddWithValue("@newLogo", newValue);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.ExecuteNonQuery();

                con.Close();

                Response.Redirect(Request.RawUrl);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Session["url"] = Request.UrlReferrer.AbsoluteUri.ToString();
            string url = "AdminSettingsForm.aspx?leagueId=" +
                        leagueId;
            Response.Redirect(url);
        }
    }
}
