using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class UserAccount
    {
        [DataMember]
        public int UserAccountId { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public Employee Employee { get; set; }
    }
}
