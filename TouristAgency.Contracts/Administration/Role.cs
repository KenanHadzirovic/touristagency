using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class Role
    {
        [DataMember]
        public int RoleId { get; set; }

        [DataMember]
        public string RoleName { get; set; }
    }
}
