using System.Text.Json;

namespace Hockey_Lineup_Manager_2
{
    public class Methods
    {
        private static Dictionary<string, NHLTeam> Teams = new Dictionary<string, NHLTeam>();
        private static string _currentTeam = string.Empty;

        /// <summary>
        /// Return the currently selected team in the dictionary.
        /// </summary>
        /// <typeparam name="T">Type of return wanted.</typeparam>
        /// <returns>The NHLTeam that is currently selected.</returns>
        public static dynamic SelectCurrent<T>()
        {
            dynamic ret;

            if (typeof(T) == typeof(NHLTeam))
            {
                if (Teams.ContainsKey(_currentTeam))
                    ret = Teams[_currentTeam];
                else
                    ret = new NHLTeam();
            }
            else if (typeof(T) == typeof(string))
            {
                if (Teams.ContainsKey(_currentTeam))
                    ret = JsonSerializer.Serialize(Teams[_currentTeam]);
                else
                    ret = string.Empty;
            }
            else
                ret = string.Empty;

            return ret;
        }

        /// <summary>
        /// Returns the currently selected year.
        /// </summary>
        /// <returns>Value of _currentTeam variable.</returns>
        public static string GetCurrentYear()
        {
            return _currentTeam;
        }

        /// <summary>
        /// Add a new team to the dictionary of teams. This does NOT change the selected team to the additional team.
        /// </summary>
        /// <param name="team"></param>
        public static void Add(string year, NHLTeam team)
        {
            if (!Teams.ContainsKey(year))
                Teams.Add(year, team);
            else
                Teams[year] = team;
        }

        /// <summary>
        /// Sets the team in the dictionary with the given year to the currently selected team.
        /// </summary>
        /// <param name="year"></param>
        /// <returns>True if the current year is in the dictionary, False if it's not.</returns>
        public static bool SetCurrent(string year)
        {
            bool ret = false;
            if (Teams.ContainsKey(year) == true || Teams.Count == 0)
            {
                _currentTeam = year;
                ret = true;
            }

            return ret;
        }

        /// <summary>
        /// Fetch the history of the franchise.
        /// </summary>
        /// <typeparam name="T">Type of return wanted.</typeparam>
        /// <returns>History of the franchise.</returns>
        public static dynamic GetHistory<T>()
        {
            dynamic ret;
            if (typeof(T) == typeof(Dictionary<string, NHLTeam>))
                ret = Teams;
            else if (typeof(T) == typeof(string))
                ret = JsonSerializer.Serialize(Teams);
            else
                ret = false;

            return ret;
        }

        /// <summary>
        /// Overwrite the current history of the franchise.
        /// </summary>
        /// <param name="org">Dictionary containing each team from each year.</param>
        public static void GiveHistory(Dictionary<string, NHLTeam> org)
        {
            Teams = org;
        }
    }
}
