using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        public int HotelId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public short Stars { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Website { get; set; }
    }
}
