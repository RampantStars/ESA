namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StatesModel
    {
        public StatesModel() { }
        public StatesModel(States states)
        {
            this.ID = states.ID;
            this.State = states.State;
        }

        public int ID { get; set; }

        [Required]
        [StringLength(14)]
        public string State { get; set; }

    }
}
