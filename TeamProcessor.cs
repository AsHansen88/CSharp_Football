using System;
using System.Collections.Generic;
using System.IO;

public class TeamProcessor
{
    public static List<Team> GetTeams()
    {
        string filePath = @"CSV_Files\Teams.csv";
        List<Team> teams = new List<Team>();

        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(File.OpenRead(filePath)))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values.Length == 11) // Check if the CSV has the correct number of fields
                    {
                        Team team = new Team
                        {
                            Abbreviation = values[0],
                            Name = values[1],
                            SpecialRanking = int.Parse(values[2]),
                            Position = int.Parse(values[3]),
                            GamesPlayed = int.Parse(values[4]),
                            Wins = int.Parse(values[5]),
                            Draws = int.Parse(values[6]),
                            Losses = int.Parse(values[7]),
                            Goalsfor = int.Parse(values[8]), // Corrected property name
                            GoalsAgainst = int.Parse(values[9]) // Corrected property name
                        };
                        teams.Add(team);
                    }
                }
            }
            return teams;
        }
        else
        {
            Console.WriteLine("File doesn't exist");
            return null; // Return null if the file doesn't exist
        }
    }
}
