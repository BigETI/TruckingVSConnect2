using System.Runtime.Serialization;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Found users data class
    /// </summary>
    [DataContract]
    public class FoundUsersData
    {
        /// <summary>
        /// Result
        /// </summary>
        [DataMember]
        string[] result;

        /// <summary>
        /// Result
        /// </summary>
        public string[] Result
        {
            get
            {
                if (result == null)
                {
                    result = new string[0];
                }
                return result;
            }
        }
    }
}
