using System;
using System.Runtime.Serialization;

namespace TouristAgency.Contracts
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public int UserId { get; set; }
    }
}
