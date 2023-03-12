using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Proiect_v2
{
    public static class ScoreCalculator
    {
        public static float CalculateScore(string leagueId, int points_t1,int points_t2,bool home,int firstQuarter_t1,int firstQuarter_t2,int secondQuarter_t1,int secondQuarter_t2, int thirdQuarter_t1, int thirdQuarter_t2, int fourthQuarter_t1, int fourthQuarter_t2)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root; database=proiectis; Password=root";

            con.Open();

            string getSV = "select scoreValue from league where leagueId=@leagueId";
            MySqlCommand cmd = new MySqlCommand(getSV, con);
            cmd.Parameters.AddWithValue("@leagueId", leagueId);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            float scoreValue = 1;

            if(dt.Rows.Count>0)
            {
                scoreValue = dt.Rows[0].Field<float>(0);
            }

            string getQV = "select quarterValue from league where leagueId=@leagueId";
            cmd = new MySqlCommand(getQV, con);
            cmd.Parameters.AddWithValue("@leagueId", leagueId);
            sda = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            float quarterValue = 2;

            if (dt.Rows.Count > 0)
            {
                quarterValue = dt.Rows[0].Field<float>(0);
            }

            con.Close();

            float score = 0;

            if (home)
            {
                score = (points_t1 - points_t2) * scoreValue;

                if (firstQuarter_t1 > firstQuarter_t2)
                    score += quarterValue;
                if (secondQuarter_t1 > secondQuarter_t2)
                    score += quarterValue;
                if (thirdQuarter_t1 > thirdQuarter_t2)
                    score += quarterValue;
                if (fourthQuarter_t1 > fourthQuarter_t2)
                    score += quarterValue;
            }
            else
            {
                score = (points_t2 - points_t1) * scoreValue;

                if (firstQuarter_t1 < firstQuarter_t2)
                    score += quarterValue;
                if (secondQuarter_t1 < secondQuarter_t2)
                    score += quarterValue;
                if (thirdQuarter_t1 < thirdQuarter_t2)
                    score += quarterValue;
                if (fourthQuarter_t1 < fourthQuarter_t2)
                    score += quarterValue;
            }
            return score;
        }
        public static void setQuarterValue(string leagueId, string quarterValue)
        {
            float newValue = float.Parse(quarterValue);

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root; database=proiectis; Password=root";

            con.Open();

            string setQV = "update league set quarterValue=@newValue where leagueId=@leagueId";
            MySqlCommand cmd = new MySqlCommand(setQV, con);
            cmd.Parameters.AddWithValue("@leagueId", leagueId);
            cmd.Parameters.AddWithValue("@newValue", newValue);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public static void setScoreValue(string leagueId, string scoreValue)
        {
            float newValue = float.Parse(scoreValue);

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root; database=proiectis; Password=root";

            con.Open();

            string setQV = "update league set scoreValue=@newValue where leagueId=@leagueId";
            MySqlCommand cmd = new MySqlCommand(setQV, con);
            cmd.Parameters.AddWithValue("@leagueId", leagueId);
            cmd.Parameters.AddWithValue("@newValue", newValue);
            cmd.ExecuteNonQuery();

            con.Close();
        }

    }
}