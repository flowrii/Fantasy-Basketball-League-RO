using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_v2
{
    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public bool nationnal { get; set; }
        public Country country { get; set; }

    }

}