using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_v2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        float scoreValue = 1;
        float quarterValue = 2;

        string leagueId;
        MySqlConnection con = new MySqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["PreviousPage"] = Request.UrlReferrer;

            con.ConnectionString = "server=localhost;user id=root; database=proiectis; Password=root";

            leagueId = Request.QueryString["leagueId"].ToString();

            string getSV = "select scoreValue from league where leagueId=@leagueId";
            MySqlCommand cmd = new MySqlCommand(getSV, con);
            cmd.Parameters.AddWithValue("@leagueId", leagueId);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                scoreValue = dt.Rows[0].Field<float>(0);
            }

            //scoreTxtBox.Text = scoreValue.ToString();

            string getQV = "select quarterValue from league where leagueId=@leagueId";
            cmd = new MySqlCommand(getQV, con);
            cmd.Parameters.AddWithValue("@leagueId", leagueId);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                quarterValue = dt.Rows[0].Field<float>(0);
            }

            codeLabel.Text = leagueId;

            //quarterTxtBox.Text = quarterValue.ToString();
        }

        protected void ConfirmChanges_Click(object sender, ImageClickEventArgs e)
        {
            ScoreCalculator.setQuarterValue(leagueId, quarterTxtBox.Text == "" ? quarterValue.ToString() : quarterTxtBox.Text);
            ScoreCalculator.setScoreValue(leagueId, scoreTxtBox0.Text == "" ? scoreValue.ToString() : scoreTxtBox0.Text);
        }

        protected void Cancel_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["url"].ToString() != null)
            {
                Response.Redirect(Session["url"].ToString());
            }
        }
    }
}