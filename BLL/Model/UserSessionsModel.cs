namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserSessionsModel
    {
        public UserSessionsModel() { }
        public UserSessionsModel(UserSessions userSessions)
        {
            this.UserID = userSessions.UserID;
            this.SessionID = userSessions.SessionID;
            this.Quantity = userSessions.Quantity;
            this.ID = userSessions.ID;
        }

        public int ID { get; set; }

        public int SessionID { get; set; }

        public int UserID { get; set; }

        public int? Quantity { get; set; }

    }
}
