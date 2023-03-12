using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_v2
{
    public class Result
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string time { get; set; }
        public int timestamp { get; set; }
        public string timezone { get; set; }
        public object stage { get; set; }
        public string week { get; set; }
        public Status status { get; set; }
        public League league { get; set; }
        public Country country { get; set; }
        public Teams teams { get; set; }
        public Scores scores { get; set; }
    }

    public class Status
    {
        public string _long { get; set; }
        public string _short { get; set; }
        public object timer { get; set; }
    }

    public class League
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string season { get; set; }
        public string logo { get; set; }
    }

    public class Teams
    {
        public Home home { get; set; }
        public Away away { get; set; }
    }

    public class Home
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
    }

    public class Away
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
    }

    public class Scores
    {
        public Home1 home { get; set; }
        public Away1 away { get; set; }
    }

    public class Home1
    {
        public int quarter_1 { get; set; }
        public int quarter_2 { get; set; }
        public int quarter_3 { get; set; }
        public int quarter_4 { get; set; }
        public object over_time { get; set; }
        public int total { get; set; }
    }

    public class Away1
    {
        public int quarter_1 { get; set; }
        public int quarter_2 { get; set; }
        public int quarter_3 { get; set; }
        public int quarter_4 { get; set; }
        public object over_time { get; set; }
        public int total { get; set; }
    }

}