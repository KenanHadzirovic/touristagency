﻿using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public Employee Employee { get; set; }
    }
}
