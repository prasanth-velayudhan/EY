using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace flydubai.Model
{
    using System.Globalization;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Airport Extensions
    /// </summary>
    public static class AirportExtensions
    {
        /// <summary>
        /// Names the specified airport.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string Name(this Airport airport)
        {
            return airport.CurrentLocale() == null ? string.Empty : airport.CurrentLocale().AirportName;
        }



        /// <summary>
        /// Names in english.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string NameEnglish(this Airport airport)
        {
            return airport.Localised.SingleOrDefault(l => l.Language == "en").AirportName;
        }

        /// <summary>
        /// Names the specified airport.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <param name="name">The name.</param>
        public static void Name(this Airport airport, string name)
        {
            if (airport.CurrentLocale() == null)
            {
                airport.Localised.Add(new AirportLocalised
                                          {
                                              AirportCode = airport.AirportCode,
                                              Language = System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName
                                          });
            }

            airport.CurrentLocale().AirportName = name;
        }

        /// <summary>
        /// Countries the specified airport.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string Country(this Airport airport)
        {
            return airport.CurrentLocale() == null ? string.Empty : airport.CurrentLocale().CountryLocalised.Name;
        }

        /// <summary>
        /// Cities the specified airport.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string City(this Airport airport)
        {
            return airport.CurrentLocale() == null ? string.Empty : airport.CurrentLocale().City;
        }

        /// <summary>
        /// Countries the english.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string CountryEnglish(this Airport airport)
        {
            return airport.Country.GetLocalisedCountry("en").Name;
        }

        /// <summary>
        /// Cities the english.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string CityEnglish(this Airport airport)
        {
            return airport.Localised.SingleOrDefault(l => l.Language == "en").City;
        }
        ///* START - FR-020 FR-021 FR-019 (A- 5484) */
        /// <summary>
        /// Airports the label.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string AirportLabel(this Airport airport)
        {
            return string.Format("{0} ({1}) - {2}", Name(airport), airport.AirportCode, City(airport));
        }
        /* END - FR-020 FR-021 FR-019 (A- 5484) */

        /// <summary>
        /// Airports the short label.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string AirportShortLabel(this Airport airport, bool isMetro = false)
        {
            return string.Format("{0} ({1})", City(airport), isMetro ? airport.MetroCode : airport.AirportCode);
        }

        /// <summary>
        /// Airports the short label.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string AirportMetroShortLabel(this Airport airport)
        {
            return string.Format("{0} ({1})", City(airport), airport.MetroCode);
        }

        //IBS Multi city search
        public static string MetroShortLabel(this AirportLocalised airport, string metroCode)
        {
            return string.Format("{0} ({1})", airport.MetroName, metroCode);
        }

        public static string AirportShortLabel(this AirportLocalised airport)
        {
            return string.Format("{0} ({1})", airport.City, airport.AirportCode);
        }
        /* START - FR-020 FR-021 FR-019 (A- 5484) */
        /// <summary>
        /// Airports the label.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string AirportLabel(this AirportLocalised airport)
        {
            return string.Format("{0}({1}) - {2}", airport.AirportName, airport.AirportCode, airport.City);
        }

        /// <summary>
        /// Airports the label.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string AirportShortDescription(this AirportLocalised airport)
        {
            return string.Format("{0} ({1}) - {2}", airport.AirportName, airport.AirportCode, airport.City);

        }
        /* END - FR-020 FR-021 FR-019 (A- 5484) */

        /// <summary>
        /// Gets the current local time.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static DateTime GetCurrentLocalTime(this Airport airport)
        {
            return DateTime.UtcNow.Add(airport.GetUtcOffset());
        }

        /// <summary>
        /// Currents the locale.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static AirportLocalised CurrentLocale(this Airport airport)
        {
            if (airport.Localised != null)
            {
                return airport.Localised.Where(x => x.Language == System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        /* START - Metro Search */
        /// <summary>
        /// Metro the english.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string MetroEnglish(this Airport airport)
        {
            string metroname = airport.Localised.SingleOrDefault(l => l.Language == "en").MetroName;
            return string.IsNullOrEmpty(metroname) ? string.Empty : metroname;
        }

        /// <summary>
        /// Metro the label.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string MetroLabel(this AirportLocalised airport)
        {
            return string.Format("{0} ({1}) - {2}", airport.MetroName, airport.Airport.MetroCode, airport.City);
        }

        /// <summary>
        /// Metro the label.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string MetroShortDescription(this AirportLocalised airport)
        {
            return string.Format("{0}({1}) - {2}", airport.MetroName, airport.Airport.MetroCode, airport.City);

        }
        /// <summary>
        /// Metro name.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static string MetroNameLocalised(this Airport airport)
        {
            return airport.CurrentLocale() == null ? string.Empty : airport.CurrentLocale().MetroName;
        }

        /// <summary>
        /// Localised airport.
        /// </summary>
        /// <param name="airport">The airport.</param>
        /// <returns></returns>
        public static AirportLocalised LocalisedAirport(this Airport airport)
        {
            return airport.CurrentLocale() == null ? null : airport.CurrentLocale();
        }
        /* END - Metro Search */
    }
}
