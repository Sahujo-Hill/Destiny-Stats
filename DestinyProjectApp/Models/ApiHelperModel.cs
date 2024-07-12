using Newtonsoft.Json;

public class ActivitiesCleared
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class ActivitiesEntered
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class ActivitiesWon
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class AdventuresCompleted
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class AllParticipantsCount
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class AllParticipantsScore
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class AllParticipantsTimePlayed
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class AllPvE
{
    [JsonProperty("allTime")]
    public AllTime allTime { get; set; }
}

public class AllPvECompetitive
{
    [JsonProperty("allTime")]
    public AllTime allTime { get; set; }
}

public class AllPvP
{
    [JsonProperty("allTime")]
    public AllTime allTime { get; set; }
}

public class AllStrikes
{
    [JsonProperty("allTime")]
    public AllTime allTime { get; set; }
}

public class AllTime
{
    [JsonProperty("activitiesEntered")]
    public ActivitiesEntered activitiesEntered { get; set; }

    [JsonProperty("activitiesWon")]
    public ActivitiesWon activitiesWon { get; set; }

    [JsonProperty("assists")]
    public Assists assists { get; set; }

    [JsonProperty("totalDeathDistance")]
    public TotalDeathDistance totalDeathDistance { get; set; }

    [JsonProperty("averageDeathDistance")]
    public AverageDeathDistance averageDeathDistance { get; set; }

    [JsonProperty("totalKillDistance")]
    public TotalKillDistance totalKillDistance { get; set; }

    [JsonProperty("kills")]
    public Kills kills { get; set; }

    [JsonProperty("averageKillDistance")]
    public AverageKillDistance averageKillDistance { get; set; }

    [JsonProperty("secondsPlayed")]
    public SecondsPlayed secondsPlayed { get; set; }

    [JsonProperty("deaths")]
    public Deaths deaths { get; set; }

    [JsonProperty("averageLifespan")]
    public AverageLifespan averageLifespan { get; set; }

    [JsonProperty("score")]
    public Score score { get; set; }

    [JsonProperty("averageScorePerKill")]
    public AverageScorePerKill averageScorePerKill { get; set; }

    [JsonProperty("averageScorePerLife")]
    public AverageScorePerLife averageScorePerLife { get; set; }

    [JsonProperty("bestSingleGameKills")]
    public BestSingleGameKills bestSingleGameKills { get; set; }

    [JsonProperty("bestSingleGameScore")]
    public BestSingleGameScore bestSingleGameScore { get; set; }

    [JsonProperty("opponentsDefeated")]
    public OpponentsDefeated opponentsDefeated { get; set; }

    [JsonProperty("efficiency")]
    public Efficiency efficiency { get; set; }

    [JsonProperty("killsDeathsRatio")]
    public KillsDeathsRatio killsDeathsRatio { get; set; }

    [JsonProperty("killsDeathsAssists")]
    public KillsDeathsAssists killsDeathsAssists { get; set; }

    [JsonProperty("objectivesCompleted")]
    public ObjectivesCompleted objectivesCompleted { get; set; }

    [JsonProperty("precisionKills")]
    public PrecisionKills precisionKills { get; set; }

    [JsonProperty("resurrectionsPerformed")]
    public ResurrectionsPerformed resurrectionsPerformed { get; set; }

    [JsonProperty("resurrectionsReceived")]
    public ResurrectionsReceived resurrectionsReceived { get; set; }

    [JsonProperty("suicides")]
    public Suicides suicides { get; set; }

    [JsonProperty("weaponKillsAutoRifle")]
    public WeaponKillsAutoRifle weaponKillsAutoRifle { get; set; }

    [JsonProperty("weaponKillsBeamRifle")]
    public WeaponKillsBeamRifle weaponKillsBeamRifle { get; set; }

    [JsonProperty("weaponKillsBow")]
    public WeaponKillsBow weaponKillsBow { get; set; }

