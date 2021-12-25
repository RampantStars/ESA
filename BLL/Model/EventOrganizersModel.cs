namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EventOrganizersModel
    {
        public EventOrganizersModel(){}

        public EventOrganizersModel(EventOrganizers eventOrganizers)
        {
            this.EventID = eventOrganizers.EventID;
            this.OrganizerID = eventOrganizers.OrganizerID;
            this.ID = eventOrganizers.ID;
        }

        public int ID { get; set; }

        public int EventID { get; set; }

        public int OrganizerID { get; set; }

    }
}
