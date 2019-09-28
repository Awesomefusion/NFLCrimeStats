using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NFLCrimeStats.Models
{
    public class PlayerModel
    {

        public string Name { get; set; }

        public int Arrest_Count { get; set; }

        public string Team { get; set; }

        public string Team_Name { get; set; }
    }
}
