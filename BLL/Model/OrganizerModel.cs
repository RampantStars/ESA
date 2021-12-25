namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organizer")]
    public partial class OrganizerModel
    {
        public OrganizerModel() { }
        public OrganizerModel(Organizer organizer)
        {
            this.Login = organizer.Login;
            this.Password = organizer.Password;
            this.Site = organizer.Site;
            this.ID = organizer.ID;
            this.PlaceID = organizer.PlaceID;
            this.Name = organizer.Name;
        }



        public int ID { get; set; }

        public int PlaceID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Site { get; set; }

        [Required]
        [StringLength(25)]
        public string Login { get; set; }

        [Required]
        [StringLength(25)]
        public string Password { get; set; }

    }
}
