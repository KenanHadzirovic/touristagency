using System;
using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class TourType
    {
        [DataMember]
        public int TourTypeId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime DateFrom { get; set; }

        [DataMember]
        public DateTime DateTo { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public short? MaxTourists { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public bool PricePerDay { get; set; }
    }
}
