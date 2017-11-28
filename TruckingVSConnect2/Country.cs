using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Country class
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Country name
        /// </summary>
        private string name;

        /// <summary>
        /// Country code
        /// </summary>
        private string code;

        /// <summary>
        /// Country name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Country code
        /// </summary>
        public string Code
        {
            get
            {
                return code;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        private Country()
        {
            //
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Country name</param>
        /// <param name="code">Country code</param>
        public Country(string name, string code)
        {
            this.name = Translator.GetTranslation(name);
            this.code = code;
        }
    }
}
