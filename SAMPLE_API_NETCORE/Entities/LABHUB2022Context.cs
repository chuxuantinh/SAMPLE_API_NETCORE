using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class LABHUB2022Context : DbContext
    {
        public LABHUB2022Context()
        {
        }

        public LABHUB2022Context(DbContextOptions<LABHUB2022Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Chemical> Chemicals { get; set; } = null!;
        public virtual DbSet<ClassSubject> ClassSubjects { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Device> Devices { get; set; } = null!;
        public virtual DbSet<DeviceSpec> DeviceSpecs { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<LabTest> LabTests { get; set; } = null!;
        public virtual DbSet<LaboratoryLocation> LaboratoryLocations { get; set; } = null!;
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; } = null!;
        public virtual DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; } = null!;
        public virtual DbSet<PurchaseOrderLineChemical> PurchaseOrderLineChemicals { get; set; } = null!;
        public virtual DbSet<RepairDetail> RepairDetails { get; set; } = null!;
        public virtual DbSet<RepairType> RepairTypes { get; set; } = null!;
        public virtual DbSet<Reseacher> Reseachers { get; set; } = null!;
        public virtual DbSet<StudySession> StudySessions { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserGroup> UserGroups { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-CCFGULQ\\CT;user=sa;password=chuttinh;database=LAB-HUB-2022");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chemical>(entity =>
            {
                entity.Property(e => e.ChemicalName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.DateAdded).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.Notes).HasMaxLength(2000);

                entity.Property(e => e.Origin)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Specifications).HasMaxLength(500);
            });

            modelBuilder.Entity<ClassSubject>(entity =>
            {
                entity.ToTable("ClassSubject");

                entity.Property(e => e.ClassSubjectId).HasMaxLength(50);

                entity.Property(e => e.ClassSubject1)
                    .HasMaxLength(500)
                    .HasColumnName("ClassSubject");

                entity.Property(e => e.Semester).HasMaxLength(50);

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TeacherName).HasMaxLength(50);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Department");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.DepaartmentId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepaartmentName).HasMaxLength(200);

                entity.Property(e => e.DepaartmentSymbol)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.ToDate).HasColumnType("date");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("Device");

                entity.Property(e => e.Configuration).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.DateAdded).HasColumnType("date");

                entity.Property(e => e.DateOfPurchase).HasColumnType("date");

                entity.Property(e => e.DeviceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeviceModel).HasMaxLength(100);

                entity.Property(e => e.DeviceName).HasMaxLength(200);

                entity.Property(e => e.DeviceNameEnglish).HasMaxLength(200);

                entity.Property(e => e.DeviceSeria).HasMaxLength(100);

                entity.Property(e => e.Guarantee).HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.NewCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes).HasMaxLength(2000);

                entity.Property(e => e.PurchaseContract).HasMaxLength(500);
            });

            modelBuilder.Entity<DeviceSpec>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeviceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeviceCodePrivate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DeviceCode_Private")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employee");

                entity.Property(e => e.AddressCurrent)
                    .HasMaxLength(200)
                    .HasColumnName("Address_current");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.IdEmp)
                    .HasMaxLength(50)
                    .HasColumnName("Id_emp");
            });

            modelBuilder.Entity<LabTest>(entity =>
            {
                entity.HasKey(e => e.TestId);

                entity.ToTable("LabTest");

                entity.Property(e => e.TestId).ValueGeneratedNever();

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TestName).HasMaxLength(500);
            });

            modelBuilder.Entity<LaboratoryLocation>(entity =>
            {
                entity.HasKey(e => e.LabId);

                entity.ToTable("LaboratoryLocation");

                entity.Property(e => e.LabId).HasMaxLength(50);

                entity.Property(e => e.LabName).HasMaxLength(500);

                entity.Property(e => e.Localtion).HasMaxLength(500);

                entity.Property(e => e.Notes).HasMaxLength(500);
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.ToTable("PurchaseOrder");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrder_Supplier");
            });

            modelBuilder.Entity<PurchaseOrderLine>(entity =>
            {
                entity.ToTable("PurchaseOrderLine");

                entity.HasOne(d => d.DeviceCodeNavigation)
                    .WithMany(p => p.PurchaseOrderLines)
                    .HasForeignKey(d => d.DeviceCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderLine_Device");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderLines)
                    .HasForeignKey(d => d.PurchaseOrderId);
            });

            modelBuilder.Entity<PurchaseOrderLineChemical>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderLineChemId);

                entity.ToTable("PurchaseOrderLine_Chemical");

                entity.Property(e => e.PurchaseOrderLineChemId).HasColumnName("PurchaseOrderLine_ChemId");

                entity.HasOne(d => d.Chemical)
                    .WithMany(p => p.PurchaseOrderLineChemicals)
                    .HasForeignKey(d => d.ChemicalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderLine_Chemical_Chemicals");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderLineChemicals)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrderLine_Chemical_PurchaseOrder");
            });

            modelBuilder.Entity<RepairDetail>(entity =>
            {
                entity.Property(e => e.AddressOfRepair).HasMaxLength(500);

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.DateOfRepair).HasColumnType("date");

                entity.Property(e => e.NextDateOfRepair).HasColumnType("date");

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.RepairDetails)
                    .HasForeignKey(d => d.DeviceId)
                    .HasConstraintName("FK_RepairDetails_Device");

                entity.HasOne(d => d.TypeOfRepairNavigation)
                    .WithMany(p => p.RepairDetails)
                    .HasForeignKey(d => d.TypeOfRepair)
                    .HasConstraintName("FK_RepairDetails_RepairType");
            });

            modelBuilder.Entity<RepairType>(entity =>
            {
                entity.ToTable("RepairType");

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.TypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<Reseacher>(entity =>
            {
                entity.ToTable("Reseacher");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Organization).HasMaxLength(50);

                entity.Property(e => e.Phone).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<StudySession>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StudySession");

                entity.Property(e => e.DateExperiment).HasColumnType("datetime");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.SubjectId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubjectName).HasMaxLength(500);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.SuplierId);

                entity.ToTable("Supplier");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Support).HasMaxLength(500);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Department).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("('MEMBER')");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserType)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.ToTable("UserGroup");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("UserLogin");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.GroupId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GroupID");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_UserLogin_UserGroup");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