    [JsonProperty("weaponKillsGlaive")]
    public WeaponKillsGlaive weaponKillsGlaive { get; set; }

    [JsonProperty("weaponKillsFusionRifle")]
    public WeaponKillsFusionRifle weaponKillsFusionRifle { get; set; }

    [JsonProperty("weaponKillsHandCannon")]
    public WeaponKillsHandCannon weaponKillsHandCannon { get; set; }

    [JsonProperty("weaponKillsTraceRifle")]
    public WeaponKillsTraceRifle weaponKillsTraceRifle { get; set; }

    [JsonProperty("weaponKillsMachineGun")]
    public WeaponKillsMachineGun weaponKillsMachineGun { get; set; }

    [JsonProperty("weaponKillsPulseRifle")]
    public WeaponKillsPulseRifle weaponKillsPulseRifle { get; set; }

    [JsonProperty("weaponKillsRocketLauncher")]
    public WeaponKillsRocketLauncher weaponKillsRocketLauncher { get; set; }

    [JsonProperty("weaponKillsScoutRifle")]
    public WeaponKillsScoutRifle weaponKillsScoutRifle { get; set; }

    [JsonProperty("weaponKillsShotgun")]
    public WeaponKillsShotgun weaponKillsShotgun { get; set; }

    [JsonProperty("weaponKillsSniper")]
    public WeaponKillsSniper weaponKillsSniper { get; set; }

    [JsonProperty("weaponKillsSubmachinegun")]
    public WeaponKillsSubmachinegun weaponKillsSubmachinegun { get; set; }

    [JsonProperty("weaponKillsRelic")]
    public WeaponKillsRelic weaponKillsRelic { get; set; }

    [JsonProperty("weaponKillsSideArm")]
    public WeaponKillsSideArm weaponKillsSideArm { get; set; }

    [JsonProperty("weaponKillsSword")]
    public WeaponKillsSword weaponKillsSword { get; set; }

    [JsonProperty("weaponKillsAbility")]
    public WeaponKillsAbility weaponKillsAbility { get; set; }

    [JsonProperty("weaponKillsGrenade")]
    public WeaponKillsGrenade weaponKillsGrenade { get; set; }

    [JsonProperty("weaponKillsGrenadeLauncher")]
    public WeaponKillsGrenadeLauncher weaponKillsGrenadeLauncher { get; set; }

    [JsonProperty("weaponKillsSuper")]
    public WeaponKillsSuper weaponKillsSuper { get; set; }

    [JsonProperty("weaponKillsMelee")]
    public WeaponKillsMelee weaponKillsMelee { get; set; }

    [JsonProperty("weaponBestType")]
    public WeaponBestType weaponBestType { get; set; }

    [JsonProperty("winLossRatio")]
    public WinLossRatio winLossRatio { get; set; }

    [JsonProperty("allParticipantsCount")]
    public AllParticipantsCount allParticipantsCount { get; set; }

    [JsonProperty("allParticipantsScore")]
    public AllParticipantsScore allParticipantsScore { get; set; }

    [JsonProperty("allParticipantsTimePlayed")]
    public AllParticipantsTimePlayed allParticipantsTimePlayed { get; set; }

    [JsonProperty("longestKillSpree")]
    public LongestKillSpree longestKillSpree { get; set; }

    [JsonProperty("longestSingleLife")]
    public LongestSingleLife longestSingleLife { get; set; }

    [JsonProperty("mostPrecisionKills")]
    public MostPrecisionKills mostPrecisionKills { get; set; }

    [JsonProperty("orbsDropped")]
    public OrbsDropped orbsDropped { get; set; }

    [JsonProperty("orbsGathered")]
    public OrbsGathered orbsGathered { get; set; }

    [JsonProperty("remainingTimeAfterQuitSeconds")]
    public RemainingTimeAfterQuitSeconds remainingTimeAfterQuitSeconds { get; set; }

    [JsonProperty("teamScore")]
    public TeamScore teamScore { get; set; }

