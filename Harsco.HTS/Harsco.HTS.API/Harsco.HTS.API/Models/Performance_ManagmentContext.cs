using Harsco.HTS.API.Models.Harsco.HTS.API.Models;
using Harsco.HTS.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Harsco.HTS.API.Models
{
    public partial class Performance_ManagmentContextDbo : DbContext
    {
        public Performance_ManagmentContextDbo()
        {
        }
        public Performance_ManagmentContextDbo(DbContextOptions<Performance_ManagmentContextDbo> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityLoop> ActivityLoop { get; set; }
        public virtual DbSet<AppraisalApprovals> AppraisalApprovals { get; set; }
        public virtual DbSet<AppraisalAttachments> AppraisalAttachments { get; set; }
        public virtual DbSet<AppraisalRatings> AppraisalRatings { get; set; }
        public virtual DbSet<AppraisalTypes> AppraisalTypes { get; set; }
        public virtual DbSet<Appraisals> Appraisals { get; set; }
        public virtual DbSet<ApprovalStatuses> ApprovalStatuses { get; set; }
        public virtual DbSet<AwardsPatentsRecognitions> AwardsPatentsRecognitions { get; set; }
        public virtual DbSet<BusinessGroups> BusinessGroups { get; set; }
        public virtual DbSet<BusinessUnits> BusinessUnits { get; set; }
        public virtual DbSet<CareerAspiration> CareerAspiration { get; set; }
        public virtual DbSet<CareerInterestApprovals> CareerInterestApprovals { get; set; }
        public virtual DbSet<CareerInterestTiming> CareerInterestTiming { get; set; }
        public virtual DbSet<CareerInterests> CareerInterests { get; set; }
        public virtual DbSet<CareerInterestsJobFamily> CareerInterestsJobFamily { get; set; }
        public virtual DbSet<CommentTypes> CommentTypes { get; set; }
        public virtual DbSet<CommunicationsLog> CommunicationsLog { get; set; }
        public virtual DbSet<Competencies> Competencies { get; set; }
        public virtual DbSet<CompetenciesView> CompetenciesView { get; set; }
        public virtual DbSet<CompetencyApprovals> CompetencyApprovals { get; set; }
        public virtual DbSet<CompetencyComments> CompetencyComments { get; set; }
        public virtual DbSet<CompetencySkillRatings> CompetencySkillRatings { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryLanguage> CountryLanguage { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DevelopmentLoop> DevelopmentLoop { get; set; }
        public virtual DbSet<DevelopmentPlanApprovals> DevelopmentPlanApprovals { get; set; }
        public virtual DbSet<DevelopmentPlanComments> DevelopmentPlanComments { get; set; }
        public virtual DbSet<DevelopmentPlanCompletion> DevelopmentPlanCompletion { get; set; }
        public virtual DbSet<DevelopmentPlanDetails> DevelopmentPlanDetails { get; set; }
        public virtual DbSet<DevelopmentPlanStrengths> DevelopmentPlanStrengths { get; set; }
        public virtual DbSet<DevelopmentPlanWeaknesses> DevelopmentPlanWeaknesses { get; set; }
        public virtual DbSet<DevelopmentPlans> DevelopmentPlans { get; set; }
        public virtual DbSet<DevelopmentalCompetencies> DevelopmentalCompetencies { get; set; }
        public virtual DbSet<DivisionAka> DivisionAka { get; set; }
        public virtual DbSet<Divisions> Divisions { get; set; }
        public virtual DbSet<DuplicateAd> DuplicateAd { get; set; }
        public virtual DbSet<EducationalDegrees> EducationalDegrees { get; set; }
        public virtual DbSet<EducationalInstitutions> EducationalInstitutions { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EnterpriseCompetencies> EnterpriseCompetencies { get; set; }
        public virtual DbSet<EnterprizeLanguage> EnterprizeLanguage { get; set; }
        public virtual DbSet<ExcludeFromHr> ExcludeFromHr { get; set; }
        public virtual DbSet<GisHeadCount> GisHeadCount { get; set; }
        public virtual DbSet<GisHeadCountCanNotFind> GisHeadCountCanNotFind { get; set; }
        public virtual DbSet<GisHeadCountImport> GisHeadCountImport { get; set; }
        public virtual DbSet<GisexcludeJobTitles> GisexcludeJobTitles { get; set; }
        public virtual DbSet<HeadCountErrorLog> HeadCountErrorLog { get; set; }
        public virtual DbSet<Headcount> Headcount { get; set; }
        public virtual DbSet<HritfeedErrorLog> HritfeedErrorLog { get; set; }
        public virtual DbSet<Hrpermissions> Hrpermissions { get; set; }
        public virtual DbSet<HrpermissionsNew> HrpermissionsNew { get; set; }
        public virtual DbSet<Hrusers> Hrusers { get; set; }
        public virtual DbSet<HrusersNew> HrusersNew { get; set; }
        public virtual DbSet<HumanResource> HumanResource { get; set; }
        public virtual DbSet<Institutions> Institutions { get; set; }
        public virtual DbSet<ItalianMissingTranslation> ItalianMissingTranslation { get; set; }
        public virtual DbSet<JobFamily> JobFamily { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }
        public virtual DbSet<LanguageFluency> LanguageFluency { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LicenseCategories> LicenseCategories { get; set; }
        public virtual DbSet<LicsCertsProfOrgs> LicsCertsProfOrgs { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<MidYear> MidYear { get; set; }
        public virtual DbSet<MidYearEmpMgrDevPlan> MidYearEmpMgrDevPlan { get; set; }
        public virtual DbSet<MidYearEmpMgrValues> MidYearEmpMgrValues { get; set; }
        public virtual DbSet<MilestoneStatus> MilestoneStatus { get; set; }
        public virtual DbSet<NextYearPreliminaryObjectives> NextYearPreliminaryObjectives { get; set; }
        public virtual DbSet<NotRequiredReview> NotRequiredReview { get; set; }
        public virtual DbSet<ObjectiveAchieved> ObjectiveAchieved { get; set; }
        public virtual DbSet<ObjectiveApprovals> ObjectiveApprovals { get; set; }
        public virtual DbSet<ObjectiveComments> ObjectiveComments { get; set; }
        public virtual DbSet<ObjectiveMilestones> ObjectiveMilestones { get; set; }
        public virtual DbSet<Objectives> Objectives { get; set; }
        public virtual DbSet<ObjectivesNeededVerna> ObjectivesNeededVerna { get; set; }
        public virtual DbSet<PointOfEntry> PointOfEntry { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<ProfilesManagerRemoved> ProfilesManagerRemoved { get; set; }
        public virtual DbSet<ProfilesRemoved> ProfilesRemoved { get; set; }
        public virtual DbSet<ProfilesRemoved2> ProfilesRemoved2 { get; set; }
        public virtual DbSet<ProfilesRemoved201710425> ProfilesRemoved201710425 { get; set; }
        public virtual DbSet<ReportMaster> ReportMaster { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<vmSkills> vmSkills { get; set; }

        
        public virtual DbSet<TblBireportLink> TblBireportLink { get; set; }
        public virtual DbSet<TblBlastEmailPicks> TblBlastEmailPicks { get; set; }
        public virtual DbSet<TblCountries> TblCountries { get; set; }
        public virtual DbSet<TblErrors> TblErrors { get; set; }
        public virtual DbSet<TblHritmasterData> TblHritmasterData { get; set; }
        public virtual DbSet<TemporaryDirectReports> TemporaryDirectReports { get; set; }
        public virtual DbSet<TestHumanResource> TestHumanResource { get; set; }
        public virtual DbSet<TestNextWrongappraisalFixes> TestNextWrongappraisalFixes { get; set; }
        public virtual DbSet<TestTermiatedateFixes> TestTermiatedateFixes { get; set; }
        public virtual DbSet<TestWrongManagerFixes> TestWrongManagerFixes { get; set; }
        public virtual DbSet<TestWrongappraisalFixes> TestWrongappraisalFixes { get; set; }
        public virtual DbSet<TestZcity> TestZcity { get; set; }
        public virtual DbSet<TestZcountry> TestZcountry { get; set; }
        public virtual DbSet<TestZemployees> TestZemployees { get; set; }
        public virtual DbSet<TestZmasDepartment> TestZmasDepartment { get; set; }
        public virtual DbSet<TestZmasEmployee> TestZmasEmployee { get; set; }
        public virtual DbSet<TestZstudents> TestZstudents { get; set; }
        public virtual DbSet<ToolTips> ToolTips { get; set; }
        public virtual DbSet<TrainingCategories> TrainingCategories { get; set; }
        public virtual DbSet<TrainingDevelopment> TrainingDevelopment { get; set; }
        public virtual DbSet<TranslationLanguages> TranslationLanguages { get; set; }
        public virtual DbSet<Translations> Translations { get; set; }
        public virtual DbSet<UnderstoodLanguages> UnderstoodLanguages { get; set; }
        public virtual DbSet<VwBusinessUnits> VwBusinessUnits { get; set; }
        public virtual DbSet<VwCountries> VwCountries { get; set; }
        public virtual DbSet<VwCountriesTest> VwCountriesTest { get; set; }
        public virtual DbSet<VwDepartments> VwDepartments { get; set; }
        public virtual DbSet<VwDivisionAliases> VwDivisionAliases { get; set; }
        public virtual DbSet<VwDivisions> VwDivisions { get; set; }
        public virtual DbSet<VwLanguages> VwLanguages { get; set; }
        public virtual DbSet<VwLocations> VwLocations { get; set; }
        public virtual DbSet<WillingToRelocate> WillingToRelocate { get; set; }
        public virtual DbSet<WorkExperienceDetails> WorkExperienceDetails { get; set; }
        public virtual DbSet<WorkExperiences> WorkExperiences { get; set; }
        public virtual DbSet<ZTblTest> ZTblTest { get; set; }
        public virtual DbSet<_DirectReportsSP> _DirectReportsSP { get; set; }
        public virtual DbSet<SendBlastEmailUsers_SP> SendBlastEmailUsers_SP { get; set; }

        public virtual DbSet<EmployeeReporteesSP> EmployeeReporteesSP { get; set; }
        public virtual DbSet<PastAppraisals> PastAppraisals { get; set; }
        public virtual DbSet<_MidYearAppraisal> _MidYearAppraisals { get; set; }
        public virtual DbSet<ReportHeaderInfo> ReportHeaderInfo { get; set; }

        public virtual DbSet<ArchiveObjectives> ArchiveObjectives { get; set; }

        public virtual DbSet<ArchivevalueBehaviors> ArchivevalueBehaviors { get; set; }

        public virtual DbSet<ArchiveAppraisalSummary> ArchiveAppraisalSummary { get; set; }
        public virtual DbSet<__ProfilesListWithCEO_NewSP> _ProfilesListWithCEO_NewSP { get; set; }
        public virtual DbSet<_ProfilesListByName_NewSP> _ProfilesListByName_NewSP { get; set; }
        public virtual DbSet<_TemporaryDirectReportsListAllGridSP_New> _TemporaryDirectReportsListAllGridSP_New { get; set; }
        public virtual DbSet<_AppraisalsSelfAssessmentNeedsManangerStepSP> _AppraisalsSelfAssessmentNeedsManangerStepSP { get; set; }
        public virtual DbSet<_MidYearNeedManagerSign> _MidYearNeedManagerSign { get; set; }
        public virtual DbSet<_CompetencyNeedsManangerStepSP> _CompetencyNeedsManangerStepSP { get; set; }
        public virtual DbSet<_AppraisalNeedsHRSignOff> _AppraisalNeedsHRSignOffSP { get; set; }
        public virtual DbSet<_AppraisalsNeedEmployeeSign> _AppraisalsNeedEmployeeSignSP { get; set; }
        public virtual DbSet<_AppraisalsNeedManagerSign> _AppraisalsNeedManagerSign { get; set; }
        public virtual DbSet<_GetAllHRUsers_New> _GetAllHRUsers_New { get; set; }
        public virtual DbSet<_GetHRUserWithPermissions_New> _GetHRUserWithPermissions_New { get; set; }
        public virtual DbSet<_SP_HRTItoHTSFeed> _SP_HRTItoHTSFeed { get; set; }

        public virtual DbSet<_ProfileUpdateEMPTermination> _ProfileUpdateEMPTerminations { get; set; }
        //public virtual DbSet<vmHRBPUserPermissions> vmHRBPUserPermissions { get; set; }
        public virtual DbSet<vmGETHRReviewerDetails> vmGETHRReviewerDetails { get; set; }

        public virtual DbSet<HRReviewUsers> hRReviewUsers { get; set; }


        public virtual DbSet<vmHRBPUsers> vmHRBPUsers { get; set; }


        

        public virtual DbSet<_MidYear> _MidYear { get; set; }

        public virtual DbSet<_Appraisals> _Appraisals { get; set; }
        public virtual DbSet<ArchiveMidEMPObj> ArchiveMidEMPObj { get; set; }

        public virtual DbSet<ArchiveMidValues> ArchiveMidValues { get; set; }

        public virtual DbSet<ArchiveMidDevPlan> ArchiveMidDevPlan { get; set; }

        public virtual DbSet<_closeallappraisal> _Closeallappraisals { get; set; }

        public virtual DbSet<HRITData> hritdata { get; set; }

        public virtual DbSet<_ArchiveMidYearObjective> archivemidyrobj {get;set;}

        public virtual DbSet<WrongAppraisals> WrongAppraisals { get; set; }
        public virtual DbSet<IsUserInCurrentCycle> IsUserInCurrentCycle { get; set; }

        public virtual DbSet<EmployeeTabAccess> EmployeeTabAccess { get; set; }
        public virtual DbSet<EmployeeAppraisalCycle> EmployeeAppraisalCycle { get; set; }
        public virtual DbSet<EligibilityCheck> EligibilityCheck { get; set; }

        public virtual DbSet<NoteMessage> NoteMessage { get; set; }
        public virtual DbSet<ActualCycle> ActualCycle { get; set; }
        public virtual DbSet<PostResult> postResults { get; set; }

        public virtual DbSet<AssessmentCyclesOnOff> AssessmentCycles { get; set; }
        public virtual DbSet<SP_AssessmentCyclesOnOff> SP_AssessmentCycles { get; set; }

        //by praveen
        //public virtual DbSet<SkillsRating> SkillRatings { get; set; }

        public virtual DbSet<ReturnToEmployeeDetails> ReturnToEmployeeDetails { get; set; }

        public virtual DbSet<LeadershipCompetencies> LeadershipCompetencies { get; set; }
        public virtual DbSet<LeadershipCompetencyRatings> LdrshipRating { get; set; }
        public virtual DbSet<LDRCompetenciesDesc> LDRCompetenciesDescrp { get; set; }
        public virtual DbSet<tbl_EmpCompetencies> tbl_EmpCompetencies { get; set; }

        public virtual DbSet<tbl_EmpTaskstatus> tbl_EmpTaskstatus { get; set; }   









        //public virtual DbSet<CompetencyDDL> CompetencyDDLs { get; set; }

        //public virtual DbSet<EmployeeCommentsDDL> EmployeeCommentsDDLs { get; set; }

        public virtual DbSet<SP_ReturnToEmployeeDetails> SP_ReturnToEmployeeDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Harsco.HTS.connectionString"));

            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //                optionsBuilder.UseSqlServer(this.Harsco_HTS_ConnectionString);
            //            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<_SP_HRTItoHTSFeed>().HasNoKey().ToView(null);
            modelBuilder.Entity<vmHRBPUsers>().HasNoKey().ToView(null);
            modelBuilder.Entity<tbl_EmpTaskstatus>().HasKey(e=>e.ID);
            modelBuilder.Entity<ActivityLoop>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppraisalApprovals>(entity =>
            {
                entity.HasKey(e => e.AppraisalApprovalId);

                entity.Property(e => e.AppraisalApprovalId).HasColumnName("AppraisalApprovalID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.ApprovalStatusId).HasColumnName("ApprovalStatusID");

                entity.Property(e => e.ApproverId)
                    .IsRequired()
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20);

                entity.Property(e => e.ApproverName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusChangedDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.AppraisalApprovals)
                    .HasForeignKey(d => d.AppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppraisalApprovals_Appraisals");

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.AppraisalApprovals)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppraisalApprovals_ApprovalStatuses");
            });

            modelBuilder.Entity<AppraisalAttachments>(entity =>
            {
                entity.HasKey(e => e.AppraisalAttachmentId);

                entity.Property(e => e.AppraisalAttachmentId).HasColumnName("AppraisalAttachmentID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

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

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.AppraisalAttachments)
                    .HasForeignKey(d => d.AppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppraisalAttachments_Appraisals");
            });

            modelBuilder.Entity<AppraisalRatings>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppraisalTypes>(entity =>
            {
                entity.HasKey(e => e.AppraisalTypeId);

                entity.Property(e => e.AppraisalTypeId).HasColumnName("AppraisalTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Appraisals>(entity =>
            {
                entity.HasKey(e => e.AppraisalId);

                entity.HasIndex(e => e.AppraisalTypeId)
                    .HasName("IX_Appraisals_AppraisalTypeId");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.AppraisalTypeId).HasColumnName("AppraisalTypeID");

                entity.Property(e => e.Cocviolation)
                    .IsRequired()
                    .HasColumnName("COCViolation")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompetencyComment).HasColumnType("ntext");

                entity.Property(e => e.CompetencyRating).HasColumnType("ntext");

                entity.Property(e => e.EmployeeComment).HasColumnType("ntext");

                entity.Property(e => e.EmployeeName).HasMaxLength(75);

                entity.Property(e => e.EmployeeSignDate).HasColumnType("datetime");

                entity.Property(e => e.ManagerComment).HasColumnType("ntext");

                entity.Property(e => e.ManagerMeeting)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

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

                entity.Property(e => e.OverallRating).HasColumnType("ntext");

                entity.Property(e => e.PerformanceRating).HasColumnType("ntext");

                entity.Property(e => e.ReviewDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SkillComment).HasColumnType("ntext");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AppraisalType)
                    .WithMany(p => p.Appraisals)
                    .HasForeignKey(d => d.AppraisalTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appraisals_AppraisalTypes");
            });

            modelBuilder.Entity<ApprovalStatuses>(entity =>
            {
                entity.HasKey(e => e.ApprovalStatusId);

                entity.Property(e => e.ApprovalStatusId).HasColumnName("ApprovalStatusID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AwardsPatentsRecognitions>(entity =>
            {
                entity.HasKey(e => e.AwardPatentRecognitionId)
                    .HasName("PK_AwardsPatentsRecognition");

                entity.Property(e => e.AwardPatentRecognitionId).HasColumnName("AwardPatentRecognitionID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

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

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ReferenceNumber).HasMaxLength(20);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.AwardsPatentsRecognitions)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AwardsPatentsRecognition_Profiles");
            });

            modelBuilder.Entity<BusinessGroups>(entity =>
            {
                entity.HasKey(e => e.BusinessGroupId);

                entity.Property(e => e.BusinessGroupId).HasColumnName("BusinessGroupID");

                entity.Property(e => e.BusinessGroupAdcode)
                    .HasColumnName("BusinessGroupADCode")
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessGroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Person that last modified this record");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date record was last modified");
            });

            modelBuilder.Entity<BusinessUnits>(entity =>
            {
                entity.HasKey(e => e.BusinessUnitId);

                entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessGroupId).HasColumnName("BusinessGroupID");

                entity.Property(e => e.BusinessUnitName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.BusinessGroup)
                    .WithMany(p => p.BusinessUnits)
                    .HasForeignKey(d => d.BusinessGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessUnits_BusinessGroups");
            });

            modelBuilder.Entity<CareerAspiration>(entity =>
            {
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

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.CareerAspiration)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareerAspiration_Profiles");
            });

            modelBuilder.Entity<CareerInterestApprovals>(entity =>
            {
                entity.HasKey(e => e.CareerInterestApprovalId);

                entity.Property(e => e.CareerInterestApprovalId).HasColumnName("CareerInterestApprovalID");

                entity.Property(e => e.ApprovalStatusId).HasColumnName("ApprovalStatusID");

                entity.Property(e => e.ApproverId)
                    .IsRequired()
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20);

                entity.Property(e => e.ApproverName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.CareerInterestId).HasColumnName("CareerInterestID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusChangedDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.CareerInterestApprovals)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareerInterestApprovals_ApprovalStatuses");

                entity.HasOne(d => d.CareerInterest)
                    .WithMany(p => p.CareerInterestApprovals)
                    .HasForeignKey(d => d.CareerInterestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareerInterestApprovals_CareerInterests");
            });

            modelBuilder.Entity<CareerInterestTiming>(entity =>
            {
                entity.Property(e => e.CareerInterestTimingId).HasColumnName("CareerInterestTimingID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CareerInterests>(entity =>
            {
                entity.HasKey(e => e.CareerInterestId);

                entity.Property(e => e.CareerInterestId).HasColumnName("CareerInterestID");

                entity.Property(e => e.CareerInterestTimingId).HasColumnName("CareerInterestTimingID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.JobFamilyId).HasColumnName("JobFamilyID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WillingToRelocate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.HasOne(d => d.CareerInterestTiming)
                    .WithMany(p => p.CareerInterests)
                    .HasForeignKey(d => d.CareerInterestTimingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareerInterests_CareerInterestTiming");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.CareerInterests)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareerInterests_Profiles");
            });

            modelBuilder.Entity<CareerInterestsJobFamily>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.JobFamily)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommentTypes>(entity =>
            {
                entity.HasKey(e => e.CommentTypeId);

                entity.Property(e => e.CommentTypeId).HasColumnName("CommentTypeID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CommunicationsLog>(entity =>
            {
                entity.Property(e => e.CommunicationsLogId).HasColumnName("CommunicationsLogID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.DateSent)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Recipients)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Competencies>(entity =>
            {
                entity.HasKey(e => e.CompetencyId);

                entity.Property(e => e.CompetencyId).HasColumnName("CompetencyID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EnterpriseCompetencyId).HasColumnName("EnterpriseCompetencyID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.Competencies)
                    .HasForeignKey(d => d.AppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competencies_Appraisals");

                entity.HasOne(d => d.EmployeeSkillRating)
                    .WithMany(p => p.Competencies)
                    .HasForeignKey(d => d.EmployeeSkillRatingId)
                    .HasConstraintName("FK_Competencies_CompetencySkillRatings");

                entity.HasOne(d => d.EnterpriseCompetency)
                    .WithMany(p => p.Competencies)
                    .HasForeignKey(d => d.EnterpriseCompetencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competencies_EnterpriseCompetencies");
            });

            modelBuilder.Entity<CompetenciesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CompetenciesView");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.EnterpriseCompetencyId).HasColumnName("EnterpriseCompetencyID");

                entity.Property(e => e.ManagerComment).HasColumnType("ntext");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<CompetencyApprovals>(entity =>
            {
                entity.HasKey(e => e.CompetencyApprovalId);

                entity.Property(e => e.CompetencyApprovalId).HasColumnName("CompetencyApprovalID");

                entity.Property(e => e.ApprovalStatusId).HasColumnName("ApprovalStatusID");

                entity.Property(e => e.ApproverId)
                    .IsRequired()
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20);

                entity.Property(e => e.ApproverName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CompetencyId).HasColumnName("CompetencyID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.StatusChangedDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.CompetencyApprovals)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyApprovals_ApprovalStatuses");

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.CompetencyApprovals)
                    .HasForeignKey(d => d.CompetencyId)
                    .HasConstraintName("FK_CompetencyApprovals_Competencies");
            });

            modelBuilder.Entity<CompetencyComments>(entity =>
            {
                entity.HasKey(e => e.CompetencyCommentId);

                entity.Property(e => e.CompetencyCommentId).HasColumnName("CompetencyCommentID");

                entity.Property(e => e.Comment)
                    
                    .HasColumnType("ntext");

                entity.Property(e => e.CompetencyId).HasColumnName("CompetencyID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ManagerComment)
                    
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.CompetencyComments)
                    .HasForeignKey(d => d.CompetencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencyComments_Competencies");
            });

            modelBuilder.Entity<CompetencySkillRatings>(entity =>
            {
                entity.HasKey(e => e.CompetencySkillRatingId);

                entity.Property(e => e.CompetencySkillRatingId).HasColumnName("CompetencySkillRatingID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Continent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryAdcode)
                    .HasColumnName("CountryADCode")
                    .HasMaxLength(50);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Person that added this record");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date record was added");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Person that last modified this record");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date record was last modified");

                entity.Property(e => e.TsregionId)
                    .HasColumnName("TSRegionID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CountryLanguage>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.TranslationLanguagesId });
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentCode).HasMaxLength(20);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DevelopmentLoop>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<DevelopmentPlanApprovals>(entity =>
            {
                entity.HasKey(e => e.DevelopmentPlanApprovalId);

                entity.Property(e => e.DevelopmentPlanApprovalId).HasColumnName("DevelopmentPlanApprovalID");

                entity.Property(e => e.ApprovalStatusId).HasColumnName("ApprovalStatusID");

                entity.Property(e => e.ApproverId)
                    .IsRequired()
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20);

                entity.Property(e => e.ApproverName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.DevelopmentPlanDetailId).HasColumnName("DevelopmentPlanDetailID");

                entity.Property(e => e.DevelopmentPlanStrengthId).HasColumnName("DevelopmentPlanStrengthID");

                entity.Property(e => e.DevelopmentPlanWeaknessId).HasColumnName("DevelopmentPlanWeaknessID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusChangedDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.DevelopmentPlanApprovals)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentPlanApprovals_ApprovalStatuses");

                entity.HasOne(d => d.DevelopmentPlanDetail)
                    .WithMany(p => p.DevelopmentPlanApprovals)
                    .HasForeignKey(d => d.DevelopmentPlanDetailId)
                    .HasConstraintName("FK_DevelopmentPlanApprovals_DevelopmentPlanDetails");

                entity.HasOne(d => d.DevelopmentPlanStrength)
                    .WithMany(p => p.DevelopmentPlanApprovals)
                    .HasForeignKey(d => d.DevelopmentPlanStrengthId)
                    .HasConstraintName("FK_DevelopmentPlanApprovals_DevelopmentPlanStrengths");

                entity.HasOne(d => d.DevelopmentPlanWeakness)
                    .WithMany(p => p.DevelopmentPlanApprovals)
                    .HasForeignKey(d => d.DevelopmentPlanWeaknessId)
                    .HasConstraintName("FK_DevelopmentPlanApprovals_DevelopmentPlanWeaknesses");
            });

            modelBuilder.Entity<DevelopmentPlanComments>(entity =>
            {
                entity.HasKey(e => e.DevelopmentPlanCommentId);

                entity.Property(e => e.DevelopmentPlanCommentId).HasColumnName("DevelopmentPlanCommentID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CommentTypeId).HasColumnName("CommentTypeID");

                entity.Property(e => e.DevelopmentPlanDetailId).HasColumnName("DevelopmentPlanDetailID");

                entity.Property(e => e.DevelopmentPlanStrengthId).HasColumnName("DevelopmentPlanStrengthID");

                entity.Property(e => e.DevelopmentPlanWeaknessId).HasColumnName("DevelopmentPlanWeaknessID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CommentType)
                    .WithMany(p => p.DevelopmentPlanComments)
                    .HasForeignKey(d => d.CommentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentPlanComments_CommentTypes");

                entity.HasOne(d => d.DevelopmentPlanDetail)
                    .WithMany(p => p.DevelopmentPlanComments)
                    .HasForeignKey(d => d.DevelopmentPlanDetailId)
                    .HasConstraintName("FK_DevelopmentPlanComments_DevelopmentPlanDetails");

                entity.HasOne(d => d.DevelopmentPlanStrength)
                    .WithMany(p => p.DevelopmentPlanComments)
                    .HasForeignKey(d => d.DevelopmentPlanStrengthId)
                    .HasConstraintName("FK_DevelopmentPlanComments_DevelopmentPlanStrengths");

                entity.HasOne(d => d.DevelopmentPlanWeakness)
                    .WithMany(p => p.DevelopmentPlanComments)
                    .HasForeignKey(d => d.DevelopmentPlanWeaknessId)
                    .HasConstraintName("FK_DevelopmentPlanComments_DevelopmentPlanWeaknesses");
            });

            modelBuilder.Entity<DevelopmentPlanCompletion>(entity =>
            {
                entity.Property(e => e.Completion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

            modelBuilder.Entity<DevelopmentPlanDetails>(entity =>
            {
                entity.HasKey(e => e.DevelopmentPlanDetailId);

                entity.Property(e => e.DevelopmentPlanDetailId).HasColumnName("DevelopmentPlanDetailID");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CompletionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateDue).HasColumnType("smalldatetime");

                entity.Property(e => e.DevelopmentPlanId).HasColumnName("DevelopmentPlanID");

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

                entity.Property(e => e.Result).HasMaxLength(255);

                entity.Property(e => e.SupportRequired)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.DevelopmentPlanDetails)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("FK_DevelopmentPlanDetails_DevelopmentalCompetencies");

                entity.HasOne(d => d.Completion)
                    .WithMany(p => p.DevelopmentPlanDetails)
                    .HasForeignKey(d => d.CompletionId)
                    .HasConstraintName("FK_DevelopmentPlanDetails_DevelopmentPlanCompletion");

                entity.HasOne(d => d.DevelopmentPlan)
                    .WithMany(p => p.DevelopmentPlanDetails)
                    .HasForeignKey(d => d.DevelopmentPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentPlanDetails_DevelopmentPlans");
            });

            modelBuilder.Entity<DevelopmentPlanStrengths>(entity =>
            {
                entity.HasKey(e => e.DevelopmentPlanStrengthId);

                entity.Property(e => e.DevelopmentPlanStrengthId).HasColumnName("DevelopmentPlanStrengthID");

                entity.Property(e => e.DevelopmentPlanId).HasColumnName("DevelopmentPlanID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Strength)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DevelopmentPlan)
                    .WithMany(p => p.DevelopmentPlanStrengths)
                    .HasForeignKey(d => d.DevelopmentPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentPlanStrengths_DevelopmentPlans");
            });

            modelBuilder.Entity<DevelopmentPlanWeaknesses>(entity =>
            {
                entity.HasKey(e => e.DevelopmentPlanWeaknessId);

                entity.Property(e => e.DevelopmentPlanWeaknessId).HasColumnName("DevelopmentPlanWeaknessID");

                entity.Property(e => e.DevelopmentPlanId).HasColumnName("DevelopmentPlanID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Weakness)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<DevelopmentPlans>(entity =>
            {
                entity.HasKey(e => e.DevelopmentPlanId);

                entity.Property(e => e.DevelopmentPlanId).HasColumnName("DevelopmentPlanID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.DevelopmentPlans)
                    .HasForeignKey(d => d.AppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DevelopmentPlans_Appraisals");
            });

            modelBuilder.Entity<DevelopmentalCompetencies>(entity =>
            {
                entity.Property(e => e.Competency)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

            modelBuilder.Entity<DivisionAka>(entity =>
            {
                entity.ToTable("DivisionAKA");

                entity.Property(e => e.DivisionAkaid)
                    .HasColumnName("DivisionAKAID")
                    .HasComment("ID assigned to record");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Person that added this record");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date record was added");

                entity.Property(e => e.DivisionId)
                    .HasColumnName("DivisionID")
                    .HasComment("Division for this alias");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Person that last modified this record");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date record was last modified");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.DivisionAka)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_DivisionAKA_BusinessUnits");
            });

            modelBuilder.Entity<Divisions>(entity =>
            {
                entity.HasKey(e => e.DivisionId);

                entity.Property(e => e.DivisionId)
                    .HasColumnName("DivisionID")
                    .HasComment("ID assigned to record");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('')")
                    .HasComment("Division 3-letter abbreviation");

                entity.Property(e => e.BusinessGroupId).HasColumnName("BusinessGroupID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Person that added this record");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date record was added");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DivisionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Name of division");

                entity.Property(e => e.IsDeleted).HasComment("Is division active?");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Person that last modified this record");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date record was last modified");

                entity.HasOne(d => d.BusinessGroup)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.BusinessGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Divisions_BusinessGroups");
            });

            modelBuilder.Entity<DuplicateAd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DuplicateAD");

                entity.Property(e => e.Adname)
                    .HasColumnName("ADName")
                    .HasMaxLength(255);

                entity.Property(e => e.AssignmentCategory)
                    .HasColumnName("ASSIGNMENT_CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.AssignmentStatus)
                    .HasColumnName("ASSIGNMENT_STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.CorrectAdName)
                    .HasColumnName("Correct AD Name")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryNm)
                    .HasColumnName("COUNTRY_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectIndirect)
                    .HasColumnName("DIRECT_INDIRECT")
                    .HasMaxLength(255);

                entity.Property(e => e.DivisionNm)
                    .HasColumnName("DIVISION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.ExemptFlag)
                    .HasColumnName("EXEMPT_FLAG")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.JobFamily)
                    .HasColumnName("JOB_FAMILY")
                    .HasMaxLength(255);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationNm)
                    .HasColumnName("LOCATION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("MIDDLE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.OrganizationNm)
                    .HasColumnName("ORGANIZATION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.RegionNm)
                    .HasColumnName("REGION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.RowWid)
                    .HasColumnName("ROW_WID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalaryBasis)
                    .HasColumnName("SALARY_BASIS")
                    .HasMaxLength(255);

                entity.Property(e => e.SupervisorNm)
                    .HasColumnName("SUPERVISOR_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.UnionFlag)
                    .HasColumnName("UNION_FLAG")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<EducationalDegrees>(entity =>
            {
                entity.HasKey(e => e.EducationalDegreeId)
                    .HasName("PK_EducationalDegree");

                entity.Property(e => e.EducationalDegreeId).HasColumnName("EducationalDegreeID");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<EducationalInstitutions>(entity =>
            {
                entity.HasKey(e => e.EducationalInstitutionId);

                entity.Property(e => e.EducationalInstitutionId).HasColumnName("EducationalInstitutionID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DegreeObtainedOther).HasMaxLength(75);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.EducationalDegreeId).HasColumnName("EducationalDegreeID");

                entity.Property(e => e.InstitutionName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EducationalDegree)
                    .WithMany(p => p.EducationalInstitutions)
                    .HasForeignKey(d => d.EducationalDegreeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalInstitutions_EducationalDegrees");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.EducationalInstitutions)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EducationalInstitutions_Profiles");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF1FD385533");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            });

            modelBuilder.Entity<EnterpriseCompetencies>(entity =>
            {
                entity.HasKey(e => e.EnterpriseCompetencyId);

                entity.Property(e => e.EnterpriseCompetencyId).HasColumnName("EnterpriseCompetencyID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EnterprizeLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Browser)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ExcludeFromHr>(entity =>
            {
                entity.ToTable("ExcludeFromHR");

                entity.Property(e => e.Adname)
                    .IsRequired()
                    .HasColumnName("ADName")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Eltflag).HasColumnName("ELTFlag");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<GisHeadCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GIS_HeadCount");

                entity.Property(e => e.AssignmentCategory)
                    .HasColumnName("ASSIGNMENT_CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.AssignmentStatus)
                    .HasColumnName("ASSIGNMENT_STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryCd)
                    .HasColumnName("COUNTRY_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryNm)
                    .HasColumnName("COUNTRY_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.DatasourceNumId).HasColumnName("DATASOURCE_NUM_ID");

                entity.Property(e => e.DirectIndirect)
                    .HasColumnName("DIRECT_INDIRECT")
                    .HasMaxLength(255);

                entity.Property(e => e.DivisionCd)
                    .HasColumnName("DIVISION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.DivisionNm)
                    .HasColumnName("DIVISION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExemptFlag)
                    .HasColumnName("EXEMPT_FLAG")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.GeneralReportingCategory)
                    .HasColumnName("GENERAL_REPORTING_CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.JobFamily)
                    .HasColumnName("JOB_FAMILY")
                    .HasMaxLength(255);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationCd)
                    .HasColumnName("LOCATION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationNm)
                    .HasColumnName("LOCATION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("MIDDLE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.OrganizationCd).HasColumnName("ORGANIZATION_CD");

                entity.Property(e => e.OrganizationNm)
                    .HasColumnName("ORGANIZATION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.RegionCd)
                    .HasColumnName("REGION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.RegionNm)
                    .HasColumnName("REGION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.RehireDate)
                    .HasColumnName("REHIRE_DATE")
                    .HasMaxLength(255);

                entity.Property(e => e.RowWid).HasColumnName("ROW_WID");

                entity.Property(e => e.SalaryBasis)
                    .HasColumnName("SALARY_BASIS")
                    .HasMaxLength(255);

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(255);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupervisorId).HasColumnName("SUPERVISOR_ID");

                entity.Property(e => e.SupervisorNm)
                    .HasColumnName("SUPERVISOR_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.UnionFlag)
                    .HasColumnName("UNION_FLAG")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GisHeadCountCanNotFind>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GIS_HeadCount_CanNotFind");

                entity.Property(e => e.AssignmentCategory)
                    .HasColumnName("ASSIGNMENT_CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.AssignmentStatus)
                    .HasColumnName("ASSIGNMENT_STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryCd)
                    .HasColumnName("COUNTRY_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryNm)
                    .HasColumnName("COUNTRY_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.DatasourceNumId).HasColumnName("DATASOURCE_NUM_ID");

                entity.Property(e => e.DirectIndirect)
                    .HasColumnName("DIRECT_INDIRECT")
                    .HasMaxLength(255);

                entity.Property(e => e.DivisionCd)
                    .HasColumnName("DIVISION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.DivisionNm)
                    .HasColumnName("DIVISION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EMPLOYEE_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasMaxLength(255);

                entity.Property(e => e.ExemptFlag)
                    .HasColumnName("EXEMPT_FLAG")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.JobFamily)
                    .HasColumnName("JOB_FAMILY")
                    .HasMaxLength(255);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationCd)
                    .HasColumnName("LOCATION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationNm)
                    .HasColumnName("LOCATION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("MIDDLE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.OrganizationCd)
                    .HasColumnName("ORGANIZATION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.OrganizationNm)
                    .HasColumnName("ORGANIZATION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.RegionCd)
                    .HasColumnName("REGION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.RegionNm)
                    .HasColumnName("REGION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.RehireDate)
                    .HasColumnName("REHIRE_DATE")
                    .HasMaxLength(255);

                entity.Property(e => e.RowWid).HasColumnName("ROW_WID");

                entity.Property(e => e.SalaryBasis)
                    .HasColumnName("SALARY_BASIS")
                    .HasMaxLength(255);

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(255);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasMaxLength(255);

                entity.Property(e => e.SupervisorId)
                    .HasColumnName("SUPERVISOR_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SupervisorNm)
                    .HasColumnName("SUPERVISOR_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.UnionFlag)
                    .HasColumnName("UNION_FLAG")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GisHeadCountImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GIS_HeadCount_Import");

                entity.Property(e => e.Adname)
                    .HasColumnName("ADName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentCategory)
                    .HasColumnName("ASSIGNMENT_CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.AssignmentStatus)
                    .HasColumnName("ASSIGNMENT_STATUS")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryCd)
                    .HasColumnName("COUNTRY_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryNm)
                    .HasColumnName("COUNTRY_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.DatasourceNumId).HasColumnName("DATASOURCE_NUM_ID");

                entity.Property(e => e.DirectIndirect)
                    .HasColumnName("DIRECT_INDIRECT")
                    .HasMaxLength(255);

                entity.Property(e => e.DivisionCd)
                    .HasColumnName("DIVISION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.DivisionNm)
                    .HasColumnName("DIVISION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EMPLOYEE_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasMaxLength(255);

                entity.Property(e => e.ExemptFlag)
                    .HasColumnName("EXEMPT_FLAG")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.JobFamily)
                    .HasColumnName("JOB_FAMILY")
                    .HasMaxLength(255);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationCd)
                    .HasColumnName("LOCATION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.LocationNm)
                    .HasColumnName("LOCATION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("MIDDLE_NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.OrganizationCd)
                    .HasColumnName("ORGANIZATION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.OrganizationNm)
                    .HasColumnName("ORGANIZATION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCd)
                    .HasColumnName("REGION_CD")
                    .HasMaxLength(255);

                entity.Property(e => e.RegionNm)
                    .HasColumnName("REGION_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.RehireDate)
                    .HasColumnName("REHIRE_DATE")
                    .HasMaxLength(255);

                entity.Property(e => e.RowWid)
                    .HasColumnName("ROW_WID")
                    .HasMaxLength(255);

                entity.Property(e => e.SalaryBasis)
                    .HasColumnName("SALARY_BASIS")
                    .HasMaxLength(255);

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(255);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasMaxLength(255);

                entity.Property(e => e.SupervisorId)
                    .HasColumnName("SUPERVISOR_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.SupervisorNm)
                    .HasColumnName("SUPERVISOR_NM")
                    .HasMaxLength(255);

                entity.Property(e => e.UnionFlag)
                    .HasColumnName("UNION_FLAG")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GisexcludeJobTitles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GISExcludeJobTitles");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<HeadCountErrorLog>(entity =>
            {
                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ErrorDescription)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Headcount>(entity =>
            {
                entity.HasKey(e => e.RowWid)
                    .HasName("W_EMPLOYEE_D_PK");

                entity.Property(e => e.RowWid).HasColumnName("ROW_WID");

                entity.Property(e => e.AdUsername)
                    .HasColumnName("AD_USERNAME")
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentCategory)
                    .HasColumnName("ASSIGNMENT_CATEGORY")
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentStatus)
                    .HasColumnName("ASSIGNMENT_STATUS")
                    .IsUnicode(false);

                entity.Property(e => e.CountryCd)
                    .HasColumnName("COUNTRY_CD")
                    .IsUnicode(false);

                entity.Property(e => e.CountryNm)
                    .HasColumnName("COUNTRY_NM")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatasourceNumId).HasColumnName("DATASOURCE_NUM_ID");

                entity.Property(e => e.DirectIndirect)
                    .HasColumnName("DIRECT_INDIRECT")
                    .IsUnicode(false);

                entity.Property(e => e.DivisionCd)
                    .HasColumnName("DIVISION_CD")
                    .IsUnicode(false);

                entity.Property(e => e.DivisionNm)
                    .HasColumnName("DIVISION_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EMPLOYEE_ID")
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeUniqueId)
                    .HasColumnName("EMPLOYEE_UNIQUE_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExemptFlag)
                    .HasColumnName("EXEMPT_FLAG")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.GeneralReportingCategory)
                    .HasColumnName("GENERAL_REPORTING_CATEGORY")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JobFamily)
                    .HasColumnName("JOB_FAMILY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasColumnName("LANGUAGE")
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.LocationCd)
                    .HasColumnName("LOCATION_CD")
                    .IsUnicode(false);

                entity.Property(e => e.LocationNm)
                    .HasColumnName("LOCATION_NM")
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("MIDDLE_NAME")
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OrganizationCd)
                    .HasColumnName("ORGANIZATION_CD")
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationNm)
                    .HasColumnName("ORGANIZATION_NM")
                    .IsUnicode(false);

                entity.Property(e => e.RegionCd)
                    .HasColumnName("REGION_CD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RegionNm)
                    .HasColumnName("REGION_NM")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RehireDate)
                    .HasColumnName("REHIRE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalaryBasis)
                    .HasColumnName("SALARY_BASIS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasColumnName("SOURCE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupervisorId)
                    .HasColumnName("SUPERVISOR_ID")
                    .IsUnicode(false);

                entity.Property(e => e.SupervisorNm)
                    .HasColumnName("SUPERVISOR_NM")
                    .IsUnicode(false);

                entity.Property(e => e.SupervisorUniqueId)
                    .HasColumnName("SUPERVISOR_UNIQUE_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnionFlag)
                    .HasColumnName("UNION_FLAG")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HritfeedErrorLog>(entity =>
            {
                entity.ToTable("HRITFeedErrorLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ErrorDescription)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Hrpermissions>(entity =>
            {
                entity.ToTable("HRPermissions");

                entity.Property(e => e.HrpermissionsId).HasColumnName("HRPermissionsId");

                entity.Property(e => e.Hrbp).HasColumnName("HRBP");

                entity.Property(e => e.HruserId).HasColumnName("HRUserId");

                entity.HasOne(d => d.Hruser)
                    .WithMany(p => p.Hrpermissions)
                    .HasForeignKey(d => d.HruserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRPermissions_HRUsers");
            });

            modelBuilder.Entity<HrpermissionsNew>(entity =>
            {
                entity.HasKey(e => e.HrpermissionsId);

                entity.ToTable("HRPermissions_New");

                entity.Property(e => e.HrpermissionsId).HasColumnName("HRPermissionsId");

                entity.Property(e => e.HruserId).HasColumnName("HRUserId");
            });

            modelBuilder.Entity<Hrusers>(entity =>
            {
                entity.HasKey(e => e.HruserId)
                    .HasName("PK_HRAccess");

                entity.ToTable("HRUsers");

                entity.HasIndex(e => e.UserName)
                    .HasName("IX_HRUsers");

                entity.Property(e => e.HruserId).HasColumnName("HRUserId");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrusersNew>(entity =>
            {
                entity.HasKey(e => e.HruserId)
                    .HasName("PK_HRAccess_New");

                entity.ToTable("HRUsers_New");

                entity.Property(e => e.HruserId).HasColumnName("HRUserId");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TempId)
                    .HasColumnName("TempID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HumanResource>(entity =>
            {
                entity.Property(e => e.Comments).HasColumnType("ntext");

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

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.HumanResource)
                    .HasForeignKey(d => d.AppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HumanResource_Appraisals");
            });

            modelBuilder.Entity<Institutions>(entity =>
            {
                entity.HasKey(e => e.InstitutionId);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InstitutionName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItalianMissingTranslation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Italian_MissingTranslation");

                entity.Property(e => e.EnglishText).HasMaxLength(255);

                entity.Property(e => e.F3).HasMaxLength(255);

                entity.Property(e => e.KeyPhrase).HasMaxLength(255);
            });

            modelBuilder.Entity<JobFamily>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<LanguageFluency>(entity =>
            {
                entity.Property(e => e.LanguageFluencyId).HasColumnName("LanguageFluencyID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<LicenseCategories>(entity =>
            {
                entity.HasKey(e => e.LicenseCategoryId);

                entity.Property(e => e.LicenseCategoryId).HasColumnName("LicenseCategoryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LicsCertsProfOrgs>(entity =>
            {
                entity.HasKey(e => e.LicCertProfOrgId);

                entity.Property(e => e.LicCertProfOrgId).HasColumnName("LicCertProfOrgID");

                entity.Property(e => e.CertificationNumber).HasMaxLength(20);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseCategoryId).HasColumnName("LicenseCategoryID");

                entity.Property(e => e.LicenseCategoryOther).HasMaxLength(75);

                entity.Property(e => e.LicenseNumber).HasMaxLength(20);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProfessionalOrganizationName).HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.LicenseCategory)
                    .WithMany(p => p.LicsCertsProfOrgs)
                    .HasForeignKey(d => d.LicenseCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicsCertsProfOrgs_LicenseCategories");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.LicsCertsProfOrgs)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicsCertsProfOrgs_Profiles");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.BusinessGroupId).HasColumnName("BusinessGroupID");

                entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Person that added this record");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date record was added");

                entity.Property(e => e.LocationAdcode)
                    .IsRequired()
                    .HasColumnName("LocationADCode")
                    .HasMaxLength(75);

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Person that last modified this record");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date record was last modified");

                entity.Property(e => e.ParentLocationId).HasColumnName("ParentLocationID");

                entity.Property(e => e.PoliticalRegion).HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.StreetAddress).HasMaxLength(200);

                entity.HasOne(d => d.BusinessGroup)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.BusinessGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Locations_BusinessGroups");

                entity.HasOne(d => d.BusinessUnit)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.BusinessUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Locations_BusinessUnits");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Locations_Country");
            });

            modelBuilder.Entity<MidYear>(entity =>
            {
                entity.HasIndex(e => e.ProfileId)
                    .HasName("IX_MidYear_ProfileId");

                entity.Property(e => e.MidYearId).HasColumnName("MidYearID");

                entity.Property(e => e.AppraisalTypeId).HasColumnName("AppraisalTypeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

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

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.HasOne(d => d.AppraisalType)
                    .WithMany(p => p.MidYear)
                    .HasForeignKey(d => d.AppraisalTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MidYear_AppraisalTypes");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.MidYear)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MidYear_Profiles");
            });

            modelBuilder.Entity<MidYearEmpMgrDevPlan>(entity =>
            {
                entity.HasKey(e => e.MidYearEmpMgrDevId)
                    .HasName("PK__MidYear___3278D51CE7D82CC1");

                entity.ToTable("MidYear_EmpMgrDevPlan");

                entity.Property(e => e.MidYearEmpMgrDevId).HasColumnName("MidYearEmpMgrDevID");

                entity.Property(e => e.AppraisalTypeId).HasColumnName("AppraisalTypeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmpDevPlan).HasColumnType("ntext");

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

                entity.Property(e => e.ManagerName).HasMaxLength(100);

                entity.Property(e => e.MgrDevPlan).HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MidYearEmpMgrValues>(entity =>
            {
                entity.HasKey(e => e.MidYearEmpValuesId)
                    .HasName("PK_MidYear_EmpValues_DevmtPlan");

                entity.ToTable("MidYear_EmpMgrValues");

                entity.Property(e => e.MidYearEmpValuesId).HasColumnName("MidYearEmpValuesID");

                entity.Property(e => e.AppraisalTypeId).HasColumnName("AppraisalTypeID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmpValueBehavior).HasColumnType("ntext");

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

                entity.Property(e => e.EnterpriseCompetencyId).HasColumnName("EnterpriseCompetencyID");

                entity.Property(e => e.ManagerName).HasMaxLength(100);

                entity.Property(e => e.MgrValueBehavior).HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.HasOne(d => d.AppraisalType)
                    .WithMany(p => p.MidYearEmpMgrValues)
                    .HasForeignKey(d => d.AppraisalTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MidYear_EmpValues_AppraisalTypes");

                entity.HasOne(d => d.EnterpriseCompetency)
                    .WithMany(p => p.MidYearEmpMgrValues)
                    .HasForeignKey(d => d.EnterpriseCompetencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MidYear_EnterpriseCompetencies");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.MidYearEmpMgrValues)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MidYear_EmpValues_Profiles");
            });

            modelBuilder.Entity<MilestoneStatus>(entity =>
            {
                entity.Property(e => e.MilestoneStatusId).HasColumnName("MilestoneStatusID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NextYearPreliminaryObjectives>(entity =>
            {
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

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.NextYearPreliminaryObjectives)
                    .HasForeignKey(d => d.AppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NextYearPreliminaryObjectives_Appraisals");
            });

            modelBuilder.Entity<NotRequiredReview>(entity =>
            {
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

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObjectiveAchieved>(entity =>
            {
                entity.Property(e => e.AchievedDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

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

            modelBuilder.Entity<ObjectiveApprovals>(entity =>
            {
                entity.HasKey(e => e.ObjectiveApprovalId);

                entity.Property(e => e.ObjectiveApprovalId).HasColumnName("ObjectiveApprovalID");

                entity.Property(e => e.ApprovalStatusId).HasColumnName("ApprovalStatusID");

                entity.Property(e => e.ApproverId)
                    .IsRequired()
                    .HasColumnName("ApproverID")
                    .HasMaxLength(20);

                entity.Property(e => e.ApproverName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.Property(e => e.ObjectiveMilestoneId).HasColumnName("ObjectiveMilestoneID");

                entity.Property(e => e.StatusChangedDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.ObjectiveApprovals)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ObjectiveApprovals_ApprovalStatuses");

                entity.HasOne(d => d.Objective)
                    .WithMany(p => p.ObjectiveApprovals)
                    .HasForeignKey(d => d.ObjectiveId)
                    .HasConstraintName("FK_ObjectiveApprovals_Objectives");

                entity.HasOne(d => d.ObjectiveMilestone)
                    .WithMany(p => p.ObjectiveApprovals)
                    .HasForeignKey(d => d.ObjectiveMilestoneId)
                    .HasConstraintName("FK_ObjectiveApprovals_ObjectiveMilestones");
            });

            modelBuilder.Entity<ObjectiveComments>(entity =>
            {
                entity.HasKey(e => e.ObjectiveCommentId);

                entity.Property(e => e.ObjectiveCommentId).HasColumnName("ObjectiveCommentID");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CommentTypeId).HasColumnName("CommentTypeID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.Property(e => e.ObjectiveMilestoneId).HasColumnName("ObjectiveMilestoneID");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CommentType)
                    .WithMany(p => p.ObjectiveComments)
                    .HasForeignKey(d => d.CommentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ObjectiveComments_CommentTypes");

                entity.HasOne(d => d.Objective)
                    .WithMany(p => p.ObjectiveComments)
                    .HasForeignKey(d => d.ObjectiveId)
                    .HasConstraintName("FK_ObjectiveComments_Objectives");

                entity.HasOne(d => d.ObjectiveMilestone)
                    .WithMany(p => p.ObjectiveComments)
                    .HasForeignKey(d => d.ObjectiveMilestoneId)
                    .HasConstraintName("FK_ObjectiveComments_ObjectiveMilestones");
            });

            modelBuilder.Entity<ObjectiveMilestones>(entity =>
            {
                entity.HasKey(e => e.ObjectiveMilestoneId);

                entity.Property(e => e.ObjectiveMilestoneId).HasColumnName("ObjectiveMilestoneID");

                entity.Property(e => e.DateDue).HasColumnType("smalldatetime");

                entity.Property(e => e.MilestoneStatusId).HasColumnName("MilestoneStatusID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MilestoneStatus)
                    .WithMany(p => p.ObjectiveMilestones)
                    .HasForeignKey(d => d.MilestoneStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ObjectiveMilestones_MilestoneStatus");

                entity.HasOne(d => d.Objective)
                    .WithMany(p => p.ObjectiveMilestones)
                    .HasForeignKey(d => d.ObjectiveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ObjectiveMilestones_Objectives");
            });

            modelBuilder.Entity<Objectives>(entity =>
            {
                entity.HasKey(e => e.ObjectiveId);

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateDue).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ManagerYearEndResults)
                    
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.YearEndResults)
                    
                    .HasColumnType("ntext");

                entity.HasOne(d => d.Achieved)
                    .WithMany(p => p.Objectives)
                    .HasForeignKey(d => d.AchievedId)
                    .HasConstraintName("FK_Objectives_ObjectiveAchieved");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.Objectives)
                    .HasForeignKey(d => d.AppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Objectives_Appraisals");
            });

            modelBuilder.Entity<ObjectivesNeededVerna>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BusinessGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.BusinessUnit)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateHired).HasColumnType("datetime");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.JobFamilyName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ManagerManagerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OverallRating).HasMaxLength(255);

                entity.Property(e => e.PerformanceRating).HasMaxLength(255);

                entity.Property(e => e.Vbrating)
                    .HasColumnName("VBRating")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PointOfEntry>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.HasIndex(e => e.AppraisalId);

                entity.HasIndex(e => e.ManagerId);

                entity.HasIndex(e => e.NetworkId)
                    .HasName("IX_Profiles_networkId");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateHired).HasColumnType("smalldatetime");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNumber).HasMaxLength(20);

                entity.Property(e => e.JobFamilyId).HasColumnName("JobFamilyID");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Location)
                    
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasColumnName("NetworkID")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.TerminationDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_Profiles_Profiles");
            });

            modelBuilder.Entity<ProfilesManagerRemoved>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateHired).HasColumnType("smalldatetime");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeNumber).HasMaxLength(20);

                entity.Property(e => e.JobFamilyId).HasColumnName("JobFamilyID");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasColumnName("NetworkID")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.ProfileId)
                    .HasColumnName("ProfileID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TerminationDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ProfilesRemoved>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NetWorkId)
                    .IsRequired()
                    .HasColumnName("NetWorkID")
                    .HasMaxLength(30);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            });

            modelBuilder.Entity<ProfilesRemoved2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateHired).HasColumnType("smalldatetime");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeNumber).HasMaxLength(20);

                entity.Property(e => e.JobFamilyId).HasColumnName("JobFamilyID");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasColumnName("NetworkID")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.TerminationDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ProfilesRemoved201710425>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProfilesRemoved_201710425");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateHired).HasColumnType("smalldatetime");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeNumber).HasMaxLength(20);

                entity.Property(e => e.JobFamilyId).HasColumnName("JobFamilyID");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasColumnName("NetworkID")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNumber).HasMaxLength(255);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.TerminationDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ReportMaster>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ReportId)
                    .HasColumnName("ReportID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ReportName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

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
            });
          
            modelBuilder.Entity<TblBireportLink>(entity =>
            {
                entity.ToTable("tbl_BIReportLink");

                entity.Property(e => e.ReportText).HasMaxLength(200);

                entity.Property(e => e.ReportUrl).IsRequired();
            });

            modelBuilder.Entity<TblBlastEmailPicks>(entity =>
            {
                entity.HasKey(e => e.PickId)
                    .HasName("PK__tbl_Blas__C80E9FAF9421FABE");

                entity.ToTable("tbl_BlastEmailPicks");

                entity.Property(e => e.PickTitle).HasMaxLength(200);
            });

            modelBuilder.Entity<TblCountries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("tbl_Countries");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblErrors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Errors");

                entity.Property(e => e.ErrorDateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorId)
                    .HasColumnName("ErrorID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblHritmasterData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_HRITMasterData");

                entity.Property(e => e.AdUsername)
                    .HasColumnName("AD_USERNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.AssignmentCategory)
                    .HasColumnName("ASSIGNMENT_CATEGORY")
                    .HasMaxLength(100);

                entity.Property(e => e.AssignmentStatus)
                    .HasColumnName("ASSIGNMENT_STATUS")
                    .HasMaxLength(100);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("COUNTRY_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.CountryName)
                    .HasColumnName("COUNTRY_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.DirectIndirect)
                    .HasColumnName("DIRECT_INDIRECT")
                    .HasMaxLength(100);

                entity.Property(e => e.DivisionCode)
                    .HasColumnName("DIVISION_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.DivisionName)
                    .HasColumnName("DIVISION_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasMaxLength(200);

                entity.Property(e => e.EmployeeNumber)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_NUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.JobFamily)
                    .HasColumnName("JOB_FAMILY")
                    .HasMaxLength(100);

                entity.Property(e => e.JobTitleDaily)
                    .HasColumnName("JOB_TITLE_DAILY")
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(100);

                entity.Property(e => e.LocationName)
                    .HasColumnName("LOCATION_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.OrganizationName)
                    .HasColumnName("ORGANIZATION_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.SalaryBasis)
                    .HasColumnName("SALARY_BASIS")
                    .HasMaxLength(30);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupervisorName)
                    .HasColumnName("SUPERVISOR_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.SupervisorNumber)
                    .HasColumnName("SUPERVISOR_NUMBER")
                    .HasMaxLength(100);

                entity.Property(e => e.Terminationdate)
                    .HasColumnName("TERMINATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TemporaryDirectReports>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ManagerId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalManagerId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TestHumanResource>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_HumanResource");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SendToHr).HasColumnType("datetime");

                entity.Property(e => e.SendToManager).HasColumnType("datetime");
            });

            modelBuilder.Entity<TestNextWrongappraisalFixes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_NextWrongappraisalFixes");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.AppraisalTypeId).HasColumnName("AppraisalTypeID");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasColumnName("NetworkID")
                    .HasMaxLength(30);

                entity.Property(e => e.TerminationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TestTermiatedateFixes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_TermiatedateFixes");

                entity.Property(e => e.ActualTerminationDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateHired).HasColumnType("smalldatetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmployeeNumber).HasMaxLength(20);

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasColumnName("NetworkID")
                    .HasMaxLength(30);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.TerminationDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TestWrongManagerFixes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_WrongManagerFixes");

                entity.Property(e => e.ActualManger)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ActualMangerProfileId).HasColumnName("ActualMangerProfileID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeName).HasMaxLength(162);

                entity.Property(e => e.Manager)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            });

            modelBuilder.Entity<TestWrongappraisalFixes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_WrongappraisalFixes");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.AppraisalTypeId).HasColumnName("AppraisalTypeID");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

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

                entity.Property(e => e.NetworkId)
                    .IsRequired()
                    .HasColumnName("NetworkID")
                    .HasMaxLength(30);

                entity.Property(e => e.TerminationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TestZcity>(entity =>
            {
                entity.ToTable("Test_ZCity");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.TestZcity)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Test_ZCit__Count__41049384");
            });

            modelBuilder.Entity<TestZcountry>(entity =>
            {
                entity.ToTable("Test_ZCountry");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TestZemployees>(entity =>
            {
                entity.ToTable("Test_ZEmployees");

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TestZmasDepartment>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Test_ZMa__014881AE8A67765A");

                entity.ToTable("Test_ZMas_Department");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestZmasEmployee>(entity =>
            {
                entity.ToTable("Test_ZMas_Employee");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestZstudents>(entity =>
            {
                entity.ToTable("Test_ZStudents");

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ToolTips>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToolTip)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<TrainingCategories>(entity =>
            {
                entity.HasKey(e => e.TrainingCategoryId);

                entity.Property(e => e.TrainingCategoryId).HasColumnName("TrainingCategoryID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TrainingDevelopment>(entity =>
            {
                entity.Property(e => e.TrainingDevelopmentId).HasColumnName("TrainingDevelopmentID");

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

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TrainingCategoryId).HasColumnName("TrainingCategoryID");

                entity.Property(e => e.TrainingCategoryOther).HasMaxLength(75);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.TrainingDevelopment)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingDevelopment_Profiles");

                entity.HasOne(d => d.TrainingCategory)
                    .WithMany(p => p.TrainingDevelopment)
                    .HasForeignKey(d => d.TrainingCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingDevelopment_TrainingCategories");
            });

            modelBuilder.Entity<TranslationLanguages>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.WelcomeText).HasColumnType("ntext");
            });

            modelBuilder.Entity<Translations>(entity =>
            {
                entity.HasIndex(e => e.TranslationLanguageId);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KeyPhrase)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TranslatedText)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<UnderstoodLanguages>(entity =>
            {
                entity.HasKey(e => e.UnderstoodLanguageId);

                entity.Property(e => e.UnderstoodLanguageId).HasColumnName("UnderstoodLanguageID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageFluencyId).HasColumnName("LanguageFluencyID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.LanguageFluency)
                    .WithMany(p => p.UnderstoodLanguages)
                    .HasForeignKey(d => d.LanguageFluencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnderstoodLanguages_LanguageFluency");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.UnderstoodLanguages)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnderstoodLanguages_Profiles");
            });

            modelBuilder.Entity<VwBusinessUnits>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_BusinessUnits");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessUnitId)
                    .HasColumnName("BusinessUnitID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BusinessUnitName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwCountries>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Countries");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCountriesTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw__Countries_Test");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDepartments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Departments");

                entity.Property(e => e.DepartmentCode).HasMaxLength(20);

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(75);
            });

            modelBuilder.Entity<VwDivisionAliases>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DivisionAliases");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionAkaid)
                    .HasColumnName("DivisionAKAID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");
            });

            modelBuilder.Entity<VwDivisions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Divisions");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BusinessGroupId).HasColumnName("BusinessGroupID");

                entity.Property(e => e.BusinessGroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.DivisionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLanguages>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Languages");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("LanguageID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwLocations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Locations");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DivisionId).HasColumnName("DivisionID");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.ParentLocationId).HasColumnName("ParentLocationID");

                entity.Property(e => e.PoliticalRegion).HasMaxLength(50);

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.StreetAddress).HasMaxLength(200);
            });

            modelBuilder.Entity<WillingToRelocate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkExperienceDetails>(entity =>
            {
                entity.HasKey(e => e.WorkExperienceDetailId);

                entity.Property(e => e.WorkExperienceDetailId).HasColumnName("WorkExperienceDetailID");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Responsibilities)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.WorkExperienceId).HasColumnName("WorkExperienceID");

                entity.HasOne(d => d.WorkExperience)
                    .WithMany(p => p.WorkExperienceDetails)
                    .HasForeignKey(d => d.WorkExperienceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkExperienceDetails_WorkExperiences");
            });

            modelBuilder.Entity<WorkExperiences>(entity =>
            {
                entity.HasKey(e => e.WorkExperienceId);

                entity.Property(e => e.WorkExperienceId).HasColumnName("WorkExperienceID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

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

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.WorkExperiences)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkExperiences_Profiles");
            });

            modelBuilder.Entity<ZTblTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_tblTest");

                entity.Property(e => e.ApproverId)
                    .HasColumnName("ApproverID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DivisionName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Manager)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId)
                    .HasColumnName("ManagerID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkId)
                    .HasColumnName("NetworkID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Objective).IsUnicode(false);

                entity.Property(e => e.ObjectiveApprovalId).HasColumnName("ObjectiveApprovalID");

                entity.Property(e => e.ObjectiveId).HasColumnName("ObjectiveID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}