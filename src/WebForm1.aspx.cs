using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;
using System.Data;
using Newtonsoft.Json;

namespace Proiect_v2
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		MySqlConnection con = new MySqlConnection();
		string username = "";
		TeamsJ t;
		ResultJ r;
		protected void Page_Load(object sender, EventArgs e)
		{
			//getTeamsAsync();
			var Text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Teams.json");
			var TextRes = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Results.json");
			t = JsonConvert.DeserializeObject<TeamsJ>(Text);
			r = JsonConvert.DeserializeObject<ResultJ>(TextRes);
			con.ConnectionString = "server=localhost;user id=root; database=proiectis; Password=root";
			
			codeTxtBox.Visible = false;
			joinBtn.Visible = false;
			username = Request.QueryString["name"].ToString();
			/*Home1 h= r.response.ElementAt(0).scores.home;
			Away1 a = r.response.ElementAt(0).scores.away;
			
			///aici se pun parametri pt calcul, o sa se poata schimba din setari
			ScoreCalculator.setScorePercentage("1");
			ScoreCalculator.setQuarterValue("5");
			
			
			///Asa e un call pt home
			Label1.Text = ScoreCalculator.CalculateScore(h.total, a.total, h is Home1, h.quarter_1, a.quarter_1, h.quarter_2, a.quarter_2, h.quarter_3, a.quarter_3, h.quarter_4, a.quarter_4).ToString();
			
			///Asa e un call pt away
			Label1.Text = ScoreCalculator.CalculateScore(h.total, a.total, a is Home1, h.quarter_1, a.quarter_1, h.quarter_2, a.quarter_2, h.quarter_3, a.quarter_3, h.quarter_4, a.quarter_4).ToString();
			*/
			//insertTeams();
		}

		public void insertTeams()
		{
			con.Open();

			string insertC = "INSERT into country values (@countryID, @cname, @code, @flag)";
			MySqlCommand cmd = new MySqlCommand(insertC, con);
			cmd.Parameters.AddWithValue("@countryID", t.response[0].country.id);
			cmd.Parameters.AddWithValue("@cname", t.response[0].country.name);
			cmd.Parameters.AddWithValue("@code", t.response[0].country.code);
			cmd.Parameters.AddWithValue("@flag", t.response[0].country.flag);
			cmd.ExecuteNonQuery();

			for (int i = 0; i <= 17; i++)
			{
				string insertT = "INSERT into team values (@teamID, @tname, @tlogo, @national, @countryID)";
				cmd = new MySqlCommand(insertT, con);
				cmd.Parameters.AddWithValue("@teamID", t.response[i].id);
				cmd.Parameters.AddWithValue("@tname", t.response[i].name);
				cmd.Parameters.AddWithValue("@tlogo", t.response[i].logo);
				cmd.Parameters.AddWithValue("@national", t.response[i].nationnal);
				cmd.Parameters.AddWithValue("countryID", t.response[i].country.id);
				cmd.ExecuteNonQuery();
			}
		}

		public async Task getTeamsAsync()
		{
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://api-basketball.p.rapidapi.com/teams?league=78&season=2022-2023"),
				Headers =
				{
					{ "X-RapidAPI-Key", "1295e40a64msh79c3e4b8cd8c1acp1ed540jsna4d77944806d" },
					{ "X-RapidAPI-Host", "api-basketball.p.rapidapi.com" },
				},
			};
			var response = client.SendAsync(request).Result;
			//response.EnsureSuccessStatusCode();
			var body = response.Content.ReadAsStringAsync();
		}

		public static void showTeams()
		{

		}

		protected void joinLeagueBtn_Click(object sender, EventArgs e)
		{
			Label1.Visible = false;
			codeTxtBox.Visible = true;
			joinBtn.Visible = true;
		}

		protected void joinBtn_Click(object sender, EventArgs e)
		{
			con.Open();

			string leagueId = codeTxtBox.Text;

			MySqlCommand cmd = new MySqlCommand("select * from league where leagueId=@id", con);

			cmd.Parameters.AddWithValue("@id", leagueId);
			cmd.ExecuteNonQuery();
			MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);
		
			if (dt.Rows.Count > 0)
			{
				cmd = new MySqlCommand("select * from leagueuser where userId=@id", con);
				cmd.Parameters.AddWithValue("@id", username);
				cmd.ExecuteNonQuery();

				sda = new MySqlDataAdapter(cmd);
				DataTable dt2 = new DataTable();
				sda.Fill(dt2);

				if (dt2.Rows.Count > 0)
				{
					Label1.Visible = true;
					Label1.Text = "You already belong to a league!";
				}
				else
				{
					string url;
					url = "TeamWebForm.aspx?name=" +
						codeTxtBox.Text + "&user=" +
						username + "&leagueId=" +
						leagueId;
					Response.Redirect(url);
				}
			}
			else
			{
				Label1.Visible = true;
				Label1.Text = "Code league does not exists!";
			}

			con.Close();
		}

		protected void createLeagueBtn_Click(object sender, EventArgs e)
		{
			con.Open();

			MySqlCommand cmd = new MySqlCommand("select * from leagueuser where userId=@id", con);
			cmd.Parameters.AddWithValue("@id", username);
			cmd.ExecuteNonQuery();

			MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			
			if (dt.Rows.Count > 0)
			{
				Label1.Visible = true;
				Label1.Text = "You already have a team!";
			}
			else
			{
				string url;
				url = "TeamWebForm.aspx?name=" +
					"create" + "&user=" +
					username;
				Response.Redirect(url);
			}

			con.Close();
		}

		protected void myTeamBtn_Click(object sender, EventArgs e)
		{
			con.Open();

			MySqlCommand cmd = new MySqlCommand("select * from leagueuser where userId=@id", con);
			cmd.Parameters.AddWithValue("@id", username);
			cmd.ExecuteNonQuery();

			MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			
			if (dt.Rows.Count > 0)
			{
				string url;
				url = "MyTeamWebForm.aspx?user=" +
					username;
				Response.Redirect(url);
			}
			else
			{
				Label1.Text = "You don't have a team! Join a league or create one in order to have a team.";
				Label1.ForeColor = System.Drawing.Color.Red;
			}
			con.Close();
		}
    }
}