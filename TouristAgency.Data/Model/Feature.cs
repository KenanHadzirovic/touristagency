namespace TouristAgency.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feature")]
    public partial class Feature
    {
        public int FeatureId { get; set; }

        [Column("Feature")]
        [Required]
        [StringLength(50)]
        public string Feature1 { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Price { get; set; }

        public int TourId { get; set; }

        public int FeatureTypeId { get; set; }

        public int TouristId { get; set; }

        public int HotelId { get; set; }

        public int TourTypeId { get; set; }

        public virtual FeatureType FeatureType { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
