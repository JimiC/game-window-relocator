using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GameWindowRelocator.Controllers
{
    internal static class GamesList
    {
        private static string s_filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gameslist.txt");
        private static Dictionary<string, string> s_games = new Dictionary<string, string>();

        internal static Dictionary<string, string> ListOfGames
        {
            get { return s_games; }
        }

        internal static void Import()
        {
            if (!File.Exists(s_filePath))
                return;

            var lines = File.ReadAllLines(s_filePath);

            foreach (var line in lines)
            {
                int seperator = line.IndexOf(':');
                var key = line.Substring(0, seperator);
                var value = line.Substring(seperator + 1);
                s_games.Add(key, value);
            }
        }

        internal static void Export()
        {
            List<string> fileContent = new List<string>();

            foreach (var item in s_games.OrderBy(x => x.Key))
            {
                string line = String.Format("{0}:{1}", item.Key, item.Value);
                fileContent.Add(line);
            }

            File.WriteAllLines(s_filePath, fileContent);
        }
    }
}
