namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public partial class EventModel
    {
        public EventModel() { }

        public EventModel(Event @event)
        {
            this.ID = @event.ID;
            this.IsFavourite = @event.IsFavourite;
            this.Price = @event.Price;
            this.Description = @event.Description;
            this.IsNew = @event.IsNew;
            this.CategoryID = @event.CategoryID;
            this.QuantityAll = @event.QuantityAll;
            this.Site = @event.Site;
            this.Title = @event.Title;
            this.Poster = @event.Poster;
            this.RegisterAgeID = @event.RegisterAgeID;
            this.TypeID = @event.TypeID;
            this.StatesID = @event.StatesID;

        }
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

       
    }
}