    [JsonProperty("totalActivityDurationSeconds")]
    public TotalActivityDurationSeconds totalActivityDurationSeconds { get; set; }

    [JsonProperty("combatRating")]
    public CombatRating combatRating { get; set; }

    [JsonProperty("fastestCompletionMs")]
    public FastestCompletionMs fastestCompletionMs { get; set; }

    [JsonProperty("longestKillDistance")]
    public LongestKillDistance longestKillDistance { get; set; }

    [JsonProperty("highestCharacterLevel")]
    public HighestCharacterLevel highestCharacterLevel { get; set; }

    [JsonProperty("highestLightLevel")]
    public HighestLightLevel highestLightLevel { get; set; }

    [JsonProperty("fireTeamActivities")]
    public FireTeamActivities fireTeamActivities { get; set; }

    [JsonProperty("activitiesCleared")]
    public ActivitiesCleared activitiesCleared { get; set; }

    [JsonProperty("heroicPublicEventsCompleted")]
    public HeroicPublicEventsCompleted heroicPublicEventsCompleted { get; set; }

    [JsonProperty("adventuresCompleted")]
    public AdventuresCompleted adventuresCompleted { get; set; }

    [JsonProperty("publicEventsCompleted")]
    public PublicEventsCompleted publicEventsCompleted { get; set; }

    [JsonProperty("invasions")]
    public Invasions invasions { get; set; }

    [JsonProperty("invasionKills")]
    public InvasionKills invasionKills { get; set; }

    [JsonProperty("invasionDeaths")]
    public InvasionDeaths invasionDeaths { get; set; }

    [JsonProperty("invaderKills")]
    public InvaderKills invaderKills { get; set; }

    [JsonProperty("invaderDeaths")]
    public InvaderDeaths invaderDeaths { get; set; }

    [JsonProperty("primevalKills")]
    public PrimevalKills primevalKills { get; set; }

    [JsonProperty("blockerKills")]
    public BlockerKills blockerKills { get; set; }

    [JsonProperty("mobKills")]
    public MobKills mobKills { get; set; }

    [JsonProperty("highValueKills")]
    public HighValueKills highValueKills { get; set; }

    [JsonProperty("motesPickedUp")]
    public MotesPickedUp motesPickedUp { get; set; }

    [JsonProperty("motesDeposited")]
    public MotesDeposited motesDeposited { get; set; }

    [JsonProperty("motesDenied")]
    public MotesDenied motesDenied { get; set; }

    [JsonProperty("motesLost")]
    public MotesLost motesLost { get; set; }

    [JsonProperty("bankOverage")]
    public BankOverage bankOverage { get; set; }

    [JsonProperty("smallBlockersSent")]
    public SmallBlockersSent smallBlockersSent { get; set; }

    [JsonProperty("mediumBlockersSent")]
    public MediumBlockersSent mediumBlockersSent { get; set; }

    [JsonProperty("largeBlockersSent")]
    public LargeBlockersSent largeBlockersSent { get; set; }

    [JsonProperty("primevalDamage")]
    public PrimevalDamage primevalDamage { get; set; }

    [JsonProperty("primevalHealing")]
    public PrimevalHealing primevalHealing { get; set; }

    [JsonProperty("roundsPlayed")]
    public RoundsPlayed roundsPlayed { get; set; }

    [JsonProperty("roundsWon")]
    public RoundsWon roundsWon { get; set; }
}

public class Assists
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class AverageDeathDistance
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class AverageKillDistance
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class AverageLifespan
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class AverageScorePerKill
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class AverageScorePerLife
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class BankOverage
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class Basic
{
    [JsonProperty("value")]
    public double value { get; set; }

    [JsonProperty("displayValue")]
    public string displayValue { get; set; }
}

public class BestSingleGameKills
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("activityId")]
    public string activityId { get; set; }
}

public class BestSingleGameScore
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("activityId")]
    public string activityId { get; set; }
}

public class BlockerKills
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class CombatRating
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class Deaths
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class Efficiency
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class FastestCompletionMs
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("activityId")]
    public string activityId { get; set; }
}

