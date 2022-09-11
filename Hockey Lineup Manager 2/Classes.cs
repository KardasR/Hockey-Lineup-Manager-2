using System.Text.Json.Serialization;

namespace Hockey_Lineup_Manager_2
{
    /// <summary>
    /// Class for Players.
    /// </summary>
    public class Player
    {
        public string Name { get; set; }
        public int Overall { get; set; }
        public string Potential { get; set; }
    }

    /// <summary>
    /// Class for Goalies.
    /// </summary>
    public class Goalies
    {
        public Player Starter { get; set; }
        public Player Backup { get; set; }
        public Player ThirdString { get; set; }
    }

    /// <summary>
    /// Class for NHL Teams.
    /// </summary>
    public class NHLTeam
    {
        public string Name { get; set; }
        public string Record { get; set; }
        public string Playoff { get; set; }
        [JsonInclude]
        public EvenStrengthLines[] ESL = new EvenStrengthLines[5];
        [JsonInclude]
        public PowerPlayLines[] PPL = new PowerPlayLines[4];
        [JsonInclude]
        public PenaltyKillLines[] PKL = new PenaltyKillLines[4];
        [JsonInclude]
        public FourOnFourLines[] FFL = new FourOnFourLines[3];
        [JsonInclude]
        public ThreeOnThreeLines[] TTL = new ThreeOnThreeLines[3];
        public ShootoutExtraAttacker SOEA { get; set; }
        public Goalies Goalies { get; set; }
        [JsonInclude]
        public AHLTeam AHLLines;
    }

    /// <summary>
    /// Class for AHL Teams.
    /// </summary>
    public class AHLTeam
    {
        public string Name { get; set; }
        public string Record { get; set; }
        public string Playoff { get; set; }
        [JsonInclude]
        public EvenStrengthLines[] ESL = new EvenStrengthLines[5];
        public Goalies Goalies { get; set; }
    }

    /// <summary>
    /// Class for Even Strength lines.
    /// </summary>
    public class EvenStrengthLines
    {
        public int Line { get; set; }
        public Player LeftWing { get; set; }
        public Player Center { get; set; }
        public Player RightWing { get; set; }
        public Player LeftDefence { get; set; }
        public Player RightDefence { get; set; }
    }

    /// <summary>
    /// Class for Powerplay lines.
    /// </summary>
    public class PowerPlayLines
    {
        public int Unit { get; set; }
        public string LeftWing { get; set; }
        public string Center { get; set; }
        public string RightWing { get; set; }
        public string LeftDefence { get; set; }
        public string RightDefence { get; set; }
    }

    /// <summary>
    /// Class for Penalty Kill lines.
    /// </summary>
    public class PenaltyKillLines
    {
        public int Unit { get; set; }
        public string Wing { get; set; }
        public string Center { get; set; }
        public string LeftDefence { get; set; }
        public string RightDefence { get; set; }
    }

    /// <summary>
    /// Class for Four on Four lines.
    /// </summary>
    public class FourOnFourLines
    {
        public int Unit { get; set; }
        public string Wing { get; set; }
        public string Center { get; set; }
        public string LeftDefence { get; set; }
        public string RightDefence { get; set; }
    }

    /// <summary>
    /// Class for Three on Three lines.
    /// </summary>
    public class ThreeOnThreeLines
    {
        public int Unit { get; set; }
        public string Wing { get; set; }
        public string Center { get; set; }
        public string Defence { get; set; }
    }

    /// <summary>
    /// Class for Shootout / Extra Attackers.
    /// </summary>
    public class ShootoutExtraAttacker
    {
        public string Shooter1 { get; set; }
        public string Shooter2 { get; set; }
        public string Shooter3 { get; set; }
        public string Shooter4 { get; set; }
        public string Shooter5 { get; set; }
        public string ExtraA1 { get; set; }
        public string ExtraA2 { get; set; }
    }
}
