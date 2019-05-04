namespace TouristAgency.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tour")]
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            Feature = new HashSet<Feature>();
        }

        public int TourId { get; set; }

        public int TouristId { get; set; }

        public int HotelId { get; set; }

        public int TourTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feature> Feature { get; set; }

        public virtual Hotel Hotel { get; set; }

        public virtual Tourist Tourist { get; set; }

        public virtual TourType TourType { get; set; }
    }
}
