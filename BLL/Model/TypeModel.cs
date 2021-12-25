namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TypeModel
    {
        public TypeModel() { }
        public TypeModel(DAL.EF.Type type)
        {
            this.ID = type.ID;
            this.Name = type.Name;
        }

        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

    }
}
