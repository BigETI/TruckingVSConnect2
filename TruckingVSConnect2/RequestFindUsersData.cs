using System.Runtime.Serialization;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Request find users data class
    /// </summary>
    [DataContract]
    public class RequestFindUsersData
    {
        /// <summary>
        /// Filter
        /// </summary>
        [DataMember]
        private string filter;

        /// <summary>
        /// Filter
        /// </summary>
        public string Filter
        {
            get
            {
                return filter;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filter">Filter</param>
        public RequestFindUsersData(string filter)
        {
            this.filter = filter;
        }
    }
}
