using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Harsco.HTS.API.ArchiveModels
{
    public partial class Performance_ManagmentContextArchive : DbContext
    {
        public Performance_ManagmentContextArchive()
        {
        }

        public Performance_ManagmentContextArchive(DbContextOptions<Performance_ManagmentContextArchive> options)
            : base(options)
        {
        }

        public virtual DbSet<AppraisalApprovals> AppraisalApprovals { get; set; }
        public virtual DbSet<AppraisalAttachments> AppraisalAttachments { get; set; }
        public virtual DbSet<Appraisals> Appraisals { get; set; }
        public virtual DbSet<AwardsPatentsRecognitions> AwardsPatentsRecognitions { get; set; }
        public virtual DbSet<CareerAspiration> CareerAspiration { get; set; }
        public virtual DbSet<CareerInterestApprovals> CareerInterestApprovals { get; set; }
        public virtual DbSet<CareerInterests> CareerInterests { get; set; }
        public virtual DbSet<CommunicationsLog> CommunicationsLog { get; set; }
        public virtual DbSet<Competencies> Competencies { get; set; }
        public virtual DbSet<CompetencyApprovals> CompetencyApprovals { get; set; }
        public virtual DbSet<CompetencyComments> CompetencyComments { get; set; }
        public virtual DbSet<DevelopmentPlanApprovals> DevelopmentPlanApprovals { get; set; }
        public virtual DbSet<DevelopmentPlanComments> DevelopmentPlanComments { get; set; }
        public virtual DbSet<DevelopmentPlanDetails> DevelopmentPlanDetails { get; set; }
        public virtual DbSet<DevelopmentPlanStrengths> DevelopmentPlanStrengths { get; set; }
        public virtual DbSet<DevelopmentPlanWeaknesses> DevelopmentPlanWeaknesses { get; set; }
        public virtual DbSet<DevelopmentPlans> DevelopmentPlans { get; set; }
        public virtual DbSet<EducationalInstitutions> EducationalInstitutions { get; set; }
        public virtual DbSet<HumanResource> HumanResource { get; set; }
        public virtual DbSet<LicsCertsProfOrgs> LicsCertsProfOrgs { get; set; }
        public virtual DbSet<MidYear> MidYear { get; set; }
        public virtual DbSet<NextYearPreliminaryObjectives> NextYearPreliminaryObjectives { get; set; }
        public virtual DbSet<ObjectiveApprovals> ObjectiveApprovals { get; set; }
        public virtual DbSet<ObjectiveComments> ObjectiveComments { get; set; }
        public virtual DbSet<ObjectiveMilestones> ObjectiveMilestones { get; set; }
        public virtual DbSet<Objectives> Objectives { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<TrainingDevelopment> TrainingDevelopment { get; set; }
        public virtual DbSet<UnderstoodLanguages> UnderstoodLanguages { get; set; }
        public virtual DbSet<WorkExperienceDetails> WorkExperienceDetails { get; set; }
        public virtual DbSet<WorkExperiences> WorkExperiences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Harsco.HTS.connectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppraisalApprovals>(entity =>
            {
                entity.HasKey(e => e.ArchiveAppraisalApprovalId);

                entity.ToTable("AppraisalApprovals", "Archive");

                entity.Property(e => e.ArchiveAppraisalApprovalId).HasColumnName("ArchiveAppraisalApprovalID");

                entity.Property(e => e.ApprovalStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ApproverId)
                    .IsRequired()
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20);

                entity.Property(e => e.ApproverName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ArchiveAppraisalId).HasColumnName("ArchiveAppraisalID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalAppraisalApprovalId).HasColumnName("OriginalAppraisalApprovalID");

                entity.Property(e => e.StatusChangedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ArchiveAppraisal)
                    .WithMany(p => p.AppraisalApprovals)
                    .HasForeignKey(d => d.ArchiveAppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppraisalApproval_Appraisals_Archive");
            });

            modelBuilder.Entity<AppraisalAttachments>(entity =>
            {
                entity.HasKey(e => e.ArchiveAppraisalAttachmentId);

                entity.ToTable("AppraisalAttachments", "Archive");

                entity.Property(e => e.ArchiveAppraisalAttachmentId).HasColumnName("ArchiveAppraisalAttachmentID");

                entity.Property(e => e.ArchiveAppraisalId).HasColumnName("ArchiveAppraisalID");

                entity.Property(e => e.Attachment)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalAppraisalAttachmentId).HasColumnName("OriginalAppraisalAttachmentID");

                entity.HasOne(d => d.ArchiveAppraisal)
                    .WithMany(p => p.AppraisalAttachments)
                    .HasForeignKey(d => d.ArchiveAppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppraisalAttachments_Appraisals_Archive");
            });

            modelBuilder.Entity<Appraisals>(entity =>
            {
                entity.HasKey(e => e.ArchiveAppraisalId);

                entity.ToTable("Appraisals", "Archive");

                entity.Property(e => e.ArchiveAppraisalId).HasColumnName("ArchiveAppraisalID");

                entity.Property(e => e.AppraisalType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Cocviolation)
                    .HasColumnName("COCViolation")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CompetencyComment).HasColumnType("ntext");

                entity.Property(e => e.CompetencyRating).HasColumnType("ntext");

                entity.Property(e => e.EmployeeComment).HasColumnType("ntext");

                entity.Property(e => e.EmployeeName).HasMaxLength(75);

                entity.Property(e => e.EmployeeSignDate).HasColumnType("datetime");

                entity.Property(e => e.ManagerComment).HasColumnType("ntext");

                entity.Property(e => e.ManagerMeeting)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerName).HasMaxLength(75);

                entity.Property(e => e.ManagerSignDate).HasColumnType("datetime");

                entity.Property(e => e.ManagersManagerName).HasMaxLength(75);

                entity.Property(e => e.ManagersManagerSignDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjectiveComment).HasColumnType("ntext");

                entity.Property(e => e.OriginalAppraisalId).HasColumnName("OriginalAppraisalID");

                entity.Property(e => e.OverallRating).HasColumnType("ntext");

                entity.Property(e => e.PerformanceRating).HasColumnType("ntext");

                entity.Property(e => e.ReviewDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SkillComment).HasColumnType("ntext");
            });

            modelBuilder.Entity<AwardsPatentsRecognitions>(entity =>
            {
                entity.HasKey(e => e.ArchiveAwardPatentRecognitionId)
                    .HasName("PK_AwardPatentRecognitions");

                entity.ToTable("AwardsPatentsRecognitions", "Archive");

                entity.Property(e => e.ArchiveAwardPatentRecognitionId).HasColumnName("ArchiveAwardPatentRecognitionID");

                entity.Property(e => e.ArchiveProfileId).HasColumnName("ArchiveProfileID");

                entity.Property(e => e.DateReceived)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalAwardPatentRecognitionId).HasColumnName("OriginalAwardPatentRecognitionID");

                entity.Property(e => e.ReferenceNumber).HasMaxLength(20);

                entity.HasOne(d => d.ArchiveProfile)
                    .WithMany(p => p.AwardsPatentsRecognitions)
                    .HasForeignKey(d => d.ArchiveProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AwardPatentRecognitions_Profiles");
            });

            modelBuilder.Entity<CareerAspiration>(entity =>
            {
                entity.HasKey(e => e.ArchiveCareerAspirationId)
                    .HasName("PK_CareerAspiration_3");

                entity.ToTable("CareerAspiration", "Archive");

                entity.Property(e => e.Aspiration)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CareerInterestApprovals>(entity =>
            {
                entity.HasKey(e => e.ArchiveCareerInterestApprovalId);

                entity.ToTable("CareerInterestApprovals", "Archive");

                entity.Property(e => e.ArchiveCareerInterestApprovalId).HasColumnName("ArchiveCareerInterestApprovalID");

                entity.Property(e => e.ApprovalStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ApproverId)
                    .IsRequired()
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20);

                entity.Property(e => e.ApproverName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ArchiveCareerInterestId).HasColumnName("ArchiveCareerInterestID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalCareerInterestApprovalId).HasColumnName("OriginalCareerInterestApprovalID");

                entity.Property(e => e.StatusChangeDate).HasColumnType("datetime");

                entity.HasOne(d => d.ArchiveCareerInterest)
                    .WithMany(p => p.CareerInterestApprovals)
                    .HasForeignKey(d => d.ArchiveCareerInterestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareerInterestApprovals_CareerInterests");
            });

            modelBuilder.Entity<CareerInterests>(entity =>
            {
                entity.HasKey(e => e.ArchiveCareerInterestId);

                entity.ToTable("CareerInterests", "Archive");

                entity.Property(e => e.ArchiveCareerInterestId).HasColumnName("ArchiveCareerInterestID");

                entity.Property(e => e.ArchiveProfileId).HasColumnName("ArchiveProfileID");

                entity.Property(e => e.CareerInterestTiming)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.JobFamily)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalCareerInterestId).HasColumnName("OriginalCareerInterestID");

                entity.Property(e => e.WillingToRelocate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ArchiveProfile)
                    .WithMany(p => p.CareerInterests)
                    .HasForeignKey(d => d.ArchiveProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareerInterests_Profiles");
            });

            modelBuilder.Entity<CommunicationsLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CommunicationsLog", "Archive");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CommunicationsLogId).HasColumnName("CommunicationsLogID");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Recipients)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Competencies>(entity =>
            {
                entity.HasKey(e => e.ArchiveCompetencyId);

                entity.ToTable("Competencies", "Archive");

                entity.Property(e => e.ArchiveCompetencyId).HasColumnName("ArchiveCompetencyID");

                entity.Property(e => e.ArchiveAppraisalId).HasColumnName("ArchiveAppraisalID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmployeeSkillRating).HasMaxLength(50);

                entity.Property(e => e.EnterpriseCompetency)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ManagerSkillRating)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalCompetencyId).HasColumnName("OriginalCompetencyID");

                entity.HasOne(d => d.ArchiveAppraisal)
                    .WithMany(p => p.Competencies)
                    .HasForeignKey(d => d.ArchiveAppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competencies_Appraisals");
            });

            modelBuilder.Entity<CompetencyApprovals>(entity =>
            {
                entity.HasKey(e => e.ArchiveCompetencyApprovalId);

                entity.ToTable("CompetencyApprovals", "Archive");

                entity.Property(e => e.ArchiveCompetencyApprovalId).HasColumnName("ArchiveCompetencyApprovalID");

                entity.Property(e => e.ApprovalStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ApproverId)
                    .IsRequired()
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20);

                entity.Property(e => e.ApproverName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ArchiveCompetencyId).HasColumnName("ArchiveCompetencyID");

                entity.Property(e => e.ArchiveSkillId).HasColumnName("ArchiveSkillID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalCompetencyApprovalId).HasColumnName("OriginalCompetencyApprovalID");

                entity.Property(e => e.StatusChangedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ArchiveCompetency)
                    .WithMany(p => p.CompetencyApprovals)
                    .HasForeignKey(d => d.ArchiveCompetencyId)
                    .HasConstraintName("FK_CompetencyApprovals_Competencies");

                entity.HasOne(d => d.ArchiveSkill)
                    .WithMany(p => p.CompetencyApprovals)
                    .HasForeignKey(d => d.ArchiveSkillId)
                    .HasConstraintName("FK_CompetencyApprovals_Skills");
            });

            modelBuilder.Entity<CompetencyComments>(entity =>
            {
                entity.HasKey(e => e.ArchiveCompetencyCommentId);

                entity.ToTable("CompetencyComments", "Archive");

                entity.Property(e => e.ArchiveCompetencyCommentId).HasColumnName("ArchiveCompetencyCommentID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ManagerComment)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalCompetencyCommentId).HasColumnName("OriginalCompetencyCommentID");
            });

            modelBuilder.Entity<DevelopmentPlanApprovals>(entity =>
            {
                entity.HasKey(e => e.ArchiveDevelopmentPlanApprovalId);

                entity.ToTable("DevelopmentPlanApprovals", "Archive");

                entity.Property(e => e.ArchiveDevelopmentPlanApprovalId).HasColumnName("ArchiveDevelopmentPlanApprovalID");

                entity.Property(e => e.ApprovalStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ApproverId)
                    .IsRequired()
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20);

                entity.Property(e => e.ApproverName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ArchiveDevelopmentPlanDetailId).HasColumnName("ArchiveDevelopmentPlanDetailID");

                entity.Property(e => e.ArchiveDevelopmentPlanStrengthId).HasColumnName("ArchiveDevelopmentPlanStrengthID");

                entity.Property(e => e.ArchiveDevelopmentPlanWeaknessId).HasColumnName("ArchiveDevelopmentPlanWeaknessID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalDevelopmentPlanApprovalId).HasColumnName("OriginalDevelopmentPlanApprovalID");

                entity.Property(e => e.StatusChangedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ArchiveDevelopmentPlanDetail)
                    .WithMany(p => p.DevelopmentPlanApprovals)
                    .HasForeignKey(d => d.ArchiveDevelopmentPlanDetailId)
                    .HasConstraintName("FK_DevelopmentPlanApprovals_DevelopmentPlanDetails");

                entity.HasOne(d => d.ArchiveDevelopmentPlanStrength)
                    .WithMany(p => p.DevelopmentPlanApprovals)
                    .HasForeignKey(d => d.ArchiveDevelopmentPlanStrengthId)
                    .HasConstraintName("FK_DevelopmentPlanApprovals_DevelopmentPlanStrengths");

                entity.HasOne(d => d.ArchiveDevelopmentPlanWeakness)
                    .WithMany(p => p.DevelopmentPlanApprovals)
                    .HasForeignKey(d => d.ArchiveDevelopmentPlanWeaknessId)
                    .HasConstraintName("FK_DevelopmentPlanApprovals_DevelopmentPlanWeaknesses");
            });

            modelBuilder.Entity<DevelopmentPlanComments>(entity =>
            {
                entity.HasKey(e => e.ArchiveDevelopmentPlanCommentId);

                entity.ToTable("DevelopmentPlanComments", "Archive");

                entity.Property(e => e.ArchiveDevelopmentPlanCommentId).HasColumnName("ArchiveDevelopmentPlanCommentID");

                entity.Property(e => e.ArchiveDevelopmentPlanDetailId).HasColumnName("ArchiveDevelopmentPlanDetailID");

                entity.Property(e => e.ArchiveDevelopmentPlanStrengthId).HasColumnName("ArchiveDevelopmentPlanStrengthID");

                entity.Property(e => e.ArchiveDevelopmentPlanWeaknessId).HasColumnName("ArchiveDevelopmentPlanWeaknessID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CommentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalDevelopmentPlanCommentId).HasColumnName("OriginalDevelopmentPlanCommentID");

                entity.HasOne(d => d.ArchiveDevelopmentPlanDetail)
                    .WithMany(p => p.DevelopmentPlanComments)
                    .HasForeignKey(d => d.ArchiveDevelopmentPlanDetailId)
                    .HasConstraintName("FK_DevelopmentPlanComments_DevelopmentPlanDetails");

                entity.HasOne(d => d.ArchiveDevelopmentPlanStrength)
                    .WithMany(p => p.DevelopmentPlanComments)
                    .HasForeignKey(d => d.ArchiveDevelopmentPlanStrengthId)
                    .HasConstraintName("FK_DevelopmentPlanComments_DevelopmentPlanStrengths");

                entity.HasOne(d => d.ArchiveDevelopmentPlanWeakness)
                    .WithMany(p => p.DevelopmentPlanComments)
                    .HasForeignKey(d => d.ArchiveDevelopmentPlanWeaknessId)
                    .HasConstraintName("FK_DevelopmentPlanComments_DevelopmentPlanWeaknesses");
            });

            modelBuilder.Entity<DevelopmentPlanDetails>(entity =>
            {
                entity.HasKey(e => e.ArchiveDevelopmentPlanDetailId);

                entity.ToTable("DevelopmentPlanDetails", "Archive");

                entity.Property(e => e.ArchiveDevelopmentPlanDetailId).HasColumnName("ArchiveDevelopmentPlanDetailID");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ArchiveDevelopmentPlanId).HasColumnName("ArchiveDevelopmentPlanID");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.DateDue).HasColumnType("smalldatetime");

                entity.Property(e => e.MeasurementProcess)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Objective)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.OriginalDevelopmentPlanDetailId).HasColumnName("OriginalDevelopmentPlanDetailID");

                entity.Property(e => e.SupportRequired)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.ArchiveDevelopmentPlan)
                    .WithMany(p => p.DevelopmentPlanDetails)
                    .HasForeignKey(d => d.ArchiveDevelopmentPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentPlanDetails_DevelopmentPlans");
            });

            modelBuilder.Entity<DevelopmentPlanStrengths>(entity =>
            {
                entity.HasKey(e => e.ArchiveDevelopmentPlanStrengthId);

                entity.ToTable("DevelopmentPlanStrengths", "Archive");

                entity.Property(e => e.ArchiveDevelopmentPlanStrengthId).HasColumnName("ArchiveDevelopmentPlanStrengthID");

                entity.Property(e => e.ArchiveDevelopmentPlanId).HasColumnName("ArchiveDevelopmentPlanID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalDevelopmentPlanStrengthId).HasColumnName("OriginalDevelopmentPlanStrengthID");

                entity.Property(e => e.Strength)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.ArchiveDevelopmentPlan)
                    .WithMany(p => p.DevelopmentPlanStrengths)
                    .HasForeignKey(d => d.ArchiveDevelopmentPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentPlanStrengths_DevelopmentPlans");
            });

            modelBuilder.Entity<DevelopmentPlanWeaknesses>(entity =>
            {
                entity.HasKey(e => e.ArchiveDevelopmentPlanWeaknessId);

                entity.ToTable("DevelopmentPlanWeaknesses", "Archive");

                entity.Property(e => e.ArchiveDevelopmentPlanWeaknessId).HasColumnName("ArchiveDevelopmentPlanWeaknessID");

                entity.Property(e => e.ArchiveDevelopmentPlanId).HasColumnName("ArchiveDevelopmentPlanID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalDevelopmentPlanWeaknessId).HasColumnName("OriginalDevelopmentPlanWeaknessID");

                entity.Property(e => e.Weakness)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.ArchiveDevelopmentPlan)
                    .WithMany(p => p.DevelopmentPlanWeaknesses)
                    .HasForeignKey(d => d.ArchiveDevelopmentPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentPlanWeaknesses_DevelopmentPlans");
            });

            modelBuilder.Entity<DevelopmentPlans>(entity =>
            {
                entity.HasKey(e => e.ArchiveDevelopmentPlanId);

                entity.ToTable("DevelopmentPlans", "Archive");

                entity.Property(e => e.ArchiveDevelopmentPlanId).HasColumnName("ArchiveDevelopmentPlanID");

                entity.Property(e => e.ArchiveAppraisalId).HasColumnName("ArchiveAppraisalID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalDevelopmentPlanId).HasColumnName("OriginalDevelopmentPlanID");

                entity.HasOne(d => d.ArchiveAppraisal)
                    .WithMany(p => p.DevelopmentPlans)
                    .HasForeignKey(d => d.ArchiveAppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentPlans_Appraisals");
            });

            modelBuilder.Entity<EducationalInstitutions>(entity =>
            {
                entity.HasKey(e => e.ArchiveEducationalInstitutionId);

                entity.ToTable("EducationalInstitutions", "Archive");

                entity.Property(e => e.ArchiveEducationalInstitutionId).HasColumnName("ArchiveEducationalInstitutionID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ArchiveProfileId).HasColumnName("ArchiveProfileID");

                entity.Property(e => e.DegreeObtainedOther).HasMaxLength(75);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.EducationalDegree)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.InstitutionName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalEducationalInstitutionId).HasColumnName("OriginalEducationalInstitutionID");

                entity.HasOne(d => d.ArchiveProfile)
                    .WithMany(p => p.EducationalInstitutions)
                    .HasForeignKey(d => d.ArchiveProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalInstitutions_Profiles");
            });

            modelBuilder.Entity<HumanResource>(entity =>
            {
                entity.HasKey(e => e.ArchiveId)
                    .HasName("PK_HumanResource_1");

                entity.ToTable("HumanResource", "Archive");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SendToHr).HasColumnType("datetime");

                entity.Property(e => e.SendToManager).HasColumnType("datetime");
            });

            modelBuilder.Entity<LicsCertsProfOrgs>(entity =>
            {
                entity.HasKey(e => e.ArchiveLicCertProfOrgId);

                entity.ToTable("LicsCertsProfOrgs", "Archive");

                entity.Property(e => e.ArchiveLicCertProfOrgId).HasColumnName("ArchiveLicCertProfOrgID");

                entity.Property(e => e.ArchiveProfileId).HasColumnName("ArchiveProfileID");

                entity.Property(e => e.CertificationNumber).HasMaxLength(20);

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseCategory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LicenseNumber).HasMaxLength(20);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalLicCertProfOrgId).HasColumnName("OriginalLicCertProfOrgID");

                entity.Property(e => e.ProfessionalOrganizationName).HasMaxLength(50);

                entity.HasOne(d => d.ArchiveProfile)
                    .WithMany(p => p.LicsCertsProfOrgs)
                    .HasForeignKey(d => d.ArchiveProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicsCertsProfOrgs_Profiles");
            });

            modelBuilder.Entity<MidYear>(entity =>
            {
                entity.HasKey(e => e.ArchiveMidYear)
                    .HasName("PK_MidYear_1");

                entity.ToTable("MidYear", "Archive");

                entity.Property(e => e.AppraisalTypeId).HasColumnName("AppraisalTypeID");

                entity.Property(e => e.ArchivedProfileId).HasColumnName("ArchivedProfileID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpDevelopmentPlan).HasColumnType("ntext");

                entity.Property(e => e.EmpObjective).HasColumnType("ntext");

                entity.Property(e => e.EmpSignDate).HasColumnType("datetime");

                entity.Property(e => e.EmpValueBehavior).HasColumnType("ntext");

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

                entity.Property(e => e.ManagerName).HasMaxLength(100);

                entity.Property(e => e.MgrDevelopmentPlan).HasColumnType("ntext");

                entity.Property(e => e.MgrObjective).HasColumnType("ntext");

                entity.Property(e => e.MgrSignDate).HasColumnType("datetime");

                entity.Property(e => e.MgrValueBehavior).HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OriginalMidYearId).HasColumnName("OriginalMidYearID");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NextYearPreliminaryObjectives>(entity =>
            {
                entity.HasKey(e => e.ArchiveId)
                    .HasName("PK_NextYearPreliminaryObjectives_1");

                entity.ToTable("NextYearPreliminaryObjectives", "Archive");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NextYearObjectives)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ObjectiveApprovals>(entity =>
            {
                entity.HasKey(e => e.ArchiveObjectiveApprovalId)
                    .HasName("PK_ObjectiveApprovals_1");

                entity.ToTable("ObjectiveApprovals", "Archive");

                entity.Property(e => e.ArchiveObjectiveApprovalId).HasColumnName("ArchiveObjectiveApprovalID");

                entity.Property(e => e.ApprovalStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ApproverId)
                    .IsRequired()
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20);

                entity.Property(e => e.ApproverName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ArchiveObjectiveId).HasColumnName("ArchiveObjectiveID");

                entity.Property(e => e.ArchiveObjectiveMilestoneId).HasColumnName("ArchiveObjectiveMilestoneID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalObjectiveApprovalId).HasColumnName("OriginalObjectiveApprovalID");

                entity.Property(e => e.StatusChangedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ArchiveObjective)
                    .WithMany(p => p.ObjectiveApprovals)
                    .HasForeignKey(d => d.ArchiveObjectiveId)
                    .HasConstraintName("FK_ObjectiveApprovals_Objectives");

                entity.HasOne(d => d.ArchiveObjectiveMilestone)
                    .WithMany(p => p.ObjectiveApprovals)
                    .HasForeignKey(d => d.ArchiveObjectiveMilestoneId)
                    .HasConstraintName("FK_ObjectiveApprovals_ObjectiveMilestones");
            });

            modelBuilder.Entity<ObjectiveComments>(entity =>
            {
                entity.HasKey(e => e.ArchiveObjectiveCommentId)
                    .HasName("PK_ObjectiveComments_1");

                entity.ToTable("ObjectiveComments", "Archive");

                entity.Property(e => e.ArchiveObjectiveCommentId).HasColumnName("ArchiveObjectiveCommentID");

                entity.Property(e => e.ArchiveObjectiveId).HasColumnName("ArchiveObjectiveID");

                entity.Property(e => e.ArchiveObjectiveMilestoneId).HasColumnName("ArchiveObjectiveMilestoneID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CommentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalObjectiveCommentId).HasColumnName("OriginalObjectiveCommentID");

                entity.HasOne(d => d.ArchiveObjective)
                    .WithMany(p => p.ObjectiveComments)
                    .HasForeignKey(d => d.ArchiveObjectiveId)
                    .HasConstraintName("FK_ObjectiveComments_Objectives");

                entity.HasOne(d => d.ArchiveObjectiveMilestone)
                    .WithMany(p => p.ObjectiveComments)
                    .HasForeignKey(d => d.ArchiveObjectiveMilestoneId)
                    .HasConstraintName("FK_ObjectiveComments_ObjectiveMilestones");
            });

            modelBuilder.Entity<ObjectiveMilestones>(entity =>
            {
                entity.HasKey(e => e.ArchiveObjectiveMilestoneId)
                    .HasName("PK_ObjectiveMilestones_1");

                entity.ToTable("ObjectiveMilestones", "Archive");

                entity.Property(e => e.ArchiveObjectiveMilestoneId).HasColumnName("ArchiveObjectiveMilestoneID");

                entity.Property(e => e.ArchiveObjectiveId).HasColumnName("ArchiveObjectiveID");

                entity.Property(e => e.DateDue).HasColumnType("smalldatetime");

                entity.Property(e => e.MilestoneStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalObjectiveMilestoneId).HasColumnName("OriginalObjectiveMilestoneID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ArchiveObjective)
                    .WithMany(p => p.ObjectiveMilestones)
                    .HasForeignKey(d => d.ArchiveObjectiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ObjectiveMilestones_Objectives");
            });

            modelBuilder.Entity<Objectives>(entity =>
            {
                entity.HasKey(e => e.ArchiveObjectiveId)
                    .HasName("PK_Objectives_1");

                entity.ToTable("Objectives", "Archive");

                entity.Property(e => e.ArchiveObjectiveId).HasColumnName("ArchiveObjectiveID");

                entity.Property(e => e.Achieved)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArchiveAppraisalId).HasColumnName("ArchiveAppraisalID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateDue).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ManagerAchieved)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ManagerYearEndResults)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalObjectiveId).HasColumnName("OriginalObjectiveID");

                entity.Property(e => e.YearEndResults)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.ArchiveAppraisal)
                    .WithMany(p => p.Objectives)
                    .HasForeignKey(d => d.ArchiveAppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Objectives_Appraisals");
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.HasKey(e => e.ArchiveProfileId);

                entity.ToTable("Profiles", "Archive");

                entity.Property(e => e.ArchiveProfileId).HasColumnName("ArchiveProfileID");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.ArchiveAppraisalId).HasColumnName("ArchiveAppraisalID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DateHired).HasColumnType("smalldatetime");

                entity.Property(e => e.DivisionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeNumber).HasMaxLength(20);

                entity.Property(e => e.JobFamilyName).HasMaxLength(255);

                entity.Property(e => e.JobTitle).HasMaxLength(255);

                entity.Property(e => e.LocationName).HasMaxLength(255);

                entity.Property(e => e.ManagerName).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasColumnName("NetworkID")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginalProfileId).HasColumnName("OriginalProfileID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.TerminationDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.ArchiveAppraisal)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.ArchiveAppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Profiles_Appraisals");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.HasKey(e => e.ArchiveSkillId);

                entity.ToTable("Skills", "Archive");

                entity.Property(e => e.ArchiveSkillId).HasColumnName("ArchiveSkillID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EnterpriseCompetencies)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalSkillId).HasColumnName("OriginalSkillID");

                entity.HasOne(d => d.ArchiveProfile)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.ArchiveProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_Appraisals");
            });

            modelBuilder.Entity<TrainingDevelopment>(entity =>
            {
                entity.HasKey(e => e.ArchiveTrainingDevelopmentId)
                    .HasName("PK_TrainingDevelopment_1");

                entity.ToTable("TrainingDevelopment", "Archive");

                entity.Property(e => e.ArchiveTrainingDevelopmentId).HasColumnName("ArchiveTrainingDevelopmentID");

                entity.Property(e => e.ArchiveProfileId).HasColumnName("ArchiveProfileID");

                entity.Property(e => e.CertificationNumber).HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalTrainingDevelopmentId).HasColumnName("OriginalTrainingDevelopmentID");

                entity.Property(e => e.TrainingCategory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ArchiveProfile)
                    .WithMany(p => p.TrainingDevelopment)
                    .HasForeignKey(d => d.ArchiveProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingDevelopment_Profiles");
            });

            modelBuilder.Entity<UnderstoodLanguages>(entity =>
            {
                entity.HasKey(e => e.ArchiveUnderstoodLanguageId)
                    .HasName("PK_UnderstoodLanguages_1");

                entity.ToTable("UnderstoodLanguages", "Archive");

                entity.Property(e => e.ArchiveUnderstoodLanguageId).HasColumnName("ArchiveUnderstoodLanguageID");

                entity.Property(e => e.ArchiveProfileId).HasColumnName("ArchiveProfileID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageFluency)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalUnderstoodLanguageId).HasColumnName("OriginalUnderstoodLanguageID");

                entity.HasOne(d => d.ArchiveProfile)
                    .WithMany(p => p.UnderstoodLanguages)
                    .HasForeignKey(d => d.ArchiveProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnderstoodLanguages_Profiles");
            });

            modelBuilder.Entity<WorkExperienceDetails>(entity =>
            {
                entity.HasKey(e => e.ArchiveWorkExperienceDetailId)
                    .HasName("PK_WorkExperienceDetails_1");

                entity.ToTable("WorkExperienceDetails", "Archive");

                entity.Property(e => e.ArchiveWorkExperienceDetailId).HasColumnName("ArchiveWorkExperienceDetailID");

                entity.Property(e => e.ArchiveWorkExperienceId).HasColumnName("ArchiveWorkExperienceID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalWorkExperienceDetailId).HasColumnName("OriginalWorkExperienceDetailID");

                entity.Property(e => e.Responsibilities)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.HasOne(d => d.ArchiveWorkExperience)
                    .WithMany(p => p.WorkExperienceDetails)
                    .HasForeignKey(d => d.ArchiveWorkExperienceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkExperienceDetails_WorkExperiences");
            });

            modelBuilder.Entity<WorkExperiences>(entity =>
            {
                entity.HasKey(e => e.ArchiveWorkExperienceId)
                    .HasName("PK_WorkExperiences_1");

                entity.ToTable("WorkExperiences", "Archive");

                entity.Property(e => e.ArchiveWorkExperienceId).HasColumnName("ArchiveWorkExperienceID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ArchiveProfileId).HasColumnName("ArchiveProfileID");

                entity.Property(e => e.DateEmploymentEnded).HasColumnType("smalldatetime");

                entity.Property(e => e.DateEmploymentStarted).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployerName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OriginalWorkExperienceId).HasColumnName("OriginalWorkExperienceID");

                entity.HasOne(d => d.ArchiveProfile)
                    .WithMany(p => p.WorkExperiences)
                    .HasForeignKey(d => d.ArchiveProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkExperiences_Profiles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
