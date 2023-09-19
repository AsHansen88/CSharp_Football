namespace Football;

public class League{
    public string LeagueName {get;set}
    public int ChampionsLeague {get;set}
    public int EuropeLeague {get;set}
    public int CongerenceLeague {get;set}
    public int upperLeague {get;set}
    public int lowerLeague {get;set}

 public League (string, LeagueName, int positionsForChampions, int positionsForEurope, int positionsForConference, int positionsForPromotion, int positionsForRelegation)

{

 LeagueName = leagueName;
 ChampionsLeague = positionsForChampions;
 EuropeLeague = positionsForEurope;
 CongerenceLeague  = positionsForConference;
 upperLeague = positionsForPromotion;
 lowerLeague = positionsForRelegation;

}
}