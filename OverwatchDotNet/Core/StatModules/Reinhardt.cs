using OverwatchAPI.Internal;
using System;
using System.Collections.Generic;

//-- A U T O   G E N E R A T E D --//

namespace OverwatchAPI.Data
{
	public class Reinhardt : IStatGroup
	{
		public HeroSpecificStats HeroSpecific { get; private set; }
		public CombatStats Combat { get; private set; }
		public AssistsStats Assists { get; private set; }
		public BestStats Best { get; private set; }
		public AverageStats Average { get; private set; }
		public DeathsStats Deaths { get; private set; }
		public MatchAwardsStats MatchAwards { get; private set; }
		public GameStats Game { get; private set; }
		public MiscellaneousStats Miscellaneous { get; private set; }

		public void SendPage(IEnumerable<OverwatchDataTable> tableCollection)
		{
			foreach(var item in tableCollection)
			{
				var prop = GetType().GetProperty(item.Name.Replace(" ", ""));
				if (typeof(IStatModule).IsAssignableFrom(prop.PropertyType))
				{
					IStatModule statModule = (IStatModule)Activator.CreateInstance(prop.PropertyType);
					statModule.SendTable(item);
					prop.SetValue(this, statModule);
				}
			}
		}

		public class HeroSpecificStats : IStatModule
		{
			public float DamageBlocked { get; private set; }
			public float DamageBlockedMostinGame { get; private set; }
			public float ChargeKills { get; private set; }
			public float ChargeKillsMostinGame { get; private set; }
			public float FireStrikeKills { get; private set; }
			public float FireStrikeKillsMostinGame { get; private set; }
			public float EarthshatterKills { get; private set; }
			public float EarthshatterKillsMostinGame { get; private set; }
			public float FireStrikeKillsAverage { get; private set; }
			public float EarthshatterKillsAverage { get; private set; }
			public float DamageBlockedAverage { get; private set; }
			public float ChargeKillsAverage { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				DamageBlocked = table.Stats["Damage Blocked"].OWValToFloat();
				DamageBlockedMostinGame = table.Stats["Damage Blocked - Most in Game"].OWValToFloat();
				ChargeKills = table.Stats["Charge Kills"].OWValToFloat();
				ChargeKillsMostinGame = table.Stats["Charge Kills - Most in Game"].OWValToFloat();
				FireStrikeKills = table.Stats["Fire Strike Kills"].OWValToFloat();
				FireStrikeKillsMostinGame = table.Stats["Fire Strike Kills - Most in Game"].OWValToFloat();
				EarthshatterKills = table.Stats["Earthshatter Kills"].OWValToFloat();
				EarthshatterKillsMostinGame = table.Stats["Earthshatter Kills - Most in Game"].OWValToFloat();
				FireStrikeKillsAverage = table.Stats["Fire Strike Kills - Average"].OWValToFloat();
				EarthshatterKillsAverage = table.Stats["Earthshatter Kills - Average"].OWValToFloat();
				DamageBlockedAverage = table.Stats["Damage Blocked - Average"].OWValToFloat();
				ChargeKillsAverage = table.Stats["Charge Kills - Average"].OWValToFloat();
			}
		}

		public class CombatStats : IStatModule
		{
			public float Eliminations { get; private set; }
			public float FinalBlows { get; private set; }
			public float SoloKills { get; private set; }
			public float DamageDone { get; private set; }
			public float ObjectiveKills { get; private set; }
			public float Multikills { get; private set; }
			public float EliminationsperLife { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				Eliminations = table.Stats["Eliminations"].OWValToFloat();
				FinalBlows = table.Stats["Final Blows"].OWValToFloat();
				SoloKills = table.Stats["Solo Kills"].OWValToFloat();
				DamageDone = table.Stats["Damage Done"].OWValToFloat();
				ObjectiveKills = table.Stats["Objective Kills"].OWValToFloat();
				Multikills = table.Stats["Multikills"].OWValToFloat();
				EliminationsperLife = table.Stats["Eliminations per Life"].OWValToFloat();
			}
		}

		public class AssistsStats : IStatModule
		{
			public float TeleporterPadsDestroyed { get; private set; }
			public float TurretsDestroyed { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				TeleporterPadsDestroyed = table.Stats["Teleporter Pads Destroyed"].OWValToFloat();
				TurretsDestroyed = table.Stats["Turrets Destroyed"].OWValToFloat();
			}
		}

