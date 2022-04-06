using System;
using System.Collections.Generic;


namespace Lab_02_4
{
    internal static class MetodyRozszerzen
    {

        public static string CollectionToString(this IEnumerable<Piłkarz> players)
        {
            var stringifiedPilkarze = new List<string>();
            foreach (var pilakrz in players)
            {
                stringifiedPilkarze.Add($"{pilakrz.Nazwisko},{pilakrz.Imię},{pilakrz.Waga},{pilakrz.Wzrost},{pilakrz.Pozycja}");
            }

            return string.Join("$", stringifiedPilkarze);
        }

        public static List<Piłkarz> StringToCollection(this string decryptedData)
        {
            var players = new List<Piłkarz>();

            if (string.IsNullOrWhiteSpace(decryptedData))
            {
                return players;
            }

            var collectionOfStrings = decryptedData.Split('$');

            foreach (var str in collectionOfStrings)
            {
                var pilkarz = str.Split(',');

                players.Add(new Piłkarz
                {
                    Nazwisko = pilkarz[0],
                    Imię = pilkarz[1],
                    Waga = Int32.Parse(pilkarz[2]),
                    Wzrost = Int32.Parse(pilkarz[3]),
                    Pozycja = (Pozycja)pilkarz[4].PozycjaMapper()
                });
            }

            return players;
        }

        private static int PozycjaMapper(this string role)
        {
            if (string.IsNullOrWhiteSpace(role) || role.Equals("-1"))
            {
                return -1;
            }

            switch (role)
            {
                case "Bramkarz":
                    return 0;
                case "Obrońca":
                    return 1;
                case "Pomocnik":
                    return 2;
                case "Napastnik":
                    return 3;
                default:
                    return -1;
            }
        }
    }
}
