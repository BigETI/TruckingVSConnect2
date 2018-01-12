using System.Runtime.Serialization;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Request GetUsers data class
    /// </summary>
    [DataContract]
    public class RequestGetUsersData
    {
        /// <summary>
        /// User data
        /// </summary>
        [DataMember]
        private UserData userData;

        /// <summary>
        /// Users
        /// </summary>
        [DataMember]
        private string[] users;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userData">User data</param>
        /// <param name="users">Users</param>
        public RequestGetUsersData(UserData userData, string[] users)
        {
            this.userData = userData;
            this.users = users;
        }
    }
}
