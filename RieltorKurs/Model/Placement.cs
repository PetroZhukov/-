namespace RieltorKurs.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Placement")]
    public partial class Placement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Placement()
        {
            Realest_Placement = new HashSet<Realest_Placement>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public double? Square { get; set; }

        public double? CadastralValue { get; set; }

        public double? MarketValue { get; set; }

        public byte? Rooms { get; set; }

        public byte? Floors { get; set; }

        public int? Type_Placement_ID { get; set; }

        [StringLength(500)]
        public string Dascription { get; set; }

        public virtual Type_Placement Type_Placement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Realest_Placement> Realest_Placement { get; set; }
    }
}
