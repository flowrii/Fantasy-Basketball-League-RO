using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Proiect_v2
{
    public partial class LoginWebForm : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection();

        ResultJ r;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "server=localhost;user id=root; database=proiectIS; Password=root";

            con.Open();

            string lastUpdate = "";
            string updateCheck = "select lastUpdate from lastGameDay";
            MySqlCommand cmd = new MySqlCommand(updateCheck, con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                lastUpdate = dt.Rows[0].Field<string>(0);
            }

            if (lastUpdate != (DateTime.Now.Day).ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString())
            {
                getLastDayResults();
                string up = "update lastGameDay set lastUpdate=@lu";
                cmd = new MySqlCommand(up, con);
                cmd.Parameters.AddWithValue("lu", DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString());
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        public async Task getLastDayResults()
        {
            string month = (DateTime.Now.Month >= 10) ? DateTime.Now.Month.ToString() : ("0" + DateTime.Now.Month.ToString());
            string day = (DateTime.Now.Day-1 >= 10) ? (DateTime.Now.Day-1).ToString() : ("0" + (DateTime.Now.Day-1).ToString());
            string url = "https://api-basketball.p.rapidapi.com/games?season=2022-2023&league=78&date=" +
                DateTime.Now.Year.ToString() + "-" +
                month + "-" +
                day;

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
                {
                    { "X-RapidAPI-Key", "1295e40a64msh79c3e4b8cd8c1acp1ed540jsna4d77944806d" },
                    { "X-RapidAPI-Host", "api-basketball.p.rapidapi.com" },
                },
            };
            var response = client.SendAsync(request).Result;
            var body = response.Content.ReadAsStringAsync();
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Results.json", body.Result.ToString());
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from ulogin where userId=@username and password=@password", con);

            cmd.Parameters.AddWithValue("@username", userTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passTextBox.Text);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            cmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                string url;
                url = "WebForm1.aspx?name=" +
                    userTextBox.Text;
                Response.Redirect(url);
            }
            else
            {
                Label1.Text = "incorrect usarname or passowrd";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            //TeamDao.findById(0, con,userTextBox);
            con.Close();
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root; database=proiectIS; Password=root";

            con.Open();

            MySqlCommand cmd = new MySqlCommand("Select * from Ulogin where userId= @Username", con);
            cmd.Parameters.AddWithValue("@Username", this.userTextBox.Text);
            
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();

            if (userTextBox.Text.Equals("") || passTextBox.Text.Equals(""))
            {
                Label2.Text = "Write a username and a password in the above textboxes";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
            else if (dt.Rows.Count > 0)
            {
                Label2.Text = "Username already exists!";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                string sqlCmd = "call creare_utilizator('" + userTextBox.Text + "', '" + passTextBox.Text + "', '" + 0 + "');";

                cmd = new MySqlCommand(sqlCmd, con);
                cmd.ExecuteNonQuery();

                Label2.Text = "Account created successfully!";
                Label2.ForeColor = System.Drawing.Color.Green;
            }

            con.Close();
        }
    }
}