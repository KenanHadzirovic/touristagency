using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class Privilege
    {
        [DataMember]
        public int PrivilegeId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