public class FireTeamActivities
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class HeroicPublicEventsCompleted
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class HighestCharacterLevel
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class HighestLightLevel
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class HighValueKills
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class InvaderDeaths
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class InvaderKills
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class InvasionDeaths
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class InvasionKills
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class Invasions
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class Kills
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class KillsDeathsAssists
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class KillsDeathsRatio
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class LargeBlockersSent
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class LongestKillDistance
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("activityId")]
    public string activityId { get; set; }
}

public class LongestKillSpree
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("activityId")]
    public string activityId { get; set; }
}

public class LongestSingleLife
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("activityId")]
    public string activityId { get; set; }
}

public class MediumBlockersSent
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class MessageData
{
}

public class MobKills
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class MostPrecisionKills
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("activityId")]
    public string activityId { get; set; }
}

public class MotesDenied
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class MotesDeposited
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class MotesLost
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class MotesPickedUp
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class ObjectivesCompleted
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class OpponentsDefeated
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class OrbsDropped
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class OrbsGathered
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class Patrol
{
    [JsonProperty("allTime")]
    public AllTime allTime { get; set; }
}

public class Pga
{
    [JsonProperty("value")]
    public double value { get; set; }

    [JsonProperty("displayValue")]
    public string displayValue { get; set; }
}

public class PrecisionKills
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class PrimevalDamage
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class PrimevalHealing
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class PrimevalKills
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class PublicEventsCompleted
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class Raid
{
    [JsonProperty("allTime")]
    public AllTime allTime { get; set; }
}

public class RemainingTimeAfterQuitSeconds
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class Response
{
    [JsonProperty("allPvP")]
    public AllPvP allPvP { get; set; }

    [JsonProperty("patrol")]
    public Patrol patrol { get; set; }

    [JsonProperty("raid")]
    public Raid raid { get; set; }

    [JsonProperty("story")]
    public Story story { get; set; }

    [JsonProperty("allStrikes")]
    public AllStrikes allStrikes { get; set; }

    [JsonProperty("allPvE")]
    public AllPvE allPvE { get; set; }

    [JsonProperty("allPvECompetitive")]
    public AllPvECompetitive allPvECompetitive { get; set; }
}

public class ResurrectionsPerformed
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class ResurrectionsReceived
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class Root
{
    [JsonProperty("Response")]
    public Response Response { get; set; }

    [JsonProperty("ErrorCode")]
    public int ErrorCode { get; set; }

    [JsonProperty("ThrottleSeconds")]
    public int ThrottleSeconds { get; set; }

    [JsonProperty("ErrorStatus")]
    public string ErrorStatus { get; set; }

    [JsonProperty("Message")]
    public string Message { get; set; }

    [JsonProperty("MessageData")]
    public MessageData MessageData { get; set; }
}

public class RoundsPlayed
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class RoundsWon
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class Score
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class SecondsPlayed
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class SmallBlockersSent
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class Story
{
    [JsonProperty("allTime")]
    public AllTime allTime { get; set; }
}

public class Suicides
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class TeamScore
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class TotalActivityDurationSeconds
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class TotalDeathDistance
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class TotalKillDistance
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class WeaponBestType
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

public class WeaponKillsAbility
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsAutoRifle
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsBeamRifle
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsBow
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsFusionRifle
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsGlaive
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsGrenade
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsGrenadeLauncher
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsHandCannon
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsMachineGun
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsMelee
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsPulseRifle
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsRelic
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsRocketLauncher
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsScoutRifle
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsShotgun
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsSideArm
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsSniper
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsSubmachinegun
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsSuper
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsSword
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WeaponKillsTraceRifle
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }

    [JsonProperty("pga")]
    public Pga pga { get; set; }
}

public class WinLossRatio
{
    [JsonProperty("statId")]
    public string statId { get; set; }

    [JsonProperty("basic")]
    public Basic basic { get; set; }
}

