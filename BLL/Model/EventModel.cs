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
            this.Price =(int)@event.Price;
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

            switch (TypeID)
            {
                case 1:
                    TypeIcon = "VideoVintage";
                    break;
                case 2:
                    TypeIcon = "Theater";
                    break;
                case 3:
                    TypeIcon = "GuitarElectric";
                    break;
                case 4:
                    TypeIcon = "DramaMasks";
                    break;
                case 5:
                    TypeIcon = "DanceBallroom";
                    break;
            }

            switch (StatesID)
            {
                case 1:
                    ColorBorder = "#FFAF50";
                        break;
                case 2:
                    ColorBorder = "#BEF761";
                    break;
                case 3:
                    ColorBorder = "#E6E7E8";
                    break;
                case 4:
                    ColorBorder = "#FF756B";
                    break;
            }

            if (IsNew)
                IsNewText = "NEW";
            else IsNewText = "";


        }


        public string IsNewText { get; set; }
        public string ColorBorder { get; set; }
        public string TypeIcon { get; set; }
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

        [Column(TypeName = "int")]
        public int Price { get; set; }

        public bool IsFavourite { get; set; }


    }
}
