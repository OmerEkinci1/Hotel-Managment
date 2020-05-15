using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Model
{
    public partial class OtelProjeContext : DbContext
    {
        public OtelProjeContext()
        {
        }

        public OtelProjeContext(DbContextOptions<OtelProjeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblAnnouncement> TblAnnouncement { get; set; }
        public virtual DbSet<TblCafe> TblCafe { get; set; }
        public virtual DbSet<TblCase> TblCase { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
        public virtual DbSet<TblReservation> TblReservation { get; set; }
        public virtual DbSet<TblRoom> TblRoom { get; set; }
        public virtual DbSet<TblService> TblService { get; set; }
        public virtual DbSet<TblStock> TblStock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-U7NMENG\\SQLEXPRESS;Initial Catalog=OtelProje;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.ToTable("Tbl_Admin");

                entity.Property(e => e.AdmimPasword)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdminAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AdminBornDate)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdminName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdminPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdminPosition)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdminSalary)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdminStartDate)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AdminSurname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdminTc)
                    .HasColumnName("AdminTC")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.AdminUsername)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAnnouncement>(entity =>
            {
                entity.ToTable("Tbl_Announcement");

                entity.Property(e => e.Announcement)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCafe>(entity =>
            {
                entity.ToTable("Tbl_Cafe");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSurname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCafe)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Tbl_Cafe_Tbl_Customer");
            });

            modelBuilder.Entity<TblCase>(entity =>
            {
                entity.ToTable("Tbl_Case");

                entity.Property(e => e.Fee)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Move)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cafe)
                    .WithMany(p => p.TblCase)
                    .HasForeignKey(d => d.CafeId)
                    .HasConstraintName("FK_Tbl_Case_Tbl_Cafe");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblCase)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Tbl_Case_Tbl_Category");

                entity.HasOne(d => d.Reservation)
                    .WithMany(p => p.TblCase)
                    .HasForeignKey(d => d.ReservationId)
                    .HasConstraintName("FK_Tbl_Case_Tbl_Reservation");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TblCase)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_Tbl_Case_Tbl_Service");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.TblCase)
                    .HasForeignKey(d => d.StockId)
                    .HasConstraintName("FK_Tbl_Case_Tbl_Stock");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("Tbl_Category");

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Tbl_Customer");

                entity.Property(e => e.CustomerBornDate)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerMedeni)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPassword)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSurname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTc)
                    .HasColumnName("CustomerTC")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUsername)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblReservation>(entity =>
            {
                entity.ToTable("Tbl_Reservation");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSurname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EnterDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveDate).HasColumnType("datetime");

                entity.Property(e => e.ReservFee)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RoomSituation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblReservation)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Tbl_Reservation_Tbl_Customer");
            });

            modelBuilder.Entity<TblRoom>(entity =>
            {
                entity.ToTable("Tbl_Room");

                entity.Property(e => e.Capacity)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RoomNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RoomSituation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoomView)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.ToTable("Tbl_Service");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSurname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceFee)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblService)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Tbl_Service_Tbl_Customer");
            });

            modelBuilder.Entity<TblStock>(entity =>
            {
                entity.ToTable("Tbl_Stock");

                entity.Property(e => e.Amount)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
