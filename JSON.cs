using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    class IplCensorshipAnalyzer
    {
        static void Main(string[] args)
        {
            // Input file paths
            string jsonInputPath = @"C:\Users\HP\Documents\C#\Assignment26\iplData.json";
            string csvInputPath = @"C:\Users\HP\Documents\C#\Assignment26\iplData.csv";

            // Output file paths
            string jsonOutputPath = @"C:\Users\HP\Documents\C#\Assignment26\censored_ipl_data.json";
            string csvOutputPath = @"C:\Users\HP\Documents\C#\Assignment26\censored_ipl_data.csv";

            // 1. Process JSON Input
            if (File.Exists(jsonInputPath))
            {
                string jsonContent = File.ReadAllText(jsonInputPath);
                List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(jsonContent);
                ApplyCensorship(matches);
                string censoredJson = JsonConvert.SerializeObject(matches, Formatting.Indented);
                File.WriteAllText(jsonOutputPath, censoredJson);
                Console.WriteLine("Censored JSON file created: " + jsonOutputPath);
            }
            else
            {
                Console.WriteLine("JSON input file not found: " + jsonInputPath);
            }

            // 2. Process CSV Input
            if (File.Exists(csvInputPath))
            {
                var csvLines = File.ReadAllLines(csvInputPath).ToList();
                var headers = csvLines[0].Split(',').ToList();
                var censoredCsv = new List<string> { string.Join(",", headers) };

                for (int i = 1; i < csvLines.Count; i++)
                {
                    var fields = csvLines[i].Split(',').ToList();
                    var match = new Match
                    {
                        MatchId = int.Parse(fields[0]),
                        Team1 = fields[1],
                        Team2 = fields[2],
                        Score = new Dictionary<string, int>
                    {
                        { fields[1], int.Parse(fields[3]) },
                        { fields[2], int.Parse(fields[4]) }
                    },
                        Winner = fields[5],
                        PlayerOfMatch = fields[6]
                    };
                    ApplyCensorship(new List<Match> { match });

                    censoredCsv.Add($"{match.MatchId},{match.Team1},{match.Team2},{match.Score[match.Team1]},{match.Score[match.Team2]},{match.Winner},{match.PlayerOfMatch}");
                }

                File.WriteAllLines(csvOutputPath, censoredCsv);
                Console.WriteLine("Censored CSV file created: " + csvOutputPath);
            }
            else
            {
                Console.WriteLine("CSV input file not found: " + csvInputPath);
            }
        }

        // Apply censorship rules
        static void ApplyCensorship(List<Match> matches)
        {
            foreach (var match in matches)
            {
                match.Team1 = MaskTeamName(match.Team1);
                match.Team2 = MaskTeamName(match.Team2);
                match.Winner = MaskTeamName(match.Winner);
                match.PlayerOfMatch = "REDACTED";

                // Update score dictionary keys
                var newScore = new Dictionary<string, int>();
                foreach (var kvp in match.Score)
                {
                    newScore[MaskTeamName(kvp.Key)] = kvp.Value;
                }
                match.Score = newScore;
            }
        }

        // Mask team names
        static string MaskTeamName(string teamName)
        {
            if (string.IsNullOrEmpty(teamName)) return teamName;
            string[] parts = teamName.Split(' ');
            if (parts.Length > 1)
            {
                return parts[0] + " ***";
            }
            return teamName;
        }
    }

    // Match class to represent IPL match data
    class Match
    {
        public int MatchId { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public Dictionary<string, int> Score { get; set; }
        public string Winner { get; set; }
        public string PlayerOfMatch { get; set; }
    }
}