class TeamProcessor
{
public static void PrintTeam()
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
                            Goalsfor = int.Parse(values[8]),
                            GoalsAgainst = int.Parse(values[9])
                        };
                        teams.Add(team);
                    }
                }
            }

            // Print the table of team information
            PrintTable(teams);
        }
        else
        {
            Console.WriteLine("File doesn't exist");
        }

        Console.ReadLine();
    }

    // Add a method to print the table
    static void PrintTable(List<Team> teams)
    {
        Console.WriteLine("Team Information Table:\n");
        foreach (var team in teams)
        {
            team.PrintTeamInfo();
        }
    }
}