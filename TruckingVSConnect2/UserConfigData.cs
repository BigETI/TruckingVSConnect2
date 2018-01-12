using System.Runtime.Serialization;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// User configuration data class
    /// </summary>
    [DataContract]
    public class UserConfigData
    {
        /// <summary>
        /// Following
        /// </summary>
        [DataMember]
        private string[] following = new string[0];

        /// <summary>
        /// Following
        /// </summary>
        public string[] Following
        {
            get
            {
                if (following == null)
                {
                    following = new string[0];
                }
                return following;
            }
            set
            {
                if (value != null)
                {
                    following = value;
                }
            }
        }
    }
}