		public class BestStats : IStatModule
		{
			public float EliminationsMostinLife { get; private set; }
			public float MostScorewithinoneLife { get; private set; }
			public float DamageDoneMostinLife { get; private set; }
			public float KillStreakBest { get; private set; }
			public float DamageDoneMostinGame { get; private set; }
			public float EliminationsMostinGame { get; private set; }
			public float FinalBlowsMostinGame { get; private set; }
			public float ObjectiveKillsMostinGame { get; private set; }
			public float ObjectiveTimeMostinGame { get; private set; }
			public float SoloKillsMostinGame { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				EliminationsMostinLife = table.Stats["Eliminations - Most in Life"].OWValToFloat();
				MostScorewithinoneLife = table.Stats["Most Score within one Life"].OWValToFloat();
				DamageDoneMostinLife = table.Stats["Damage Done - Most in Life"].OWValToFloat();
				KillStreakBest = table.Stats["Kill Streak - Best"].OWValToFloat();
				DamageDoneMostinGame = table.Stats["Damage Done - Most in Game"].OWValToFloat();
				EliminationsMostinGame = table.Stats["Eliminations - Most in Game"].OWValToFloat();
				FinalBlowsMostinGame = table.Stats["Final Blows - Most in Game"].OWValToFloat();
				ObjectiveKillsMostinGame = table.Stats["Objective Kills - Most in Game"].OWValToFloat();
				ObjectiveTimeMostinGame = table.Stats["Objective Time - Most in Game"].OWValToFloat();
				SoloKillsMostinGame = table.Stats["Solo Kills - Most in Game"].OWValToFloat();
			}
		}

		public class AverageStats : IStatModule
		{
			public float DeathsAverage { get; private set; }
			public float SoloKillsAverage { get; private set; }
			public float ObjectiveTimeAverage { get; private set; }
			public float ObjectiveKillsAverage { get; private set; }
			public float FinalBlowsAverage { get; private set; }
			public float EliminationsAverage { get; private set; }
			public float DamageDoneAverage { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				DeathsAverage = table.Stats["Deaths - Average"].OWValToFloat();
				SoloKillsAverage = table.Stats["Solo Kills - Average"].OWValToFloat();
				ObjectiveTimeAverage = table.Stats["Objective Time - Average"].OWValToFloat();
				ObjectiveKillsAverage = table.Stats["Objective Kills - Average"].OWValToFloat();
				FinalBlowsAverage = table.Stats["Final Blows - Average"].OWValToFloat();
				EliminationsAverage = table.Stats["Eliminations - Average"].OWValToFloat();
				DamageDoneAverage = table.Stats["Damage Done - Average"].OWValToFloat();
			}
		}

		public class DeathsStats : IStatModule
		{
			public float Deaths { get; private set; }
			public float EnvironmentalDeaths { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				Deaths = table.Stats["Deaths"].OWValToFloat();
				EnvironmentalDeaths = table.Stats["Environmental Deaths"].OWValToFloat();
			}
		}

		public class MatchAwardsStats : IStatModule
		{
			public float MedalsBronze { get; private set; }
			public float MedalsSilver { get; private set; }
			public float MedalsGold { get; private set; }
			public float Medals { get; private set; }
			public float Cards { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				MedalsBronze = table.Stats["Medals - Bronze"].OWValToFloat();
				MedalsSilver = table.Stats["Medals - Silver"].OWValToFloat();
				MedalsGold = table.Stats["Medals - Gold"].OWValToFloat();
				Medals = table.Stats["Medals"].OWValToFloat();
				Cards = table.Stats["Cards"].OWValToFloat();
			}
		}

		public class GameStats : IStatModule
		{
			public TimeSpan TimePlayed { get; private set; }
			public float GamesPlayed { get; private set; }
			public float GamesWon { get; private set; }
			public float Score { get; private set; }
			public float ObjectiveTime { get; private set; }
			public float TimeSpentonFire { get; private set; }
			public float WinPercentage { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				TimePlayed = table.Stats["Time Played"].OWValToTimeSpan();
				GamesPlayed = table.Stats["Games Played"].OWValToFloat();
				GamesWon = table.Stats["Games Won"].OWValToFloat();
				Score = table.Stats["Score"].OWValToFloat();
				ObjectiveTime = table.Stats["Objective Time"].OWValToFloat();
				TimeSpentonFire = table.Stats["Time Spent on Fire"].OWValToFloat();
				WinPercentage = table.Stats["Win Percentage"].OWValToFloat();
			}
		}

		public class MiscellaneousStats : IStatModule
		{
			public float MultikillBest { get; private set; }

			public void SendTable(OverwatchDataTable table)
			{
				MultikillBest = table.Stats["Multikill - Best"].OWValToFloat();
			}
		}
	}
}