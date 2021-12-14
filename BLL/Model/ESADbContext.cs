using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BLL.Model
{
    public partial class ESADbContext : DbContext
    {
        public ESADbContext()
            : base("name=ESADbContext")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventOrganizers> EventOrganizers { get; set; }
        public virtual DbSet<Organizer> Organizer { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<RegisterAge> RegisterAge { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserSessions> UserSessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Event)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EventOrganizers>()
                .HasMany(e => e.Session)
                .WithRequired(e => e.EventOrganizers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organizer>()
                .HasMany(e => e.EventOrganizers)
                .WithRequired(e => e.Organizer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Place>()
                .HasMany(e => e.Organizer)
                .WithRequired(e => e.Place)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegisterAge>()
                .HasMany(e => e.Event)
                .WithRequired(e => e.RegisterAge)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Session>()
                .HasMany(e => e.UserSessions)
                .WithRequired(e => e.Session)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<States>()
                .HasMany(e => e.Event)
                .WithRequired(e => e.States)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.Event)
                .WithRequired(e => e.Type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserSessions)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
