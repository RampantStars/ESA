namespace BLL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            UserSessions = new HashSet<UserSessions>();
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

        public byte[] Photo { get; set; }

        public int Age { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSessions> UserSessions { get; set; }
    }
}
