namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SessionModel
    {
        public SessionModel() { }
        public SessionModel(Session session)
        {
            this.EventOrganizersID = session.EventOrganizersID;
            this.Date = session.Date;
            this.ID = session.ID;
        }

        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int EventOrganizersID { get; set; }


    }
}
