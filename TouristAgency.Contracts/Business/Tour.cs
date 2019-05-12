using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class Tour
    {
        [DataMember]
        public int TourId { get; set; }

        [DataMember]
        public int TouristId { get; set; }

        [DataMember]
        public int HotelId { get; set; }

        [DataMember]
        public int TourTypeId { get; set; }
    }
}
