namespace RieltorKurs.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Realest_Placement
    {
        public int ID { get; set; }

        public int? Deal_ID { get; set; }

        public int? Placement_ID { get; set; }

        public virtual Deal Deal { get; set; }

        public virtual Placement Placement { get; set; }
    }
}
