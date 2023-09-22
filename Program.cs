
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FOOTBALL
{
    class Program
    {
        public static void Main()
        {
          
            StandingsDisplay standingsDisplay = new StandingsDisplay();
            standingsDisplay.DisplayStandings();

            TeamProcessor.PrintTeam();

            Team team = new Team();
            team.PrintTeamInfo();
        }
    }
}