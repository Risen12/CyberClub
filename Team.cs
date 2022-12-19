using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace CyberClub
{
    public class Team
    {
        public List<string> Players { get; set; }
        public string Name;
        private int id;
        private int rate;

        public Team(string name, int rating)
        {
            Name = name;
            rate = rating;
        }


        public override string ToString()
        {
            return Name;
        }


    }
}
