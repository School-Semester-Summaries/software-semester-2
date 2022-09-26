using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseHangmanForms.Logic
{
    public class TeamCollection
    {
        // Objects
        List<Team> teamList = new List<Team>();

        // Methods
        public void AddTeam(Team team)
        {
            teamList.Add(team);
        }
        public List<Team> GetTeamList()
        {
            return teamList;
        }
    }
}
