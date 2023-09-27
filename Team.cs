using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Team
{
    public string Abbreviation { get; set; }
    public string Name { get; set; }
    public int SpecialRanking { get; set; }
    public int Position { get; set; }
    public int GamesPlayed { get; set; }
    public int Wins { get; set; }
    public int Draws { get; set; }
    public int Losses { get; set; }
    public int Goalsfor { get; set; }
    public int GoalsAgainst { get; set; }

    public string opposingTeam {get; set;}
    public int GoalsDifference => Goalsfor - GoalsAgainst;
    public int Points => Wins * 3 + Draws;
    public Queue<char> Streak { get; private set; } = new Queue<char>(5);

    public void UpdateMatchResult(string opposingTeam, int goalsfor, int goalsAgainst)
    {
        GamesPlayed++;
        Goalsfor += goalsfor;
        GoalsAgainst += goalsAgainst;

        if (goalsfor > goalsAgainst)
        {
            Wins++;
            UpdateStreak('W');
        }
        else if (goalsfor == goalsAgainst)
        {
            Draws++;
            UpdateStreak('D');
        }
        else
        {
            Losses++;
            UpdateStreak('L');
        }
    }

    private void UpdateStreak(char result)
    {
        if (Streak.Count == 5)
        {
            Streak.Dequeue();
        }
        Streak.Enqueue(result);
    }

    public string GetStreakDisplay()
    {
        return Streak.Any() ? string.Join("|", Streak) : "-";
    }

    // Add a method to print team information
    public void PrintTeamInfo()
    {
        Console.WriteLine($"{Abbreviation} {Name} {SpecialRanking} {Position} {GamesPlayed} {Wins} {Draws} {Losses} {Goalsfor} {GoalsAgainst} {GoalsDifference} {Points} {GetStreakDisplay}" );
        /*
        Console.WriteLine($"Abbreviation: {Abbreviation}");
        Console.WriteLine($"name: {Name}");
        Console.WriteLine($"Special Ranking: {SpecialRanking}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Games Played: {GamesPlayed}");
        Console.WriteLine($"Wins: {Wins}");
        Console.WriteLine($"Draws: {Draws}");
        Console.WriteLine($"Losses: {Losses}");
        Console.WriteLine($"Goals For: {Goalsfor}");
        Console.WriteLine($"Goals Against: {GoalsAgainst}");
        Console.WriteLine($"Goals Difference: {GoalsDifference}");
        Console.WriteLine($"Points: {Points}");
        Console.WriteLine($"Streak: {GetStreakDisplay()}");
        Console.WriteLine();
    }
    */
    }
}