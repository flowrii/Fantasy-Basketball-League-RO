using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_v2
{
    public class Team
    {
        public int Id { get; set; }
        public string Team_name { get; set; }

        public string Logo { get; set; }

        public bool National { get; set; }

        public Country Country { get; set; }

    }
}