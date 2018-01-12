using System.Runtime.Serialization;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Users data class
    /// </summary>
    [DataContract]
    public class UsersData
    {
        /// <summary>
        /// Result
        /// </summary>
        [DataMember]
        private UserData[] result;

        /// <summary>
        /// Result
        /// </summary>
        public UserData[] Result
        {
            get
            {
                return result;
            }
        }
    }
}
