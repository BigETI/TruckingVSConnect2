using System.Collections.Generic;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² Updater namespace
/// </summary>
namespace TruckingVSConnect2Updater
{
    /// <summary>
    /// Translator interface class
    /// </summary>
    public class TranslatorInterface : ITranslatorInterface
    {
        /// <summary>
        /// Languages
        /// </summary>
        private readonly Language[] languages = new[] { new Language("ENGLISH", "en-GB"), new Language("GERMAN", "de-DE") };

        /// <summary>
        /// Language
        /// </summary>
        public string Language
        {
            get
            {
                return Configuration.Language;
            }
            set
            {
                Configuration.Language = value;
            }
        }

        /// <summary>
        /// Fallback language
        /// </summary>
        public string FallbackLanguage
        {
            get
            {
                return "en-GB";
            }
        }

        /// <summary>
        /// Assembly name
        /// </summary>
        public string AssemblyName
        {
            get
            {
                return "TruckingVSConnect2Updater";
            }
        }

        /// <summary>
        /// Languages
        /// </summary>
        public IEnumerable<Language> Languages
        {
            get
            {
                return languages;
            }
        }

        /// <summary>
        /// Save settings
        /// </summary>
        public void SaveSettings()
        {
            //
        }
    }
}
