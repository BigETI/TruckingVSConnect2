using System.Collections.Generic;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Cities class
    /// </summary>
    public class Cities
    {
        /// <summary>
        /// Cities
        /// </summary>
        private static Dictionary<string, Country> cities;

        /// <summary>
        /// Static constructor
        /// </summary>
        static Cities()
        {
            Country austria = new Country("AUSTRIA", "AT");
            Country belgium = new Country("BELGIUM", "BE");
            Country czech_republic = new Country("CZECH_REPUBLIC", "CZ");
            Country denmark = new Country("DENMARK", "DK");
            Country france = new Country("FRANCE", "FR");
            Country germany = new Country("GERMANY", "DE");
            Country hungary = new Country("HUNGARY", "HU");
            Country italy = new Country("ITALY", "IT");
            Country luxembourg = new Country("LUXEMBOURG", "LU");
            Country netherlands = new Country("NETHERLANDS", "NL");
            Country norway = new Country("NORWAY", "NO");
            Country poland = new Country("POLAND", "PL");
            Country slovakia = new Country("SLOVAKIA", "SK");
            Country sweden = new Country("SWEDEN", "SE");
            Country switzerland = new Country("SWITZERLAND", "CH");
            Country england = new Country("ENGLAND", "GB");
            Country scotland = new Country("SCOTLAND", "GB");
            Country wales = new Country("WALES", "GB");
            cities = new Dictionary<string, Country>()
                {
                    // Austria
                    { "Innsbruck", austria },
                    { "Linz", austria },
                    { "Salzburg", austria },
                    { "Vienna", austria },
                    { "Graz", austria },
                    { "Klagenfurt am Wörthersee", austria },

                    // Belgium
                    { "Brussel", belgium },
                    { "Liège", belgium },

                    // Czech Republic
                    { "Brno", czech_republic },
                    { "Prague", czech_republic },
                    { "Ostrava", czech_republic },

                    // Denmark
                    { "Aalborg", denmark },
                    { "Copenhagen", denmark },
                    { "Odense", denmark },
                    { "Esbjerg", denmark },
                    { "Frederikshavn", denmark },
                    { "Gedser", denmark },
                    { "Hirtshals", denmark },

                    // France
                    { "Calais", france },
                    { "Dijon", france },
                    { "Lille", france },
                    { "Lyon", france },
                    { "Metz", france },
                    { "Paris", france },
                    { "Reims", france },
                    { "Strasbourg", france },
                    { "Le Havre", france },
                    { "Le Mans", france },
                    { "Clermont-Ferrand", france },
                    { "Nice", france },
                    { "Marseille", france },
                    { "Montpellier", france },
                    { "Toulouse", france },
                    { "Bordeaux", france },
                    { "La Rochelle", france },
                    { "Nantes", france },
                    { "Brest", france },
                    { "Rennes", france },
                    { "Limoges", france },
                    { "Paluel", france },
                    { "Saint-Laurent", france },
                    { "Bourges", france },
                    { "Saint-Alban-du-Rhône", france },
                    { "Golfech", france },
                    { "Civaux", france },
                    { "Roscoff", france },

                    // Germany
                    { "Berlin", germany },
                    { "Bremen", germany },
                    { "Dortmund", germany },
                    { "Dresden", germany },
                    { "Duisburg", germany },
                    { "Düsseldorf", germany },
                    { "Erfurt", germany },
                    { "Frankfurt", germany },
                    { "Hamburg", germany },
                    { "Hannover", germany },
                    { "Kassel", germany },
                    { "Kiel", germany },
                    { "Cologne", germany },
                    { "Leipzig", germany },
                    { "Magdeburg", germany },
                    { "Mannheim", germany },
                    { "Munich", germany },
                    { "Nürnberg", germany },
                    { "Osnabrück", germany },
                    { "Rostock", germany },
                    { "Stuttgart", germany },

                    // Hungary
                    { "Budapest", hungary },
                    { "Debrecen", hungary },
                    { "Pécs", hungary },
                    { "Szeged", hungary },

                    // Italy
                    { "Milano", italy },
                    { "Torino", italy },
                    { "Verona", italy },
                    { "Venezia", italy },

                    // Luxembourg
                    { "Luxembourg", luxembourg },

                    // Netherlands
                    { "Amsterdam", netherlands },
                    { "Groningen", netherlands },
                    { "Rotterdam", netherlands },

                    // Norway
                    { "Bergen", norway },
                    { "Kristiansand", norway },
                    { "Oslo", norway },
                    { "Stavanger", norway },

                    // Poland
                    { "Bialystok", poland },
                    { "Gdańsk", poland },
                    { "Katowice", poland },
                    { "Kraków", poland },
                    { "Łódź", poland },
                    { "Lublin", poland },
                    { "Olsztyn", poland },
                    { "Poznań", poland },
                    { "Szczecin", poland },
                    { "Wrocław", poland },
                    { "Warsaw", poland },

                    // Slovakia
                    { "Banská Bystrica", slovakia },
                    { "Bratislava", slovakia },
                    { "Košice", slovakia },

                    // Sweden
                    { "Göteborg", sweden },
                    { "Helsingborg", sweden },
                    { "Jönköping", sweden },
                    { "Kalmar", sweden },
                    { "Karlskrona", sweden },
                    { "Linköping", sweden },
                    { "Malmö", sweden },
                    { "Örebro", sweden },
                    { "Stockholm", sweden },
                    { "Uppsala", sweden },
                    { "Västerås", sweden },
                    { "Växjö", sweden },
                    { "Nynäshamn", sweden },
                    { "Södertälje", sweden },
                    { "Trelleborg", sweden },

                    // Switzerland
                    { "Bern", switzerland },
                    { "Genève", switzerland },
                    { "Zürich", switzerland },

                    // England
                    { "Birmingham", england },
                    { "Cambridge", england },
                    { "Carlisle", england },
                    { "Dover", england },
                    { "Felixstowe", england },
                    { "Grimsby", england },
                    { "Liverpool", england },
                    { "London", england },
                    { "Manchester", england },
                    { "Newcastle-upon-Tyne", england },
                    { "Plymouth", england },
                    { "Sheffield", england },
                    { "Southampton", england },

                    // Scotland
                    { "Aberdeen", scotland },
                    { "Edinburgh", scotland },
                    { "Glasgow", scotland },

                    // Wales
                    { "Cardiff", wales },
                    { "Swansea", wales },
                };
        }

        /// <summary>
        /// Is city valid
        /// </summary>
        /// <param name="city">City</param>
        /// <returns>True if valid, otherwise false</returns>
        public static bool IsCityValid(string city)
        {
            return cities.ContainsKey(city);
        }

        /// <summary>
        /// Get country from city
        /// </summary>
        /// <param name="city">City</param>
        /// <returns>Country of the city if successful, otherwise null</returns>
        public static Country GetCountry(string city)
        {
            Country ret = null;
            if (cities.ContainsKey(city))
            {
                ret = cities[city];
            }
            return ret;
        }

        /// <summary>
        /// Get full city name
        /// </summary>
        /// <param name="city">City</param>
        /// <returns>Full city name</returns>
        public static string GetFullCityName(string city)
        {
            string ret = city;
            Country country = GetCountry(city);
            if (country != null)
            {
                ret = city + ", " + country.Name + " (" + country.Code + ")";
            }
            return ret;
        }
    }
}
