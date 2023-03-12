using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Proiect_v2
{
    public class TeamDao
    {
        private static String findStatementString = "SELECT * FROM Team where teamID=@teamid";
        private static String findStatementString2 = "SELECT * FROM Country where countryID=@countryID";

        public static Team findById(int TeamID, MySqlConnection connection)
        {
            Team toReturn = new Team();
            Country country = new Country();
            int countryID=0;

            MySqlCommand find = new MySqlCommand(findStatementString, connection);
            find.Parameters.AddWithValue("@teamid", TeamID);
            MySqlDataReader reader = find.ExecuteReader();
            while (reader.Read())
            {
                toReturn.name = reader.GetString(1);
                toReturn.logo = reader.GetString(2);
                toReturn.nationnal = reader.GetBoolean(3);
                countryID = reader.GetInt32(4);
            }
            
            find = new MySqlCommand(findStatementString2, connection);
            find.Parameters.AddWithValue("countryID", countryID);
            reader = find.ExecuteReader();
            while (reader.Read())
            {
                country.id = reader.GetInt32(0);
                country.name = reader.GetString(1);
                country.code = reader.GetString(2);
                country.flag = reader.GetString(3);
            }

            toReturn.country = country;

            return toReturn;
        }

        private static String insertTeamString = "INSERT into Team values (@id, '@name', '@logo', '@national', @countryId)";
        private static String insertCountryString = "INSERT into Country values (@countryId, '@name', '@code', '@flag')";
        public static void insertTeam(Team team, MySqlConnection connection)
        {
            MySqlCommand insert = new MySqlCommand(insertCountryString, connection);
            insert.Parameters.AddWithValue("@countryId", team.country.id);
            insert.Parameters.AddWithValue("@name", team.country.name);
            insert.Parameters.AddWithValue("@code", team.country.code);
            insert.Parameters.AddWithValue("@flag", team.country.flag);

            insert.ExecuteNonQuery();

            insert = new MySqlCommand(insertTeamString, connection);
            insert.Parameters.AddWithValue("@id", team.id);
            insert.Parameters.AddWithValue("@name", team.name);
            insert.Parameters.AddWithValue("@logo", team.logo);
            insert.Parameters.AddWithValue("@national", team.nationnal);
            insert.Parameters.AddWithValue("@countryId", team.country.id);

            insert.ExecuteNonQuery();

        }
    }
}