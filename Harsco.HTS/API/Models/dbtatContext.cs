using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Models;

public partial class dbtatContext : DbContext
{
    public dbtatContext()
    {
    }

    public dbtatContext(DbContextOptions<dbtatContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminDoctorLocation> AdminDoctorLocations { get; set; }

    public virtual DbSet<AdminDoctorProfile> AdminDoctorProfiles { get; set; }

    public virtual DbSet<AdminDoctorSchedule> AdminDoctorSchedules { get; set; }

    public virtual DbSet<AdminDoctorSpeciality> AdminDoctorSpecialities { get; set; }

    public virtual DbSet<AdminFaq> AdminFaqs { get; set; }

    public virtual DbSet<AdminImageMaintenance> AdminImageMaintenances { get; set; }

    public virtual DbSet<AdminLocation> AdminLocations { get; set; }

    public virtual DbSet<AdminOrganization> AdminOrganizations { get; set; }

    public virtual DbSet<AdminOrganizationHoliday> AdminOrganizationHolidays { get; set; }

    public virtual DbSet<AdminSpeciality> AdminSpecialities { get; set; }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<AdministrativeNotification> AdministrativeNotifications { get; set; }

    public virtual DbSet<Agreement> Agreements { get; set; }

    public virtual DbSet<AppointmentSlot> AppointmentSlots { get; set; }

    public virtual DbSet<BannerClickReport> BannerClickReports { get; set; }

    public virtual DbSet<CountryList> CountryLists { get; set; }

    public virtual DbSet<Dependent> Dependents { get; set; }

    public virtual DbSet<DependentAndOther> DependentAndOthers { get; set; }

    public virtual DbSet<DependentRelation> DependentRelations { get; set; }

    public virtual DbSet<EmployeeTypeMaster> EmployeeTypeMasters { get; set; }

    public virtual DbSet<FdCaption> FdCaptions { get; set; }

    public virtual DbSet<FdForm> FdForms { get; set; }

    public virtual DbSet<FdMainMenu> FdMainMenus { get; set; }

    public virtual DbSet<FdModule> FdModules { get; set; }

    public virtual DbSet<Identifier> Identifiers { get; set; }

    public virtual DbSet<InsuranceCoverage> InsuranceCoverages { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<MarketingMainBanner> MarketingMainBanners { get; set; }

    public virtual DbSet<MessageMaster> MessageMasters { get; set; }

    public virtual DbSet<Mrn> Mrns { get; set; }

    public virtual DbSet<NotificationManager> NotificationManagers { get; set; }

    public virtual DbSet<NotificationTemplate> NotificationTemplates { get; set; }

    public virtual DbSet<NotificationUser> NotificationUsers { get; set; }

    public virtual DbSet<OrganizationInsurancePlan> OrganizationInsurancePlans { get; set; }

    public virtual DbSet<OtpEntry> OtpEntries { get; set; }

    public virtual DbSet<PatientDoctorAppointment> PatientDoctorAppointments { get; set; }

    public virtual DbSet<PatientUser> PatientUsers { get; set; }

    public virtual DbSet<PatientsUser> PatientsUsers { get; set; }

    public virtual DbSet<RdReport> RdReports { get; set; }

    public virtual DbSet<ScheduleException> ScheduleExceptions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserToken> UserTokens { get; set; }

    public virtual DbSet<WhatsHappening> WhatsHappenings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-T0IU7OL;Database=Mcare21_MobileApp_QA;User ID=sa;Password=123456789;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminDoctorLocation>(entity =>
        {
            entity.HasKey(e => e.DoctorLocationId).HasName("PK__Admin_Do__B23B7D2B006F5C30");

            entity.ToTable("Admin_DoctorLocations");

            entity.HasIndex(e => e.CreatedBy, "IX_Admin_DoctorLocations_CreatedBy");

            entity.HasIndex(e => e.DoctorProfileId, "IX_Admin_DoctorLocations_DoctorProfileId");

            entity.HasIndex(e => e.LastModifiedBy, "IX_Admin_DoctorLocations_LastModifiedBy");

            entity.HasIndex(e => e.LocationId, "IX_Admin_DoctorLocations_LocationId");

            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Role).HasMaxLength(100);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AdminDoctorLocationCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Admin_Doc__Creat__76969D2E");

            entity.HasOne(d => d.DoctorProfile).WithMany(p => p.AdminDoctorLocations)
                .HasForeignKey(d => d.DoctorProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admin_Doc__Docto__74AE54BC");

            entity.HasOne(d => d.LastModifiedByNavigation).WithMany(p => p.AdminDoctorLocationLastModifiedByNavigations)
                .HasForeignKey(d => d.LastModifiedBy)
                .HasConstraintName("FK__Admin_Doc__LastM__778AC167");

            entity.HasOne(d => d.Location).WithMany(p => p.AdminDoctorLocations)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admin_Doc__Locat__75A278F5");
        });

        modelBuilder.Entity<AdminDoctorProfile>(entity =>
        {
            entity.HasKey(e => e.DoctorProfileId).HasName("PK__Admin_Do__1839404D158731BD");

            entity.ToTable("Admin_DoctorProfiles");

            entity.HasIndex(e => e.CreatedBy, "IX_Admin_DoctorProfiles_CreatedBy");

            entity.HasIndex(e => e.LastModifiedBy, "IX_Admin_DoctorProfiles_LastModifiedBy");

            entity.HasIndex(e => e.OrganizationId, "IX_Admin_DoctorProfiles_OrganizationId");

            entity.HasIndex(e => e.Identifier, "UQ__Admin_Do__821FB0192811379F")
                .IsUnique()
                .HasFilter("([Identifier] IS NOT NULL)");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(20);
            entity.Property(e => e.Identifier).HasMaxLength(50);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(500)
                .HasColumnName("imageURL");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(50);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AdminDoctorProfileCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Admin_Doc__Creat__628FA481");

            entity.HasOne(d => d.LastModifiedByNavigation).WithMany(p => p.AdminDoctorProfileLastModifiedByNavigations)
                .HasForeignKey(d => d.LastModifiedBy)
                .HasConstraintName("FK__Admin_Doc__LastM__6383C8BA");

            entity.HasOne(d => d.Organization).WithMany(p => p.AdminDoctorProfiles)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("FK__Admin_Doc__Organ__619B8048");
        });

        modelBuilder.Entity<AdminDoctorSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasName("PK__Admin_Do__9C8A5B49C49636A1");

            entity.ToTable("Admin_DoctorSchedule");

            entity.HasIndex(e => e.DoctorProfileId, "IX_Admin_DoctorSchedule_DoctorProfileId");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Actor).HasMaxLength(255);
            entity.Property(e => e.Comment).HasMaxLength(1024);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Identifier).HasMaxLength(255);
            entity.Property(e => e.ServiceCategory).HasMaxLength(255);
            entity.Property(e => e.ServiceType).HasMaxLength(255);
            entity.Property(e => e.Specialty).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.DoctorProfile).WithMany(p => p.AdminDoctorSchedules)
                .HasForeignKey(d => d.DoctorProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admin_Doc__Docto__634EBE90");
        });

        modelBuilder.Entity<AdminDoctorSpeciality>(entity =>
        {
            entity.HasKey(e => e.DoctorSpecialityId).HasName("PK__Admin_Do__CACF440AE8F51875");

            entity.ToTable("Admin_DoctorSpecialities");

            entity.HasIndex(e => e.CreatedBy, "IX_Admin_DoctorSpecialities_CreatedBy");

            entity.HasIndex(e => e.DoctorProfileId, "IX_Admin_DoctorSpecialities_DoctorProfileId");

            entity.HasIndex(e => e.LastModifiedBy, "IX_Admin_DoctorSpecialities_LastModifiedBy");

            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Speciality).HasMaxLength(100);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AdminDoctorSpecialityCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Admin_Doc__Creat__693CA210");

            entity.HasOne(d => d.DoctorProfile).WithMany(p => p.AdminDoctorSpecialities)
                .HasForeignKey(d => d.DoctorProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Admin_Doc__Docto__68487DD7");

            entity.HasOne(d => d.LastModifiedByNavigation).WithMany(p => p.AdminDoctorSpecialityLastModifiedByNavigations)
                .HasForeignKey(d => d.LastModifiedBy)
                .HasConstraintName("FK__Admin_Doc__LastM__6A30C649");
        });

        modelBuilder.Entity<AdminFaq>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Admin_FA__3214EC27465A3BC6");

            entity.ToTable("Admin_FAQ");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Header).HasMaxLength(255);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Platforms).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.Users).HasMaxLength(255);
        });

        modelBuilder.Entity<AdminImageMaintenance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminIma__3214EC0711CCCCF6");

            entity.ToTable("Admin_ImageMaintenance");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.ImageName).HasMaxLength(100);
            entity.Property(e => e.ImageType).HasMaxLength(50);
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(2083)
                .HasColumnName("ImageURL");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ScreenType).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<AdminLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__Admin_Lo__E7FEA4977E6C078B");

            entity.ToTable("Admin_Locations");

            entity.HasIndex(e => e.CreatedBy, "IX_Admin_Locations_CreatedBy");

            entity.HasIndex(e => e.LastModifiedBy, "IX_Admin_Locations_LastModifiedBy");

            entity.HasIndex(e => e.PartOfLocationId, "IX_Admin_Locations_PartOfLocationId");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AddressLine1).HasMaxLength(100);
            entity.Property(e => e.AddressLine2).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Identifier).HasMaxLength(50);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LocationType).HasMaxLength(50);
            entity.Property(e => e.Mode).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.PhysicalType).HasMaxLength(50);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AdminLocationCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Admin_Loc__Creat__6EF57B66");

            entity.HasOne(d => d.LastModifiedByNavigation).WithMany(p => p.AdminLocationLastModifiedByNavigations)
                .HasForeignKey(d => d.LastModifiedBy)
                .HasConstraintName("FK__Admin_Loc__LastM__6FE99F9F");

            entity.HasOne(d => d.PartOfLocation).WithMany(p => p.InversePartOfLocation)
                .HasForeignKey(d => d.PartOfLocationId)
                .HasConstraintName("FK_Admin_Locations_PartOfLocationId");
        });

        modelBuilder.Entity<AdminOrganization>(entity =>
        {
            entity.HasKey(e => e.OrganizationId).HasName("PK__Admin_Or__CADB0B12E6A14400");

            entity.ToTable("Admin_Organizations");

            entity.HasIndex(e => e.CreatedBy, "IX_Admin_Organizations_CreatedBy");

            entity.HasIndex(e => e.LastModifiedBy, "IX_Admin_Organizations_LastModifiedBy");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.ImageUrl).HasMaxLength(2000);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.WebsiteUrl).HasMaxLength(2000);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AdminOrganizationCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Admin_Org__Creat__5AEE82B9");

            entity.HasOne(d => d.LastModifiedByNavigation).WithMany(p => p.AdminOrganizationLastModifiedByNavigations)
                .HasForeignKey(d => d.LastModifiedBy)
                .HasConstraintName("FK__Admin_Org__LastM__5BE2A6F2");
        });

        modelBuilder.Entity<AdminOrganizationHoliday>(entity =>
        {
            entity.HasKey(e => e.HolidayScheduleId).HasName("PK__Admin_Or__210B742025BB60DE");

            entity.ToTable("Admin_OrganizationHolidays");

            entity.HasIndex(e => e.OrganizationId, "IX_Admin_OrganizationHolidays_OrganizationId");

            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HolidayName).HasMaxLength(255);
            entity.Property(e => e.HolidayType).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Organization).WithMany(p => p.AdminOrganizationHolidays)
                .HasForeignKey(d => d.OrganizationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Organization");
        });

        modelBuilder.Entity<AdminSpeciality>(entity =>
        {
            entity.HasKey(e => e.SpecialityId).HasName("PK__Admin_Sp__67ED609B69609634");

            entity.ToTable("Admin_Specialities");

            entity.HasIndex(e => e.CreatedBy, "IX_Admin_Specialities_CreatedBy");

            entity.HasIndex(e => e.LastModifiedBy, "IX_Admin_Specialities_LastModifiedBy");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DisplayName).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AdminSpecialityCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Admin_Spe__Creat__0E6E26BF");

            entity.HasOne(d => d.LastModifiedByNavigation).WithMany(p => p.AdminSpecialityLastModifiedByNavigations)
                .HasForeignKey(d => d.LastModifiedBy)
                .HasConstraintName("FK__Admin_Spe__LastM__0F624AF8");
        });

        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Admin_Us__719FE488B6140466");

            entity.ToTable("Admin_Users");

            entity.HasIndex(e => e.CreatedBy, "IX_Admin_Users_CreatedBy");

            entity.HasIndex(e => e.LastModifiedBy, "IX_Admin_Users_LastModifiedBy");

            entity.HasIndex(e => e.Username, "UQ__Admin_Us__536C85E486F3250C").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Admin_Us__A9D10534D8756BB1").IsUnique();

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.LastLoginFailedTime).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InverseCreatedByNavigation)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Admin_Use__Creat__5535A963");

            entity.HasOne(d => d.LastModifiedByNavigation).WithMany(p => p.InverseLastModifiedByNavigation)
                .HasForeignKey(d => d.LastModifiedBy)
                .HasConstraintName("FK__Admin_Use__LastM__5629CD9C");
        });

        modelBuilder.Entity<AdministrativeNotification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Administ__20CF2E323629FAC9");

            entity.HasIndex(e => e.RecipientId, "IX_AdministrativeNotifications_RecipientId");

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.AcknowledgedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.IsUrgent).HasDefaultValue(false);
            entity.Property(e => e.Message).HasColumnType("text");
            entity.Property(e => e.NotificationType).HasMaxLength(50);
            entity.Property(e => e.Sender).HasMaxLength(255);
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Subject).HasMaxLength(255);

            entity.HasOne(d => d.Recipient).WithMany(p => p.AdministrativeNotifications)
                .HasForeignKey(d => d.RecipientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Administr__Recip__361203C5");
        });

        modelBuilder.Entity<Agreement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Agreemen__3214EC07DBE21FBF");

            entity.ToTable("Agreement");

            entity.Property(e => e.AgreementText).HasMaxLength(2000);
            entity.Property(e => e.AgreementUniqueId).HasMaxLength(50);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Frequency).HasMaxLength(50);
            entity.Property(e => e.Language).HasMaxLength(100);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<AppointmentSlot>(entity =>
        {
            entity.HasKey(e => e.SlotId).HasName("PK__Appointm__0A124AAFB18E6454");

            entity.ToTable("AppointmentSlot");

            entity.HasIndex(e => e.DoctorSpecialityId, "IX_AppointmentSlot_DoctorSpecialityId");

            entity.Property(e => e.Period)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ServiceCategory)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ServiceType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SlotEnd).HasColumnType("datetime");
            entity.Property(e => e.SlotStart).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.DoctorSpeciality).WithMany(p => p.AppointmentSlots)
                .HasForeignKey(d => d.DoctorSpecialityId)
                .HasConstraintName("FK__Appointme__Docto__3493CFA7");
        });

        modelBuilder.Entity<BannerClickReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BannerCl__D06F930596485F73");

            entity.ToTable("BannerClickReport");

            entity.Property(e => e.BannerId).HasColumnName("BannerID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModifiedBy).HasMaxLength(255);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<CountryList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CountryL__3214EC078F28D2A8");

            entity.ToTable("CountryList");

            entity.Property(e => e.CountryCode).HasMaxLength(10);
            entity.Property(e => e.CountryName).HasMaxLength(100);
            entity.Property(e => e.ImageUrl).HasMaxLength(500);
            entity.Property(e => e.Nationality).HasMaxLength(100);
        });

        modelBuilder.Entity<Dependent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Dependen__3214EC072A0C3E2F");

            entity.ToTable("Dependent");

            entity.HasIndex(e => e.DependentUhid, "IX_Dependent_Dependent_UHID");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DependentUhid)
                .HasMaxLength(50)
                .HasColumnName("Dependent_UHID");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.RelationshipCategory).HasMaxLength(50);
            entity.Property(e => e.Uhid)
                .HasMaxLength(50)
                .HasColumnName("UHID");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);

            entity.HasOne(d => d.DependentUh).WithMany(p => p.Dependents)
                .HasPrincipalKey(p => p.Uhid)
                .HasForeignKey(d => d.DependentUhid)
                .HasConstraintName("FK_Dependent_Users");
        });

        modelBuilder.Entity<DependentAndOther>(entity =>
        {
            entity.HasKey(e => e.DependentId).HasName("PK__Dependen__9BC67C1177149B33");

            entity.ToTable("DependentAndOther");

            entity.HasIndex(e => e.PatientId, "IX_DependentAndOther_PatientID");

            entity.HasIndex(e => e.RelationId, "IX_DependentAndOther_RelationID");

            entity.Property(e => e.DependentId).HasColumnName("DependentID");
            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.PatientId)
                .HasMaxLength(50)
                .HasColumnName("PatientID");
            entity.Property(e => e.RelationId)
                .HasMaxLength(50)
                .HasColumnName("RelationID");
            entity.Property(e => e.RelationshipCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Patient).WithMany(p => p.DependentAndOtherPatients)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DependentAndOther_PatientUser");

            entity.HasOne(d => d.Relation).WithMany(p => p.DependentAndOtherRelations)
                .HasForeignKey(d => d.RelationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DependentAndOther_RelationUser");
        });

        modelBuilder.Entity<DependentRelation>(entity =>
        {
            entity.HasKey(e => e.DependentId).HasName("PK__Dependen__9BC67CF1CB15AAA9");

            entity.ToTable("Dependent_Relation");

            entity.Property(e => e.ContactNumber).HasMaxLength(50);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.PatientId).HasMaxLength(50);
            entity.Property(e => e.RelationshipCode).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<EmployeeTypeMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EmployeeTypeMaster_ID");

            entity.ToTable("EmployeeTypeMaster");

            entity.HasIndex(e => e.EmployeeTypeCode, "UK_EmployeeTypeMaster_EmployeeTypeCode").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.EmployeeTypeCode).HasMaxLength(20);
            entity.Property(e => e.EmployeeTypeName).HasMaxLength(300);
            entity.Property(e => e.FacilityCode).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<FdCaption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FD_Caption_ID");

            entity.ToTable("FD_Caption");

            entity.HasIndex(e => e.EnUs, "UK_FD_Caption_en_US")
                .IsUnique()
                .HasFilter("([en-US] IS NOT NULL)");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.EnUs)
                .HasMaxLength(300)
                .HasColumnName("en-US");
            entity.Property(e => e.FacilityCode).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<FdForm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FD_Forms_ID");

            entity.ToTable("FD_Forms");

            entity.HasIndex(e => e.CaptionId, "IX_FD_Forms_CaptionID");

            entity.HasIndex(e => e.ModuleId, "IX_FD_Forms_ModuleID");

            entity.HasIndex(e => e.FormName, "UK_FD_Forms_FormName")
                .IsUnique()
                .HasFilter("([FormName] IS NOT NULL)");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CaptionId).HasColumnName("CaptionID");
            entity.Property(e => e.FacilityCode).HasMaxLength(20);
            entity.Property(e => e.FdxFileName).HasMaxLength(100);
            entity.Property(e => e.FormName).HasMaxLength(300);
            entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

            entity.HasOne(d => d.Caption).WithMany(p => p.FdForms)
                .HasForeignKey(d => d.CaptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FD_Forms_CaptionID_FD_Caption_ID");

            entity.HasOne(d => d.Module).WithMany(p => p.FdForms)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FD_Forms_ModuleID_FD_Module_ID");
        });

        modelBuilder.Entity<FdMainMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FD_MainMenus_ID");

            entity.ToTable("FD_MainMenus");

            entity.HasIndex(e => e.CaptionId, "IX_FD_MainMenus_CaptionID");

            entity.HasIndex(e => e.InvokeId, "IX_FD_MainMenus_InvokeID");

            entity.HasIndex(e => e.ParentId, "IX_FD_MainMenus_ParentID");

            entity.HasIndex(e => e.ToolTipId, "IX_FD_MainMenus_ToolTipID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CaptionId).HasColumnName("CaptionID");
            entity.Property(e => e.FacilityCode).HasMaxLength(20);
            entity.Property(e => e.IconId).HasColumnName("IconID");
            entity.Property(e => e.InvokeId).HasColumnName("InvokeID");
            entity.Property(e => e.IsEmrd).HasColumnName("IsEMRD");
            entity.Property(e => e.MenuDescription).HasMaxLength(500);
            entity.Property(e => e.MenuIconFileName).HasMaxLength(300);
            entity.Property(e => e.MenuIconPath).HasMaxLength(300);
            entity.Property(e => e.MenuName).HasMaxLength(300);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.ShortcutKeys).HasMaxLength(50);
            entity.Property(e => e.ToolTipId).HasColumnName("ToolTipID");

            entity.HasOne(d => d.Caption).WithMany(p => p.FdMainMenus)
                .HasForeignKey(d => d.CaptionId)
                .HasConstraintName("FK_FD_MainMenus_CaptionID_FD_Caption_ID");

            entity.HasOne(d => d.Invoke).WithMany(p => p.FdMainMenus)
                .HasForeignKey(d => d.InvokeId)
                .HasConstraintName("FK_FD_MainMenus_InvokeID_FD_Forms_ID");

            entity.HasOne(d => d.InvokeNavigation).WithMany(p => p.FdMainMenus)
                .HasForeignKey(d => d.InvokeId)
                .HasConstraintName("FK_FD_MainMenus_InvokeID_RD_Report_ID");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_FD_MainMenus_ParentID_FD_MainMenus_ID");

            entity.HasOne(d => d.ToolTip).WithMany(p => p.FdMainMenus)
                .HasForeignKey(d => d.ToolTipId)
                .HasConstraintName("FK_FD_MainMenus_ToolTipID_MessageMaster_ID");
        });

        modelBuilder.Entity<FdModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FD_Module_ID");

            entity.ToTable("FD_Module");

            entity.HasIndex(e => e.CaptionId, "IX_FD_Module_CaptionID");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CaptionId).HasColumnName("CaptionID");
            entity.Property(e => e.FacilityCode).HasMaxLength(20);
            entity.Property(e => e.MainMenuId).HasColumnName("MainMenuID");
            entity.Property(e => e.ModuleName).HasMaxLength(100);

            entity.HasOne(d => d.Caption).WithMany(p => p.FdModules)
                .HasForeignKey(d => d.CaptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FD_Module_CaptionID_FD_Caption_ID");
        });

        modelBuilder.Entity<Identifier>(entity =>
        {
            entity.HasKey(e => e.IdentifierId).HasName("PK__Identifi__5EB5E676827ADBED");

            entity.ToTable("Identifier");

            entity.HasIndex(e => e.PatientId, "IX_Identifier_PatientId");

            entity.HasIndex(e => e.IdentifierValue, "UQ__Identifi__86D95C4392DCBDB6").IsUnique();

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdentifierType).HasMaxLength(50);
            entity.Property(e => e.IdentifierValue).HasMaxLength(20);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PatientId).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            entity.HasOne(d => d.Patient).WithMany(p => p.Identifiers)
                .HasForeignKey(d => d.PatientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Identifie__Patie__5DEAEAF5");
        });

        modelBuilder.Entity<InsuranceCoverage>(entity =>
        {
            entity.HasKey(e => e.CoverageId).HasName("PK__Insuranc__45403DBB721D9CFB");

            entity.ToTable("InsuranceCoverage");

            entity.Property(e => e.ClassType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ClassValue)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Network)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PeriodEndDate).HasColumnType("datetime");
            entity.Property(e => e.PeriodStartDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubscriberRelationship)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PK__Language__B93855AB97FEF5A7");

            entity.HasIndex(e => e.DoctorProfileId, "IX_Languages_DoctorProfileId");

            entity.Property(e => e.LanguageCode).HasMaxLength(2);
            entity.Property(e => e.LanguageName).HasMaxLength(100);
            entity.Property(e => e.Region).HasMaxLength(100);

            entity.HasOne(d => d.DoctorProfile).WithMany(p => p.Languages)
                .HasForeignKey(d => d.DoctorProfileId)
                .HasConstraintName("FK_Languages_DoctorId");
        });

        modelBuilder.Entity<MarketingMainBanner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Marketin__A14FE2E4D7441D2B");

            entity.ToTable("MarketingMainBanner");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ImageUrl).HasMaxLength(2000);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(800);
            entity.Property(e => e.Url).HasMaxLength(1000);
        });

        modelBuilder.Entity<MessageMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MessageMaster_ID");

            entity.ToTable("MessageMaster");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DefaultMessage).HasMaxLength(300);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.EnUs)
                .HasMaxLength(300)
                .HasColumnName("en-US");
            entity.Property(e => e.FacilityCode).HasMaxLength(20);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<Mrn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MRN__3214EC07CCC47BDE");

            entity.ToTable("MRN");

            entity.HasIndex(e => e.HospitalId, "IX_MRN_HospitalId");

            entity.HasIndex(e => e.UserId, "IX_MRN_UserId");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.HospitalName).HasMaxLength(255);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsPrimaryMrn).HasColumnName("IsPrimaryMRN");
            entity.Property(e => e.Mrnnumber)
                .HasMaxLength(50)
                .HasColumnName("MRNNumber");
            entity.Property(e => e.RegisterEmail).HasMaxLength(40);
            entity.Property(e => e.RegisterMobile).HasMaxLength(12);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);

            entity.HasOne(d => d.Hospital).WithMany(p => p.Mrns)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MRN_Organization");

            entity.HasOne(d => d.User).WithMany(p => p.Mrns)
                .HasPrincipalKey(p => p.UserId)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MRN_User");
        });

        modelBuilder.Entity<NotificationManager>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__20CF2E324F8CF0E4");

            entity.ToTable("NotificationManager");

            entity.HasIndex(e => e.RecipientId, "IX_NotificationManager_RecipientID");

            entity.HasIndex(e => e.TemplateId, "IX_NotificationManager_TemplateID");

            entity.Property(e => e.NotificationId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("NotificationID");
            entity.Property(e => e.AcknowledgedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.IsUrgent).HasDefaultValue(false);
            entity.Property(e => e.RecipientId).HasColumnName("RecipientID");
            entity.Property(e => e.Sender).HasMaxLength(255);
            entity.Property(e => e.SentDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

            entity.HasOne(d => d.Recipient).WithMany(p => p.NotificationManagers)
                .HasForeignKey(d => d.RecipientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Notificat__Recip__67A95F59");

            entity.HasOne(d => d.Template).WithMany(p => p.NotificationManagers)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Notificat__Templ__66B53B20");
        });

        modelBuilder.Entity<NotificationTemplate>(entity =>
        {
            entity.HasKey(e => e.TemplateId).HasName("PK__Notifica__F87ADD076627FAD7");

            entity.Property(e => e.TemplateId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("TemplateID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TemplateContent).HasColumnType("text");
            entity.Property(e => e.TemplateName).HasMaxLength(255);
        });

        modelBuilder.Entity<NotificationUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Notifica__1788CCAC13F85BF6");

            entity.ToTable("Notification_Users");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<OrganizationInsurancePlan>(entity =>
        {
            entity.HasKey(e => e.OrganizationInsurancePlanId).HasName("PK__Organiza__507C2082767C27AB");

            entity.ToTable("OrganizationInsurancePlan");

            entity.HasIndex(e => e.InsurancePlanId, "IX_OrganizationInsurancePlan_InsurancePlanId");

            entity.HasIndex(e => e.OrganizationId, "IX_OrganizationInsurancePlan_OrganizationId");

            entity.Property(e => e.CoverageArea).HasMaxLength(255);
            entity.Property(e => e.Network).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.InsurancePlan).WithMany(p => p.OrganizationInsurancePlans)
                .HasForeignKey(d => d.InsurancePlanId)
                .HasConstraintName("FK__Organizat__Insur__17C286CF");

            entity.HasOne(d => d.Organization).WithMany(p => p.OrganizationInsurancePlans)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("FK__Organizat__Organ__16CE6296");
        });

        modelBuilder.Entity<OtpEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OtpEntry__3214EC0702CF1C1C");

            entity.ToTable("OtpEntry");

            entity.Property(e => e.CreatedBy).HasColumnType("datetime");
            entity.Property(e => e.DateUsed).HasColumnType("datetime");
            entity.Property(e => e.ExpiryTime).HasColumnType("datetime");
            entity.Property(e => e.IdentificationNo).HasMaxLength(50);
            entity.Property(e => e.IsUsed).HasDefaultValue(false);
            entity.Property(e => e.LastFailedTime).HasColumnType("datetime");
            entity.Property(e => e.Otp).HasMaxLength(10);
            entity.Property(e => e.RetryAttempts).HasDefaultValue(0);
            entity.Property(e => e.UpdatedBy).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<PatientDoctorAppointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__Patient___8ECDFCC2B929B886");

            entity.ToTable("Patient_DoctorAppointments");

            entity.HasIndex(e => e.AppointmentLocationId, "IX_Patient_DoctorAppointments_AppointmentLocationId");

            entity.HasIndex(e => e.DoctorProfileId, "IX_Patient_DoctorAppointments_DoctorProfileId");

            entity.HasIndex(e => e.PatientId, "IX_Patient_DoctorAppointments_PatientId");

            entity.HasIndex(e => e.SlotId, "IX_Patient_DoctorAppointments_SlotId ");

            entity.Property(e => e.CheckInTime).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(1000);
            entity.Property(e => e.PatientId).HasMaxLength(50);
            entity.Property(e => e.PaymentMethod).HasMaxLength(255);
            entity.Property(e => e.ReasonCode).HasMaxLength(100);
            entity.Property(e => e.SlotId).HasColumnName("SlotId ");
            entity.Property(e => e.SlotType).HasMaxLength(50);
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.VisitType).HasMaxLength(50);

            entity.HasOne(d => d.AppointmentLocation).WithMany(p => p.PatientDoctorAppointments)
                .HasForeignKey(d => d.AppointmentLocationId)
                .HasConstraintName("FK_Patient_DoctorAppointments_Admin_Locations");

            entity.HasOne(d => d.DoctorProfile).WithMany(p => p.PatientDoctorAppointments)
                .HasForeignKey(d => d.DoctorProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Patient_D__Docto__1B29035F");

            entity.HasOne(d => d.Patient).WithMany(p => p.PatientDoctorAppointments)
                .HasPrincipalKey(p => p.UserId)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK_PatientID_UserID");

            entity.HasOne(d => d.Slot).WithMany(p => p.PatientDoctorAppointments)
                .HasForeignKey(d => d.SlotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Patient_D__SlotI__1C1D2798");
        });

        modelBuilder.Entity<PatientUser>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__Patient___970EC366A080C7AA");

            entity.ToTable("Patient_User");

            entity.HasIndex(e => e.IdentifierIc, "UQ__Patient___F99678620064A01C")
                .IsUnique()
                .HasFilter("([Identifier_IC] IS NOT NULL)");

            entity.Property(e => e.PatientId).HasMaxLength(50);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.BirthPlace).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Ethnicity).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.IdentifierIc)
                .HasMaxLength(20)
                .HasColumnName("Identifier_IC");
            entity.Property(e => e.IdentifierMrn)
                .HasMaxLength(20)
                .HasColumnName("Identifier_MRN");
            entity.Property(e => e.IdentifierPassport)
                .HasMaxLength(20)
                .HasColumnName("Identifier_Passport");
            entity.Property(e => e.ImageUrl).HasMaxLength(200);
            entity.Property(e => e.Language).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PassportIssuedCountry).HasMaxLength(100);
            entity.Property(e => e.PassportNumber).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.PreferredName).HasMaxLength(20);
            entity.Property(e => e.Religion).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(10);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<PatientsUser>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__Patients__970EC36604F74760");

            entity.ToTable("Patients_Users");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.ImageUrl).HasMaxLength(200);
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.PreferredName).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
        });

        modelBuilder.Entity<RdReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RD_Report_ID");

            entity.ToTable("RD_Report");

            entity.HasIndex(e => e.CaptionId, "IX_RD_Report_CaptionID");

            entity.HasIndex(e => e.ReportName, "UK_RD_Report_ReportName").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CaptionId).HasColumnName("CaptionID");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.FacilityCode).HasMaxLength(20);
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.Rdlfile)
                .HasColumnType("xml")
                .HasColumnName("RDLFile");
            entity.Property(e => e.ReportModuleId).HasColumnName("ReportModuleID");
            entity.Property(e => e.ReportName).HasMaxLength(100);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);

            entity.HasOne(d => d.Caption).WithMany(p => p.RdReports)
                .HasForeignKey(d => d.CaptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RD_Report_CaptionID_FD_Caption_ID");
        });

        modelBuilder.Entity<ScheduleException>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Schedule__3214EC0725FE8F47");

            entity.ToTable("ScheduleException");

            entity.HasIndex(e => e.ScheduleId, "IX_ScheduleException_ScheduleId");

            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExceptionType).HasMaxLength(50);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReasonCode).HasMaxLength(50);
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(20);

            entity.HasOne(d => d.Schedule).WithMany(p => p.ScheduleExceptions)
                .HasForeignKey(d => d.ScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ScheduleException_Schedule");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__1788CC4C3405AFD1");

            entity.HasIndex(e => e.Uhid, "AK_Users_UHID").IsUnique();

            entity.HasIndex(e => e.UserId, "AK_Users_UserId").IsUnique();

            entity.HasIndex(e => e.PhoneNumber, "UQ_Constraint_Phone").IsUnique();

            entity.HasIndex(e => e.UserId, "UQ_User_UserId").IsUnique();

            entity.HasIndex(e => e.Uhid, "UQ_Users_UHID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BirthOfDate).HasColumnType("datetime");
            entity.Property(e => e.CmndPassportNumberBirthCertificate)
                .HasMaxLength(100)
                .HasColumnName("CMND_PassportNumber_BirthCertificate");
            entity.Property(e => e.Country).HasMaxLength(10);
            entity.Property(e => e.Email).HasMaxLength(40);
            entity.Property(e => e.Gender).HasMaxLength(3);
            entity.Property(e => e.LastLoginFailedTime).HasColumnType("datetime");
            entity.Property(e => e.MyKadMyKidMyPr)
                .HasMaxLength(100)
                .HasColumnName("MyKad_MyKid_MyPR");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Nationality)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NomorKtpNomorPassporNomorSimNomorSuratLahir)
                .HasMaxLength(100)
                .HasColumnName("NomorKTP_NomorPasspor_NomorSIM_NomorSuratLahir");
            entity.Property(e => e.Passcode).HasMaxLength(100);
            entity.Property(e => e.PassportExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.PassportIssueCountry)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PassportNumber).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(12);
            entity.Property(e => e.PreferredName).HasMaxLength(50);
            entity.Property(e => e.ProfileImage).HasMaxLength(100);
            entity.Property(e => e.RegistrationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Salutation).HasMaxLength(100);
            entity.Property(e => e.SosbuttonEnabled).HasColumnName("SOSButtonEnabled");
            entity.Property(e => e.Uhid)
                .HasMaxLength(50)
                .HasColumnName("UHID");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<UserToken>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("PK__UserToke__658FEEEA1F5EA351");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpiresAt).HasColumnType("datetime");
            entity.Property(e => e.IsRevoked).HasDefaultValue(false);
            entity.Property(e => e.IssuedAt).HasColumnType("datetime");
            entity.Property(e => e.ModifiedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RevokedAt).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<WhatsHappening>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WhatsHap__3214EC073A4F56B7");

            entity.ToTable("WhatsHappening");

            entity.HasIndex(e => e.OrganizationId, "IX_WhatsHappening_OrganizationId");

            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ImageUrl).HasMaxLength(2000);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Url).HasMaxLength(2000);

            entity.HasOne(d => d.Organization).WithMany(p => p.WhatsHappenings)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("FK_WhatsHappening_Admin_Organizations");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
