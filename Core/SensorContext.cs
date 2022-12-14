using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Core
{
    public partial class SensorContext : DbContext
    {
        public SensorContext()
        {
        }

        public SensorContext(DbContextOptions<SensorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActuationType> ActuationType { get; set; }
        public virtual DbSet<CardanShaftType> CardanShaftType { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanySub> CompanySub { get; set; }
        public virtual DbSet<CompanyUnit> CompanyUnit { get; set; }
        public virtual DbSet<CompanyUnitSector> CompanyUnitSector { get; set; }
        public virtual DbSet<CompanyUser> CompanyUser { get; set; }
        public virtual DbSet<Compressor> Compressor { get; set; }
        public virtual DbSet<CompressorType> CompressorType { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Coupling> Coupling { get; set; }
        public virtual DbSet<CouplingType> CouplingType { get; set; }
        public virtual DbSet<Dados> Dados { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<DeviceMeasure> DeviceMeasure { get; set; }
        public virtual DbSet<ExhaustFan> ExhaustFan { get; set; }
        public virtual DbSet<FixationType> FixationType { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<Motor> Motor { get; set; }
        public virtual DbSet<Pulley> Pulley { get; set; }
        public virtual DbSet<PulleyType> PulleyType { get; set; }
        public virtual DbSet<Pump> Pump { get; set; }
        public virtual DbSet<PumpType> PumpType { get; set; }
        public virtual DbSet<Reducer> Reducer { get; set; }
        public virtual DbSet<Ring> Ring { get; set; }
        public virtual DbSet<RingType> RingType { get; set; }
        public virtual DbSet<StageType> StageType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=Rick@159989;database=mydb");
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=wA4Sx_3MB42nyuQe;database=sensordb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActuationType>(entity =>
            {
                entity.ToTable("actuation_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<CardanShaftType>(entity =>
            {
                entity.ToTable("cardan_shaft_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasColumnName("cnpj")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.LegalName)
                    .HasColumnName("legal_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TradeName)
                    .IsRequired()
                    .HasColumnName("trade_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanySub>(entity =>
            {
                entity.ToTable("company_sub");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate).HasColumnName("create_date");

                entity.Property(e => e.IdCompany).HasColumnName("id_company");

                entity.Property(e => e.IdCompanySub).HasColumnName("id_company_sub");
            });

            modelBuilder.Entity<CompanyUnit>(entity =>
            {
                entity.ToTable("company_unit");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("fk_company_unit_company1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyUnit)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_company_unit_company1");
            });

            modelBuilder.Entity<CompanyUnitSector>(entity =>
            {
                entity.ToTable("company_unit_sector");

                entity.HasIndex(e => e.CompanyUnitId)
                    .HasName("fk_company_unit_sector_company_unit1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyUnitId).HasColumnName("company_unit_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.CompanyUnit)
                    .WithMany(p => p.CompanyUnitSector)
                    .HasForeignKey(d => d.CompanyUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_company_unit_sector_company_unit1");
            });

            modelBuilder.Entity<CompanyUser>(entity =>
            {
                entity.ToTable("company_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate).HasColumnName("create_date");

                entity.Property(e => e.IdCompany).HasColumnName("id_company");

                entity.Property(e => e.IdUser).HasColumnName("id_user");
            });

            modelBuilder.Entity<Compressor>(entity =>
            {
                entity.ToTable("compressor");

                entity.HasIndex(e => e.ActuationTypeId)
                    .HasName("fk_compressor_actuation_type1_idx");

                entity.HasIndex(e => e.CardanShaftTypeId)
                    .HasName("fk_compressor_cardan_shaft_type1_idx");

                entity.HasIndex(e => e.CouplingId)
                    .HasName("fk_compressor_coupling1_idx");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("fk_compressor_device1_idx");

                entity.HasIndex(e => e.FixationTypeId)
                    .HasName("fk_compressor_fixation_type1_idx");

                entity.HasIndex(e => e.MachineId)
                    .HasName("fk_compressor_equipment1_idx");

                entity.HasIndex(e => e.PulleyId)
                    .HasName("fk_compressor_pulley1_idx");

                entity.HasIndex(e => e.RingId)
                    .HasName("fk_compressor_ring1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActuationTypeId).HasColumnName("actuation_type_id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CardanShaftTypeId).HasColumnName("cardan_shaft_type_id");

                entity.Property(e => e.CouplingId).HasColumnName("coupling_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .HasColumnType("json");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.FixationTypeId).HasColumnName("fixation_type_id");

                entity.Property(e => e.MachineId).HasColumnName("machine_id");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PulleyId).HasColumnName("pulley_id");

                entity.Property(e => e.RingId).HasColumnName("ring_id");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.ActuationType)
                    .WithMany(p => p.Compressor)
                    .HasForeignKey(d => d.ActuationTypeId)
                    .HasConstraintName("fk_compressor_actuation_type1");

                entity.HasOne(d => d.CardanShaftType)
                    .WithMany(p => p.Compressor)
                    .HasForeignKey(d => d.CardanShaftTypeId)
                    .HasConstraintName("fk_compressor_cardan_shaft_type1");

                entity.HasOne(d => d.Coupling)
                    .WithMany(p => p.Compressor)
                    .HasForeignKey(d => d.CouplingId)
                    .HasConstraintName("fk_compressor_coupling1");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Compressor)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_compressor_device1");

                entity.HasOne(d => d.FixationType)
                    .WithMany(p => p.Compressor)
                    .HasForeignKey(d => d.FixationTypeId)
                    .HasConstraintName("fk_compressor_fixation_type1");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Compressor)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_compressor_equipment1");

                entity.HasOne(d => d.Pulley)
                    .WithMany(p => p.Compressor)
                    .HasForeignKey(d => d.PulleyId)
                    .HasConstraintName("fk_compressor_pulley1");

                entity.HasOne(d => d.Ring)
                    .WithMany(p => p.Compressor)
                    .HasForeignKey(d => d.RingId)
                    .HasConstraintName("fk_compressor_ring1");
            });

            modelBuilder.Entity<CompressorType>(entity =>
            {
                entity.ToTable("compressor_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("fk_contact_company1_idx");

                entity.HasIndex(e => e.ManagedBy)
                    .HasName("fk_contact_contact1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.Cpf)
                    .HasColumnName("cpf")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.ManagedBy)
                    .HasColumnName("managed_by")
                    .HasComment("Another contact_id");

                entity.Property(e => e.Rg)
                    .HasColumnName("rg")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contact_company1");

                entity.HasOne(d => d.ManagedByNavigation)
                    .WithMany(p => p.InverseManagedByNavigation)
                    .HasForeignKey(d => d.ManagedBy)
                    .HasConstraintName("fk_contact_contact1");
            });

            modelBuilder.Entity<Coupling>(entity =>
            {
                entity.ToTable("coupling");

                entity.HasIndex(e => e.CouplingTypeId)
                    .HasName("fk_coupling_coupling_type1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CouplingTypeId).HasColumnName("coupling_type_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.CouplingType)
                    .WithMany(p => p.Coupling)
                    .HasForeignKey(d => d.CouplingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_coupling_coupling_type1");
            });

            modelBuilder.Entity<CouplingType>(entity =>
            {
                entity.ToTable("coupling_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Dados>(entity =>
            {
                entity.ToTable("dados");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("fk_dados_device1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("json");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Dados)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_dados_device1");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("device");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("fk_device_company1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Axies).HasColumnName("axies");

                entity.Property(e => e.Battery)
                    .HasColumnName("battery")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bdr)
                    .HasColumnName("bdr")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cutoff)
                    .HasColumnName("cutoff")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.Lines).HasColumnName("lines");

                entity.Property(e => e.Lpf).HasColumnName("lpf");

                entity.Property(e => e.Rms)
                    .HasColumnName("rms")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Temperature).HasColumnName("temperature");

                entity.Property(e => e.RmsMax)
                    .HasColumnName("rmsmax")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RmsMin)
                    .HasColumnName("rmsmin")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Device)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_device_company1");
            });

            modelBuilder.Entity<DeviceMeasure>(entity =>
            {
                entity.ToTable("device_measure");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.MotorId).HasColumnName("motor_id");

                entity.Property(e => e.ReadDataType)
                    .IsRequired()
                    .HasColumnName("read_data_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Temperature)
                    .IsRequired()
                    .HasColumnName("temperature")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.XAxle)
                    .IsRequired()
                    .HasColumnName("x_axle")
                    .HasColumnType("longtext");

                entity.Property(e => e.YAxle)
                    .IsRequired()
                    .HasColumnName("y_axle")
                    .HasColumnType("longtext");

                entity.Property(e => e.ZAxle)
                    .IsRequired()
                    .HasColumnName("z_axle")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<ExhaustFan>(entity =>
            {
                entity.ToTable("exhaust_fan");

                entity.HasIndex(e => e.ActuationTypeId)
                    .HasName("fk_exhaust_fan_actuation_type1_idx");

                entity.HasIndex(e => e.CardanShaftTypeId)
                    .HasName("fk_exhaust_fan_cardan_shaft_type1_idx");

                entity.HasIndex(e => e.CouplingId)
                    .HasName("fk_exhaust_fan_coupling1_idx");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("fk_exhaust_fan_device1_idx");

                entity.HasIndex(e => e.FixationTypeId)
                    .HasName("fk_exhaust_fan_fixation_type1_idx");

                entity.HasIndex(e => e.MachineId)
                    .HasName("fk_exhaust_fan_equipment1_idx");

                entity.HasIndex(e => e.PulleyId)
                    .HasName("fk_exhaust_fan_pulley1_idx");

                entity.HasIndex(e => e.RingId)
                    .HasName("fk_exhaust_fan_ring1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActuationTypeId).HasColumnName("actuation_type_id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CardanShaftTypeId).HasColumnName("cardan_shaft_type_id");

                entity.Property(e => e.CouplingId).HasColumnName("coupling_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.FixationTypeId).HasColumnName("fixation_type_id");

                entity.Property(e => e.MachineId).HasColumnName("machine_id");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfBlades).HasColumnName("number_of_blades");

                entity.Property(e => e.PulleyId).HasColumnName("pulley_id");

                entity.Property(e => e.RingId).HasColumnName("ring_id");

                entity.Property(e => e.RotorDiameter).HasColumnName("rotor_diameter");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.ActuationType)
                    .WithMany(p => p.ExhaustFan)
                    .HasForeignKey(d => d.ActuationTypeId)
                    .HasConstraintName("fk_exhaust_fan_actuation_type1");

                entity.HasOne(d => d.CardanShaftType)
                    .WithMany(p => p.ExhaustFan)
                    .HasForeignKey(d => d.CardanShaftTypeId)
                    .HasConstraintName("fk_exhaust_fan_cardan_shaft_type1");

                entity.HasOne(d => d.Coupling)
                    .WithMany(p => p.ExhaustFan)
                    .HasForeignKey(d => d.CouplingId)
                    .HasConstraintName("fk_exhaust_fan_coupling1");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.ExhaustFan)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_exhaust_fan_device1");

                entity.HasOne(d => d.FixationType)
                    .WithMany(p => p.ExhaustFan)
                    .HasForeignKey(d => d.FixationTypeId)
                    .HasConstraintName("fk_exhaust_fan_fixation_type1");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.ExhaustFan)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_exhaust_fan_equipment1");

                entity.HasOne(d => d.Pulley)
                    .WithMany(p => p.ExhaustFan)
                    .HasForeignKey(d => d.PulleyId)
                    .HasConstraintName("fk_exhaust_fan_pulley1");

                entity.HasOne(d => d.Ring)
                    .WithMany(p => p.ExhaustFan)
                    .HasForeignKey(d => d.RingId)
                    .HasConstraintName("fk_exhaust_fan_ring1");
            });

            modelBuilder.Entity<FixationType>(entity =>
            {
                entity.ToTable("fixation_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.ToTable("machine");

                entity.HasIndex(e => e.CompanyUnitSectorId)
                    .HasName("fk_equipment_company_unit_sector1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyUnitSectorId).HasColumnName("company_unit_sector_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Lubrication)
                    .HasColumnName("lubrication")
                    .HasColumnType("json");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.CompanyUnitSector)
                    .WithMany(p => p.Machine)
                    .HasForeignKey(d => d.CompanyUnitSectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_equipment_company_unit_sector1");
            });

            modelBuilder.Entity<Motor>(entity =>
            {
                entity.ToTable("motor");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActuationTypeId).HasColumnName("actuation_type_id");

                entity.Property(e => e.Bushing)
                    .HasColumnName("bushing")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Carcase)
                    .HasColumnName("carcase")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CardanShaftTypeId).HasColumnName("cardan_shaft_type_id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CompressorBrand)
                    .HasColumnName("compressor_brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompressorDescription).HasColumnName("compressor_description");

                entity.Property(e => e.CompressorDetails)
                    .HasColumnName("compressor_details")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompressorModel)
                    .HasColumnName("compressor_model")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompressorSerialNumber)
                    .HasColumnName("compressor_serial_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompressorTag)
                    .HasColumnName("compressor_tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompressorTypeId).HasColumnName("compressor_type_id");

                entity.Property(e => e.CouplingBrand)
                    .HasColumnName("coupling_brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CouplingDescription).HasColumnName("coupling_description");

                entity.Property(e => e.CouplingModel)
                    .HasColumnName("coupling_model")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CouplingTypeId).HasColumnName("coupling_type_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.CvPotency).HasColumnName("cv_potency");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.ElectricCurrent).HasColumnName("electric_current");

                entity.Property(e => e.ExhaustFanBrand)
                    .HasColumnName("exhaust_fan_brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExhaustFanDescription)
                    .HasColumnName("exhaust_fan_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExhaustFanModel)
                    .HasColumnName("exhaust_fan_model")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExhaustFanNumberOfBlades).HasColumnName("exhaust_fan_number_of_blades");

                entity.Property(e => e.ExhaustFanRotorDiameter).HasColumnName("exhaust_fan_rotor_diameter");

                entity.Property(e => e.ExhaustFanTag)
                    .HasColumnName("exhaust_fan_tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FixationTypeId).HasColumnName("fixation_type_id");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.Ip).HasColumnName("ip");

                entity.Property(e => e.IsolationClass)
                    .HasColumnName("isolation_class")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.KwPotency).HasColumnName("kw_potency");

                entity.Property(e => e.Lubrication)
                    .HasColumnName("lubrication")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId).HasColumnName("machine_id");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("manufacturer")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Observation).HasColumnName("observation");

                entity.Property(e => e.Pf).HasColumnName("pf");

                entity.Property(e => e.PulleyBeltQuantity).HasColumnName("pulley_belt_quantity");

                entity.Property(e => e.PulleyBetweenAxles).HasColumnName("pulley_between_axles");

                entity.Property(e => e.PulleyD1).HasColumnName("pulley_d1");

                entity.Property(e => e.PulleyD2).HasColumnName("pulley_d2");

                entity.Property(e => e.PulleyRatio).HasColumnName("pulley_ratio");

                entity.Property(e => e.PulleyTypeId).HasColumnName("pulley_type_id");

                entity.Property(e => e.PumpBrand)
                    .HasColumnName("pump_brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PumpDescription).HasColumnName("pump_description");

                entity.Property(e => e.PumpModel)
                    .HasColumnName("pump_model")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PumpTag)
                    .HasColumnName("pump_tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PumpTypeId).HasColumnName("pump_type_id");

                entity.Property(e => e.ReducerBrand)
                    .HasColumnName("reducer_brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReducerDescription).HasColumnName("reducer_description");

                entity.Property(e => e.ReducerDetails)
                    .HasColumnName("reducer_details")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReducerModel)
                    .HasColumnName("reducer_model")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReducerNumberOfAxles)
                    .HasColumnName("reducer_number_of_axles")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReducerRatio)
                    .HasColumnName("reducer_ratio")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReducerSerialNumber)
                    .HasColumnName("reducer_serial_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReducerTag)
                    .HasColumnName("reducer_tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RingBetweenAxles).HasColumnName("ring_between_axles");

                entity.Property(e => e.RingDriveGearTeethZ1).HasColumnName("ring_drive_gear_teeth_z1");

                entity.Property(e => e.RingDriveGearTeethZ2).HasColumnName("ring_drive_gear_teeth_z2");

                entity.Property(e => e.RingRatio)
                    .HasColumnName("ring_ratio")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RpmPotency).HasColumnName("rpm_potency");

                entity.Property(e => e.SectorDesc)
                    .HasColumnName("sector_desc")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Sf).HasColumnName("sf");

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Voltage).HasColumnName("voltage");

                entity.Property(e => e.Yeld).HasColumnName("yeld");
            });

            modelBuilder.Entity<Pulley>(entity =>
            {
                entity.ToTable("pulley");

                entity.HasIndex(e => e.PulleyTypeId)
                    .HasName("fk_pulley_pulley_type1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BeltQuantity).HasColumnName("belt_quantity");

                entity.Property(e => e.BetweenAxles).HasColumnName("between_axles");

                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasColumnName("created_at")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.D1).HasColumnName("d1");

                entity.Property(e => e.D2).HasColumnName("d2");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PulleyTypeId).HasColumnName("pulley_type_id");

                entity.Property(e => e.Ratio).HasColumnName("ratio");

                entity.Property(e => e.UpdatedAt)
                    .IsRequired()
                    .HasColumnName("updated_at")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.PulleyType)
                    .WithMany(p => p.Pulley)
                    .HasForeignKey(d => d.PulleyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pulley_pulley_type1");
            });

            modelBuilder.Entity<PulleyType>(entity =>
            {
                entity.ToTable("pulley_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Pump>(entity =>
            {
                entity.ToTable("pump");

                entity.HasIndex(e => e.ActuationTypeId)
                    .HasName("fk_pump_actuation_type1_idx");

                entity.HasIndex(e => e.CardanShaftTypeId)
                    .HasName("fk_pump_cardan_shaft_type1_idx");

                entity.HasIndex(e => e.CouplingId)
                    .HasName("fk_pump_coupling1_idx");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("fk_pump_device1_idx");

                entity.HasIndex(e => e.FixationTypeId)
                    .HasName("fk_pump_fixation_type1_idx");

                entity.HasIndex(e => e.MachineId)
                    .HasName("fk_pump_equipment1_idx");

                entity.HasIndex(e => e.PulleyId)
                    .HasName("fk_pump_pulley1_idx");

                entity.HasIndex(e => e.PumpTypeId)
                    .HasName("fk_pump_pump_type1_idx");

                entity.HasIndex(e => e.RingId)
                    .HasName("fk_pump_ring1_idx");

                entity.HasIndex(e => e.StageTypeId)
                    .HasName("fk_pump_stage_type1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActuationTypeId).HasColumnName("actuation_type_id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CardanShaftTypeId).HasColumnName("cardan_shaft_type_id");

                entity.Property(e => e.CouplingId).HasColumnName("coupling_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.FixationTypeId).HasColumnName("fixation_type_id");

                entity.Property(e => e.MachineId).HasColumnName("machine_id");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PulleyId).HasColumnName("pulley_id");

                entity.Property(e => e.PumpTypeId).HasColumnName("pump_type_id");

                entity.Property(e => e.RingId).HasColumnName("ring_id");

                entity.Property(e => e.StageTypeId).HasColumnName("stage_type_id");

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.ActuationType)
                    .WithMany(p => p.Pump)
                    .HasForeignKey(d => d.ActuationTypeId)
                    .HasConstraintName("fk_pump_actuation_type1");

                entity.HasOne(d => d.CardanShaftType)
                    .WithMany(p => p.Pump)
                    .HasForeignKey(d => d.CardanShaftTypeId)
                    .HasConstraintName("fk_pump_cardan_shaft_type1");

                entity.HasOne(d => d.Coupling)
                    .WithMany(p => p.Pump)
                    .HasForeignKey(d => d.CouplingId)
                    .HasConstraintName("fk_pump_coupling1");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Pump)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pump_device1");

                entity.HasOne(d => d.FixationType)
                    .WithMany(p => p.Pump)
                    .HasForeignKey(d => d.FixationTypeId)
                    .HasConstraintName("fk_pump_fixation_type1");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Pump)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pump_equipment1");

                entity.HasOne(d => d.Pulley)
                    .WithMany(p => p.Pump)
                    .HasForeignKey(d => d.PulleyId)
                    .HasConstraintName("fk_pump_pulley1");

                entity.HasOne(d => d.PumpType)
                    .WithMany(p => p.Pump)
                    .HasForeignKey(d => d.PumpTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pump_pump_type1");

                entity.HasOne(d => d.Ring)
                    .WithMany(p => p.Pump)
                    .HasForeignKey(d => d.RingId)
                    .HasConstraintName("fk_pump_ring1");

                entity.HasOne(d => d.StageType)
                    .WithMany(p => p.Pump)
                    .HasForeignKey(d => d.StageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pump_stage_type1");
            });

            modelBuilder.Entity<PumpType>(entity =>
            {
                entity.ToTable("pump_type");

                entity.HasIndex(e => e.Name)
                    .HasName("name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Reducer>(entity =>
            {
                entity.ToTable("reducer");

                entity.HasIndex(e => e.ActuationTypeId)
                    .HasName("fk_reducer_actuation_type1_idx");

                entity.HasIndex(e => e.CardanShaftTypeId)
                    .HasName("fk_reducer_cardan_shaft_type1_idx");

                entity.HasIndex(e => e.CouplingId)
                    .HasName("fk_reducer_coupling1_idx");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("fk_reducer_device1_idx");

                entity.HasIndex(e => e.FixationTypeId)
                    .HasName("fk_reducer_fixation_type1_idx");

                entity.HasIndex(e => e.MachineId)
                    .HasName("fk_reducer_equipment1_idx");

                entity.HasIndex(e => e.PulleyId)
                    .HasName("fk_reducer_pulley1_idx");

                entity.HasIndex(e => e.RingId)
                    .HasName("fk_reducer_ring1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActuationTypeId).HasColumnName("actuation_type_id");

                entity.Property(e => e.Brand)
                    .HasColumnName("brand")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CardanShaftTypeId).HasColumnName("cardan_shaft_type_id");

                entity.Property(e => e.CouplingId).HasColumnName("coupling_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .HasColumnType("json");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.FixationTypeId).HasColumnName("fixation_type_id");

                entity.Property(e => e.MachineId).HasColumnName("machine_id");

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfAxles)
                    .HasColumnName("number_of_axles")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PulleyId).HasColumnName("pulley_id");

                entity.Property(e => e.Ratio)
                    .HasColumnName("ratio")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RingId).HasColumnName("ring_id");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.ActuationType)
                    .WithMany(p => p.Reducer)
                    .HasForeignKey(d => d.ActuationTypeId)
                    .HasConstraintName("fk_reducer_actuation_type1");

                entity.HasOne(d => d.CardanShaftType)
                    .WithMany(p => p.Reducer)
                    .HasForeignKey(d => d.CardanShaftTypeId)
                    .HasConstraintName("fk_reducer_cardan_shaft_type1");

                entity.HasOne(d => d.Coupling)
                    .WithMany(p => p.Reducer)
                    .HasForeignKey(d => d.CouplingId)
                    .HasConstraintName("fk_reducer_coupling1");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Reducer)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reducer_device1");

                entity.HasOne(d => d.FixationType)
                    .WithMany(p => p.Reducer)
                    .HasForeignKey(d => d.FixationTypeId)
                    .HasConstraintName("fk_reducer_fixation_type1");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Reducer)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reducer_equipment1");

                entity.HasOne(d => d.Pulley)
                    .WithMany(p => p.Reducer)
                    .HasForeignKey(d => d.PulleyId)
                    .HasConstraintName("fk_reducer_pulley1");

                entity.HasOne(d => d.Ring)
                    .WithMany(p => p.Reducer)
                    .HasForeignKey(d => d.RingId)
                    .HasConstraintName("fk_reducer_ring1");
            });

            modelBuilder.Entity<Ring>(entity =>
            {
                entity.ToTable("ring");

                entity.HasIndex(e => e.RingTypeId)
                    .HasName("fk_ring_ring_type1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BetweenAxles).HasColumnName("between_axles");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.DriveGearTeethZ1).HasColumnName("drive_gear_teeth_z1");

                entity.Property(e => e.DriveGearTeethZ2).HasColumnName("drive_gear_teeth_z2");

                entity.Property(e => e.Ratio)
                    .HasColumnName("ratio")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RingTypeId).HasColumnName("ring_type_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.RingType)
                    .WithMany(p => p.Ring)
                    .HasForeignKey(d => d.RingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ring_ring_type1");
            });

            modelBuilder.Entity<RingType>(entity =>
            {
                entity.ToTable("ring_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<StageType>(entity =>
            {
                entity.ToTable("stage_type");

                entity.HasIndex(e => e.Name)
                    .HasName("name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.ContactId)
                    .HasName("fk_user_contact1_idx");

                entity.HasIndex(e => e.UserTypeId)
                    .HasName("fk_user_user_type_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserTypeId).HasColumnName("user_type_id");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_contact1");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_user_type");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("user_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
