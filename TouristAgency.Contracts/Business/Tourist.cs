﻿using System;
using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class Tourist
    {
        [DataMember]
        public int TouristId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string SSN { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}
