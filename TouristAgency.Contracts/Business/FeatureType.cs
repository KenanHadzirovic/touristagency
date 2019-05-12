using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class FeatureType
    {
        [DataMember]
        public int FeatureTypeId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

    }
}
