using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RieltorKurs.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Deal> Deal { get; set; }
        public virtual DbSet<Placement> Placement { get; set; }
        public virtual DbSet<Realest_Placement> Realest_Placement { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Type_Clients> Type_Clients { get; set; }
        public virtual DbSet<Type_Deal> Type_Deal { get; set; }
        public virtual DbSet<Type_Placement> Type_Placement { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Deal)
                .WithOptional(e => e.Clients)
                .HasForeignKey(e => e.Buyer_Tanant_ID);

            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Deal1)
                .WithOptional(e => e.Clients1)
                .HasForeignKey(e => e.Ourien_ID);

            modelBuilder.Entity<Deal>()
                .HasMany(e => e.Realest_Placement)
                .WithOptional(e => e.Deal)
                .HasForeignKey(e => e.Deal_ID);

            modelBuilder.Entity<Placement>()
                .HasMany(e => e.Realest_Placement)
                .WithOptional(e => e.Placement)
                .HasForeignKey(e => e.Placement_ID);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Roles)
                .HasForeignKey(e => e.Role_ID);

            modelBuilder.Entity<Type_Clients>()
                .HasMany(e => e.Clients)
                .WithOptional(e => e.Type_Clients1)
                .HasForeignKey(e => e.Type_Clients);

            modelBuilder.Entity<Type_Deal>()
                .HasMany(e => e.Deal)
                .WithOptional(e => e.Type_Deal1)
                .HasForeignKey(e => e.Type_Deal);

            modelBuilder.Entity<Type_Placement>()
                .HasMany(e => e.Placement)
                .WithOptional(e => e.Type_Placement)
                .HasForeignKey(e => e.Type_Placement_ID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Deal)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.Realtor_ID);
        }
    }
}
