
public class TeamRecord{

    public string Abbreviation {get;set;}
    public string Name {get;set;}
    public int SpecialRanking {get;set;}
    public int Position {get;set;}
    public int GamesPlayed {get;set;}
    public int Wins {get;set;}
    public int Draws {get;set;}
    public int Losses {get;set;}
    public int Goalsfor {get;set;}
    public int GoalsAgainst{get;set;}
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

}

