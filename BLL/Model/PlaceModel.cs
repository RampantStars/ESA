namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Place")]
    public partial class PlaceModel
    {
        public PlaceModel() { }
        public PlaceModel(Place place)
        {
            this.ID = place.ID;
            this.Adress = place.Adress;
        }

        public int ID { get; set; }

        [Required]
        public string Adress { get; set; }


    }
}
