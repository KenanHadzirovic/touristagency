namespace TouristAgency.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolePrivilege")]
    public partial class RolePrivilege
    {
        public int RolePrivilegeId { get; set; }

        public int PrivilegeId { get; set; }

        public int RoleId { get; set; }

        public virtual Privilege Privilege { get; set; }

        public virtual Role Role { get; set; }
    }
}
