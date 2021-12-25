namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CategoryModel
    {
        public CategoryModel() { }
        public CategoryModel(Category category)
        {
            this.Name = category.Name;
            this.ID = category.ID;
        }

        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }


    }
}
