namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegisterAge")]
    public partial class RegisterAgeModel
    {
        public RegisterAgeModel() { }
        public RegisterAgeModel(RegisterAge registerAge)
        {
            this.Age = registerAge.Age;
            this.ID = registerAge.ID;
        }

        public int ID { get; set; }

        public int Age { get; set; }


    }
}
