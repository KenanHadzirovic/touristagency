using System;
using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class Feature
    {
        [DataMember]
        public string FeatureName { get; set; }

        [DataMember]
        public DateTime DateTime { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public FeatureType FeatureType { get; set; }
    }
}
