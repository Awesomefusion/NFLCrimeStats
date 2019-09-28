using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLCrimeStats.Models
{
    public class TeamModel
    {
        public string Team { get; set; }
        public string Team_Name { get; set; }

        public string Team_City { get; set; }

        public int Arrest_Count { get; set; }
    }
}
