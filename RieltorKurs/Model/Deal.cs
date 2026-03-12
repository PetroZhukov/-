namespace RieltorKurs.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Deal")]
    public partial class Deal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Deal()
        {
            Realest_Placement = new HashSet<Realest_Placement>();
        }

        public int ID { get; set; }

        public int? Ourien_ID { get; set; }

        public int? Realtor_ID { get; set; }

        public int? Buyer_Tanant_ID { get; set; }

        public double? CostPerMonth { get; set; }

        public int? Type_Deal { get; set; }

        public double? Comission { get; set; }

        public virtual Clients Clients { get; set; }

        public virtual Clients Clients1 { get; set; }

        public virtual Type_Deal Type_Deal1 { get; set; }

        public virtual Users Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Realest_Placement> Realest_Placement { get; set; }
    }
}
