namespace BLL.Model
{
    using DAL.EF;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserModel
    {
        public UserModel() { }
        public UserModel(User user)
        {
            this.Login=user.Login;
            this.Password=user.Password;
            this.Money=user.Money;
            this.Photo=user.Photo;
            this.Age=user.Age;
            this.FName=user.FName;
            this.LName=user.LName;
            this.ID=user.ID;
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string FName { get; set; }

        [Required]
        [StringLength(20)]
        public string LName { get; set; }

        [Required]
        [StringLength(14)]
        public string Login { get; set; }

        [Required]
        [StringLength(14)]
        public string Password { get; set; }

        public string Photo { get; set; }

        public int Age { get; set; }

        [Column(TypeName = "money")]
        public decimal? Money { get; set; }

    }
}
