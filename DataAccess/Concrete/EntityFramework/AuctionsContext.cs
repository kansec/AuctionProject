using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class AuctionsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =(localdb)\MSSQLLocalDB;Database=AuctionsDb;Trusted_Connection=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<BodyStyle> BodyStyles { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<TransmissionType> TransmissionTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Bid> Bids { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("tbl_Cars");
            modelBuilder.Entity<Auction>().ToTable("tbl_Auctions");
            modelBuilder.Entity<BodyStyle>().ToTable("tbl_BodyStyles");
            modelBuilder.Entity<Colour>().ToTable("tbl_Colours");
            modelBuilder.Entity<Brand>().ToTable("tbl_Brands");
            modelBuilder.Entity<EngineType>().ToTable("tbl_EngineTypes");
            modelBuilder.Entity<Model>().ToTable("tbl_Models");
            modelBuilder.Entity<TransmissionType>().ToTable("tbl_TransmissionTypes");
            modelBuilder.Entity<User>().ToTable("tbl_Users");
            modelBuilder.Entity<OperationClaim>().ToTable("tbl_OperationClaims");
            modelBuilder.Entity<UserOperationClaim>().ToTable("tbl_UserOperationClaims");
            modelBuilder.Entity<Bid>().ToTable("tbl_Bids");



        }

    }
}
