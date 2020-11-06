using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ClubTeam
    {
        public int Id { get; set; }
        public string Club { get; set; }
        public string Team { get; set; }

        public ClubTeam(int id, string club, string team)
        {
            Id = id;
            Club = club;
            Team = team;
        }

        public void SetClub(string club)
        {
            throw new NotImplementedException();
        }

        public void SetTeam(string team)
        {
            throw new NotImplementedException();
        }
    }
}
