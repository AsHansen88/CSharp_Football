
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
            
            List<Team> teams = TeamProcessor.GetTeams();
            
            //StandingsDisplay standingsDisplay = new StandingsDisplay();
            //standingsDisplay.DisplayStandings();        

            //Team team = new Team();
            //team.PrintTeamInfo();
             
             int i = 0;
            PrintAllTeams(teams);
            while(i <32) {

                // Læs en linie fra mixedteam.csv

try
{
    string filePath = @"CSV_Files/MixedTeam.csv";

    if (File.Exists(filePath))
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;
            
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("The file does not exist.");
    }
}
catch (Exception e)
{
    Console.WriteLine("An error occurred while reading the file:");
    Console.WriteLine(e.Message);
}

Console.ReadLine();


                // Opdater match

                Team team = new Team();
                team.UpdateMatchResult(team.opposingTeam ,team.Goalsfor, team.GoalsAgainst);

    

        

                PrintAllTeams(teams);
            }

          }

        static void PrintAllTeams(List<Team> teams) {
            Console.WriteLine("Name     M W D L GF GA GD Stream");
            foreach(Team team in teams) {
                team.PrintTeamInfo();
            }
        }
    }
}