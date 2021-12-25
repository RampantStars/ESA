namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        public int ID { get; set; }

        public int CategoryID { get; set; }

        public int TypeID { get; set; }

        public int RegisterAgeID { get; set; }

        public int StatesID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string Site { get; set; }

        public string Poster { get; set; }

        public bool IsNew { get; set; }

        public int QuantityAll { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public bool IsFavourite { get; set; }

        public virtual Category Category { get; set; }

        public virtual RegisterAge RegisterAge { get; set; }

        public virtual States States { get; set; }

        public virtual Type Type { get; set; }
    }
}
