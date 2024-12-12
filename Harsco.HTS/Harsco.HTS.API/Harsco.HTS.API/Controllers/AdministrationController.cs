using Harsco.HTS.API.Models;
using Harsco.HTS.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace Harsco.HTS.API.Controllers
{
    [EnableCors("AllowOrigin")]
    [ApiController]
    [Route("[controller]")]
    public class AdministrationController : ControllerBase
    {

        [HttpGet]
        [Route("GetAllUsersForSuperUser")]
        public IActionResult GetDirectReportsTree()
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var allUsers = db._ProfilesListWithCEO_NewSP.FromSqlRaw("ProfilesListWithCEO_New").ToList();
                    return Ok(allUsers);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetCurrentAndTerminated")]
        public IActionResult GetCurrentAndTerminated(string NetworkId, bool? isTerminated, string employeeName = "")
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    List<_ProfilesListByName_NewSP> currentTerminatedUsers = new List<_ProfilesListByName_NewSP>();
                    var _user = db.HrusersNew.Where(u => u.UserName.Equals(NetworkId)).FirstOrDefault();
                    string condition = string.Empty;
                    if (_user != null)
                    {
                        if (_user.SuperUser == true)
                        {
                            currentTerminatedUsers = db.Set<_ProfilesListByName_NewSP>().FromSqlRaw("ProfilesListByName_New  {0} ,{1}, {2}", isTerminated, employeeName ?? string.Empty, condition).ToList();
                            return Ok(currentTerminatedUsers);
                        }
                        else
                        {
                            List<HrpermissionsNew> _userPermissions = db.HrpermissionsNew.Where(h => h.HruserId == _user.HruserId).ToList();
                            if (_userPermissions.Count > 0)
                            {
                                condition += " AND (";
                                int _count = 0;
                                foreach (HrpermissionsNew p in _userPermissions)
                                {
                                    if (_count > 0) condition += " OR ";
                                    condition += " (Profiles.DivisionID = " + p.BusinessGroupId + " AND Profiles.CountryID IN (SELECT * FROM dbo.Split('" + p.CountryId + "', ',')))";
                                    _count = _count + 1;
                                }
                                condition += ") ";
                            }
                            currentTerminatedUsers = db.Set<_ProfilesListByName_NewSP>().FromSqlRaw("ProfilesListByName_New  {0} ,{1}, {2}", isTerminated, employeeName ?? string.Empty, condition).ToList();

                            return Ok(currentTerminatedUsers);
                        }
                    }
                    else
                        return Ok(currentTerminatedUsers);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetTemporaryDirectReportsList")]
        public IActionResult GetTemporaryDirectReportsList()
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var temporaryDirectReportsList = db.Set<_TemporaryDirectReportsListAllGridSP_New>().FromSqlRaw("TemporaryDirectReportsListAllGrid_New").ToList();
                    return Ok(temporaryDirectReportsList);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("UpdateDelegateManagerOld")]
        public IActionResult UpdateDelegateManagerOld(vmTemporaryDirectReport temporaryDirectReportVM)
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    if (temporaryDirectReportVM.Id == null)
                    {
                        var employeeProfileDB = db.Profiles.Where(p => p.ProfileId == temporaryDirectReportVM.Employee[0].ProfileID).FirstOrDefault();
                        var originalManagerProfile = db.Profiles.Where(p => p.ProfileId == employeeProfileDB.ManagerId).FirstOrDefault();
                        var managerProfileDB = db.Profiles.Where(p => p.ProfileId == temporaryDirectReportVM.Manager[0].ProfileID).FirstOrDefault();
                        //Create
                        TemporaryDirectReports temporaryDirectReportsDB = new TemporaryDirectReports();
                        temporaryDirectReportsDB.NetworkId = employeeProfileDB.NetworkId;
                        temporaryDirectReportsDB.OriginalManagerId = originalManagerProfile.NetworkId;
                        temporaryDirectReportsDB.ManagerId = managerProfileDB.NetworkId;
                        temporaryDirectReportsDB.StartDate = temporaryDirectReportVM.Startdate;
                        temporaryDirectReportsDB.EndDate = temporaryDirectReportVM.Enddate;
                        temporaryDirectReportsDB.CreatedBy = temporaryDirectReportVM.LoggedInUser.NetworkId;
                        temporaryDirectReportsDB.CreatedOn = DateTime.Now;

                        temporaryDirectReportsDB.ModifiedBy = temporaryDirectReportVM.LoggedInUser.NetworkId;
                        temporaryDirectReportsDB.ModifiedOn = DateTime.Now;
                        db.TemporaryDirectReports.Add(temporaryDirectReportsDB);

                        employeeProfileDB.ManagerId = managerProfileDB.ProfileId;
                        db.SaveChanges();
                    }
                    else
                    {
                        var employeeProfileDB = db.Profiles.Where(p => p.ProfileId == temporaryDirectReportVM.Employee[0].ProfileID).FirstOrDefault();
                        var managerProfileDB = db.Profiles.Where(p => p.ProfileId == temporaryDirectReportVM.Manager[0].ProfileID).FirstOrDefault();

                        var temporaryDirectReportsDB = db.TemporaryDirectReports.Where(p => p.Id == temporaryDirectReportVM.Id).FirstOrDefault();

                        temporaryDirectReportsDB.NetworkId = employeeProfileDB.NetworkId;
                        temporaryDirectReportsDB.ManagerId = managerProfileDB.NetworkId;
                        temporaryDirectReportsDB.StartDate = temporaryDirectReportVM.Startdate;
                        temporaryDirectReportsDB.EndDate = temporaryDirectReportVM.Enddate;
                        temporaryDirectReportsDB.ModifiedBy = temporaryDirectReportVM.LoggedInUser.NetworkId;
                        temporaryDirectReportsDB.ModifiedOn = DateTime.Now;

                        employeeProfileDB.ManagerId = managerProfileDB.ProfileId;
                        db.SaveChanges();
                    }
                    return Ok(new { status = "Success" });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("UpdateDelegateManager")]
        public IActionResult UpdateDelegateManager(TemporaryDirectReport directReport)
        {
            PostResult result = new PostResult();
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                     result = db.Set<PostResult>().FromSqlRaw("sp_InsertOrUpdateTemporaryDirectReports {0},{1},{2},{3},{4},{5},{6},{7}", directReport.ID, directReport.NetworkID, directReport.ManagerID, directReport.Startdate, directReport.Enddate, directReport.CreatedBy, directReport.ModifiedBy, directReport.IsActive).ToList()[0];
                   
                }
            }
            catch (Exception ex)
            {
                return Ok(result);
            }
            return Ok(result);
        }
       


        [HttpGet]
        [Route("GetHRUserWithPermissions")]
        public IActionResult GetHRUserWithPermissions(string userName)
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var hrUsersWithPermissions = db.Set<_GetHRUserWithPermissions_New>().FromSqlRaw("GetHRUserWithPermissions_New {0}", userName).ToList();
                    return Ok(hrUsersWithPermissions);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetHRUsers")]
        public IActionResult GetHRUsers()
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var hrusers = db.Set<_GetAllHRUsers_New>().FromSqlRaw("GetAllHRUsers_New ").ToList();

                return Ok(hrusers);
            }
        }

        [HttpGet]
        [Route("GetDropDownValues")]
        public IActionResult GetDropDownValues()
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var vwCountries = db.VwCountries.ToList();
                var vwBusinessUnits = db.VwBusinessUnits.ToList();
                return Ok(new
                {
                    vwCountries,
                    vwBusinessUnits
                });
            }
        }

        [HttpPost]
        [Route("UpdateHrPermissions")]
        public IActionResult UpdateHrPermissions(vmHRUserPermissions hrUserPermissionsVM)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var hrUserDB = db.HrusersNew.Where(p => p.HruserId == hrUserPermissionsVM.HRUserId).FirstOrDefault();
                hrUserDB.SuperUser = hrUserPermissionsVM.SuperUser;
                hrUserDB.ModifiedBy = hrUserPermissionsVM.LoggedInUser.NetworkId;
                hrUserDB.ModifiedOn = DateTime.Now;
                db.SaveChanges();
                var hrPermissionsListDB = db.HrpermissionsNew.Where(p => p.HruserId == hrUserPermissionsVM.HRUserId).ToList();
                if (hrPermissionsListDB != null && hrUserPermissionsVM.SuperUser == true)
                {
                    db.RemoveRange(hrPermissionsListDB);
                    db.SaveChanges();
                }
                if (hrUserPermissionsVM.SuperUser == false)
                {
                    if (hrUserPermissionsVM.HRPermissionsId != 0)
                    {
                        var hrPermissionDB = db.HrpermissionsNew.Where(p => p.HrpermissionsId == hrUserPermissionsVM.HRPermissionsId).FirstOrDefault();
                        hrPermissionDB.CountryId = hrUserPermissionsVM.CountryId;
                        db.SaveChanges();
                    }
                    else
                    {

                        if (!string.IsNullOrEmpty(hrUserPermissionsVM.BusinessGroupId))
                        {
                            string[] stringSeparators = new string[] { "," };
                            string[] Codes = hrUserPermissionsVM.BusinessGroupId.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                            foreach (var item in Codes)
                            {
                                HrpermissionsNew hrpermissionsNew = new HrpermissionsNew();
                                hrpermissionsNew.BusinessGroupId = Convert.ToInt32(item);
                                hrpermissionsNew.CountryId = hrUserPermissionsVM.CountryId;
                                hrpermissionsNew.HruserId = hrUserDB.HruserId;
                                db.HrpermissionsNew.Add(hrpermissionsNew);
                                db.SaveChanges();
                            }
                        }
                    }
                }

                return Ok(new { status = "Success" });
            }
        }

        [HttpPost]
        [Route("CreateHrUserAndPermissions")]
        public IActionResult CreateHrUserAndPermissions(vmHRUserPermissions hrUserPermissionsVM)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var profileDB = db.Profiles.Where(p => p.ProfileId == hrUserPermissionsVM.ProfileID).SingleOrDefault();

                HrusersNew _hruser = db.HrusersNew.Where(p => p.UserName == profileDB.NetworkId).SingleOrDefault();
                HrusersNew hrusersNewDB = new HrusersNew();
                if (_hruser == null)
                {

                    hrusersNewDB.UserName = profileDB.NetworkId;
                    hrusersNewDB.SecurityUser = hrUserPermissionsVM.SecurityUser;
                    hrusersNewDB.SuperUser = hrUserPermissionsVM.SuperUser;
                    hrusersNewDB.CreatedBy = hrUserPermissionsVM.LoggedInUser.NetworkId;
                    hrusersNewDB.ModifiedBy = hrUserPermissionsVM.LoggedInUser.NetworkId;
                    hrusersNewDB.CreatedOn = DateTime.Now;
                    hrusersNewDB.ModifiedOn = DateTime.Now;
                    db.HrusersNew.Add(hrusersNewDB);
                    db.SaveChanges();
                }
                else
                {
                    hrusersNewDB = _hruser;

                }



                if (hrUserPermissionsVM.SuperUser == false)
                {
                    if (!string.IsNullOrEmpty(hrUserPermissionsVM.BusinessGroupId))
                    {
                        string[] stringSeparators = new string[] { "," };
                        string[] Codes = hrUserPermissionsVM.BusinessGroupId.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in Codes)
                        {
                            HrpermissionsNew hrpermissionsNew = new HrpermissionsNew();
                            hrpermissionsNew.BusinessGroupId = Convert.ToInt32(item);
                            hrpermissionsNew.CountryId = hrUserPermissionsVM.CountryId;
                            hrpermissionsNew.HruserId = hrusersNewDB.HruserId;
                            db.HrpermissionsNew.Add(hrpermissionsNew);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                        HrpermissionsNew hrpermissionsNew = new HrpermissionsNew();
                        hrpermissionsNew.BusinessGroupId = null;
                        hrpermissionsNew.CountryId = hrUserPermissionsVM.CountryId;
                        hrpermissionsNew.HruserId = hrusersNewDB.HruserId;
                        db.HrpermissionsNew.Add(hrpermissionsNew);
                        db.SaveChanges();
                    }
                }
                var hrUsersWithPermissions = db.Set<_GetHRUserWithPermissions_New>().FromSqlRaw("GetHRUserWithPermissions_New {0}", hrusersNewDB.UserName).ToList();
                return Ok(hrUsersWithPermissions);
            }
        }


    
        [HttpPost]
        [Route("DeleteBusinessForUser")]
        public IActionResult DeleteBusinessForUser(vmHRUserPermissions hrUserPermissionsVM)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var hrPermissionsDB = db.HrpermissionsNew.Where(p => p.HrpermissionsId == hrUserPermissionsVM.HRPermissionsId).SingleOrDefault();
                db.Remove(hrPermissionsDB);
                db.SaveChanges();
                return Ok(new { status = "Success" });
            }
        }

        [HttpPost]
        [Route("DeleteHRUser")]
        public IActionResult DeleteHRUser(vmHRUser hrUserPermissionsVM)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var hrPermissionsListDB = db.HrpermissionsNew.Where(p => p.HruserId == hrUserPermissionsVM.HRUserId).ToList();
                db.RemoveRange(hrPermissionsListDB);
                db.SaveChanges();

                var hrUserDB = db.HrusersNew.Where(p => p.HruserId == hrUserPermissionsVM.HRUserId).SingleOrDefault();
                db.Remove(hrUserDB);
                db.SaveChanges();
                return Ok(new { status = "Success" });
            }
        }

        [HttpGet]
        [Route("GetReportUrl")]
        public IActionResult GetReportUrl()
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var result = db.TblBireportLink.Where(p => p.IsDeleted == false).ToList().FirstOrDefault();
                return Ok(result);
            }
        }

        [HttpGet]
        [Route("GetEmpProfileTermination")]
        public IActionResult GetEmpProfileTermination(string employeeName = "", string email = "")
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var currentTerminatedUsers = db.Set<_ProfileUpdateEMPTermination>().FromSqlRaw("ProfilesListAllEMPTermination  {0} ,{1}", employeeName ?? string.Empty, email ?? string.Empty).ToList();
                    return Ok(currentTerminatedUsers);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Updates the Profile model
        /// </summary>
        /// <param name="workExpVM"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateEmployeeTermination")]
        public IActionResult UpdateEmployeeTermination(vmProfile profileVM)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var profiledbModel = db.Profiles.Where(p => p.ProfileId == profileVM.ProfileId).FirstOrDefault();
                profiledbModel.NetworkId = profileVM.NetworkId;
                profiledbModel.ManagerId = profileVM.ManagerId;
                profiledbModel.EmployeeNumber = profileVM.EmployeeNumber;
                profiledbModel.TerminationDate = profileVM.TerminationDate;
                profiledbModel.Email = profileVM.Email;
                profiledbModel.ModifiedBy = profileVM.NetworkId;
                profiledbModel.ModifiedOn = DateTime.Now;
                db.SaveChanges();
                return Ok(new { status = "Success" });
            }
        }

        [HttpGet]
        [Route("GetInstance")]
        public IActionResult GetInstance(string profileID)
        {
            try
            {
                if (!string.IsNullOrEmpty(profileID) && profileID != "0")
                {
                    using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                    {
                        var profile = db.Profiles.Where(p => p.NetworkId == profileID && p.TerminationDate == null).SingleOrDefault();
                        var appraisal = db.Appraisals.Where(a => a.AppraisalId == profile.AppraisalId).SingleOrDefault();
                        return Ok(appraisal);
                    }
                }
                else
                {
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetAppraisalTypesListActive")]
        public IActionResult GetAppraisalTypesListActive()
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var appraisalTypes = db.Set<AppraisalTypes>().FromSqlRaw("[dbo].[USP_GetAppraisalTypesforCycleOnOFF]").ToList();
                return Ok(appraisalTypes);
            }
        }

        [HttpGet]
        [Route("CloseAllAAppraisal")]
        public IActionResult CloseAllAAppraisal(int AppraisalTypeId)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var successmessage = db.Set<_closeallappraisal>().FromSqlRaw("[dbo].[CloseAllAppraisal]  {0}", AppraisalTypeId).ToList();
                if (successmessage != null)
                    if (successmessage.Count() > 0)
                        return Ok(new { status = successmessage[0].Status });
                    else
                        return Ok(new { status = "failed" });
                else
                    return Ok(new { status = "failed" });
            }
        }

        [HttpGet]
        [Route("CloseMidAAppraisal")]
        public IActionResult CloseMidAAppraisal(int AppraisalTypeId)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                if (AppraisalTypeId > 17)
                {
                    List<_closeallappraisal> result = db.Set<_closeallappraisal>().FromSqlRaw("[dbo].[CloseNewMidAllAppraisal] {0}", AppraisalTypeId).ToList();
                    if (result != null)
                        if (result.Count() > 0)
                            return Ok(new { status = result[0].Status });
                        else
                            return Ok(new { status = "failed" });
                    else
                        return Ok(new { status = "failed" });

                }
                else
                {
                    List<_closeallappraisal> result = db.Set<_closeallappraisal>().FromSqlRaw("[dbo].[CloseMidAllAppraisal] {0}", AppraisalTypeId).ToList();
                    return Ok(new { status = "Success" });
                }
            }
        }

        [HttpPost]
        [Route("ArchiveMidYearAppraisal")]
        public IActionResult ArchiveMidYearAppraisal(int ProfileId, int AppraisalTypeID, int AppraisalId, string ModifiedBy)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                if (AppraisalTypeID > 17)
                {
                    int result = db.Database.ExecuteSqlRaw("[dbo].[MidYearAppraisalArchiveProcess]  {0} ,{1}, {2},{3}", ProfileId, AppraisalId, AppraisalTypeID, ModifiedBy);
                    if (result > 0)
                        return Ok(new { status = "Success" });
                    else
                        return Ok(new { status = "Failed" });
                }
                else
                {
                    int result = db.Database.ExecuteSqlRaw("[dbo].[MidYearAppraisalArchive]  {0} ,{1}, {2}", ProfileId, AppraisalId, ModifiedBy);
                    if (result > 0)
                        return Ok(new { status = "Success" });
                    else
                        return Ok(new { status = "Failed" });
                }
            }
        }

        //Manual Appraisal Close
        [HttpGet]
        [Route("AppraisalToCloseYearEnd")]
        public IActionResult AppraisalToCloseYearEnd(int AppraisalTypeID, string EmployeeNetworkId)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var closeappraisal = db.Set<_Appraisals>().FromSqlRaw("[dbo].[AppraisalsToCloseYearEnd] {0},{1}", AppraisalTypeID, EmployeeNetworkId).ToList().FirstOrDefault();

                if (closeappraisal != null)
                {
                    Appraisals appraisalDb = db.Appraisals.Where(p => p.AppraisalId == closeappraisal.AppraisalId).FirstOrDefault();
                    if (appraisalDb != null)
                    {
                        if (appraisalDb.EmployeeName == null)
                        {
                            appraisalDb.EmployeeName = "HR Close";
                            appraisalDb.EmployeeSignDate = DateTime.Now;
                        }
                        if (appraisalDb.ManagerName == null)
                        {
                            appraisalDb.ManagerName = "HR Close";
                            appraisalDb.ManagerSignDate = DateTime.Now;
                        }
                        if (appraisalDb.ManagersManagerName == null)
                        {
                            appraisalDb.ManagersManagerName = "HR Close";
                            appraisalDb.ManagersManagerSignDate = DateTime.Now;
                        }
                        appraisalDb.ModifiedBy = "Auto HR Close";
                        appraisalDb.ModifiedOn = DateTime.Now;
                        db.SaveChanges();

                    }

                    int result = ArchiveAppraisal(appraisalDb.AppraisalId);
                    if (result > 0)
                        return Ok(new { status = "Success" });
                    else
                        return Ok(new { status = "Failed" });
                }
                else
                    return Ok(new { status = "" });
            }
        }

        private int ArchiveAppraisal(int AppraisalId)
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {

                    int x = db.Database.ExecuteSqlRaw("[dbo].[proc_Appraisal_Archive] {0} ", AppraisalId);
                    db.SaveChanges();
                    return x;
                }
            }
            catch (Exception ex)
            {
                // Log the error (you can save this to an error table or log it as needed)
                var error = new TblErrors
                {
                    ErrorMessage = ex.Message,
                    ErrorNumber = ex.HResult,
                    ErrorProcedure = "proc_Appraisal_Archive(AdminController)",
                    ErrorLine=560
                };

                // Assuming SaveErrors is a method to log the error in the database
                SaveErrors(error);

                // You can rethrow the exception if needed or return an error-specific value
                throw;
            }
            }
        public IActionResult SaveErrors(TblErrors item)
        {
            bool status = false;
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var result = db.Database.ExecuteSqlCommand("proc_SaveErros {0},{1},{2},{3},{4},{5}", item.ErrorMessage, item.ErrorNumber, item.ErrorSeverity, item.ErrorState, item.ErrorLine, item.ErrorProcedure);
                    if (result > 0) { status = true; }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(status);
        }
        [HttpGet]
        [Route("MidYearAppraisalToClose")]
        public IActionResult MidYearAppraisalToClose(int AppraisalTypeID, string EmployeeNetworkId)
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var closeMidYear = db.Set<_MidYear>().FromSqlRaw("MidYearAppraisalToClose {0},{1}", AppraisalTypeID, EmployeeNetworkId).ToList();
                    var profile = db.Profiles.Where(p => p.NetworkId == EmployeeNetworkId && p.TerminationDate == null).FirstOrDefault();

                    if (closeMidYear.Count > 0)
                    {
                        foreach (var midYear in closeMidYear)
                        {
                            MidYear midYearDb = db.MidYear.Where(p => p.ProfileId == midYear.ProfileId && p.MidYearId == midYear.MidYearId).FirstOrDefault();
                            if (midYearDb != null)
                            {
                                if (midYear.EmpSignDate == null)
                                {
                                    midYearDb.EmployeeName = "HR Close";
                                    midYearDb.EmpSignDate = System.DateTime.Now;
                                    midYearDb.ModifiedBy = "Auto HR Close";
                                    midYearDb.ModifiedOn = System.DateTime.Now;
                                }
                                if (midYear.MgrSignDate == null)
                                {
                                    midYearDb.ManagerName = "HR Close";
                                    midYearDb.MgrSignDate = System.DateTime.Now;
                                    midYearDb.ModifiedBy = "Auto HR Close";
                                    midYearDb.ModifiedOn = System.DateTime.Now;
                                }
                                db.SaveChanges();
                            }
                        }
                    }
                    if (AppraisalTypeID > 17)
                    {
                        int result = db.Database.ExecuteSqlRaw("[dbo].[MidYearAppraisalArchiveProcess]  {0} ,{1}, {2},{3}", profile.ProfileId, profile.AppraisalId, AppraisalTypeID, "HR Close");
                        if (result > 0)
                            return Ok(new { status = "Success" });
                        else
                            return Ok(new { status = "Failed" });
                    }
                    else
                    {
                        int result = db.Database.ExecuteSqlRaw("[dbo].[MidYearAppraisalArchive]  {0} ,{1}, {2}", profile.ProfileId, profile.AppraisalId, "HR Close");
                        if (result > 0)
                            return Ok(new { status = "Success" });
                        else
                            return Ok(new { status = "Failed" });
                    }
                }
            }
            catch (Exception ex)
            {
                return Ok(new { status = "" });
            }
        }

        [HttpGet]
        [Route("HumanResourceListByAppraisalId")]
        public IActionResult HumanResourceListByAppraisalId(int appraisalID)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var humanResourceDB = db.HumanResource.Where(p => p.AppraisalId == appraisalID).FirstOrDefault();

                return Ok(humanResourceDB);
            }
        }

        //[HttpGet]
        //[Route("CheckisValidHR")]
        //public IActionResult CheckisValidHR()
        //{
        //    int appraisalID = 8973;
        //    using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
        //    {
        //        bool isvalidHrRep = db.HumanResource.Any(p => p.AppraisalId == appraisalID);

        //        return Ok(new { status = isvalidHrRep });
        //    }
        //}

        [HttpGet]
        [Route("MidYearByAppraisalID")]
        public IActionResult MidYearByAppraisalID(int appraisalID)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var profileDB = db.Profiles.Where(p => p.AppraisalId == appraisalID).FirstOrDefault();
                var midyearDB = db.MidYear.Where(s => s.ProfileId == profileDB.ProfileId).FirstOrDefault();

                return Ok(midyearDB);
            }
        }

        [HttpPost]
        [Route("UpdateEmployeeAppraisalStatus")]
        public IActionResult UpdateEmployeeAppraisalStatus(vmAppraisals appraisal)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                // var profileDB = db.Profiles.Where(p => p.AppraisalId == appraisal.AppraisalId).FirstOrDefault();
                var appraisalModel = db.Appraisals.Where(p => p.AppraisalId == appraisal.AppraisalId).FirstOrDefault();
                if (appraisalModel != null)
                {
                    appraisalModel.SelfAssessmentComplete = appraisal.SelfAssessmentComplete;
                    appraisalModel.ManagerStepComplete = appraisal.ManagerStepComplete;
                    appraisalModel.EmployeeName = appraisal.EmployeeName;
                    appraisalModel.EmployeeSignDate = appraisal.EmployeeSignDate;
                    appraisalModel.ManagerName = appraisal.ManagerName;
                    appraisalModel.ManagerSignDate = appraisal.ManagerSignDate;
                    appraisalModel.ModifiedBy = appraisal.LoggedInUser.NetworkId.ToString();
                    appraisalModel.ModifiedOn = DateTime.Now;
                    //db.Appraisals.Add(appraisalModel);
                    db.SaveChanges();
                    return Ok(new { status = "Success" });
                }
                return Ok(new { status = "" });
            }
        }

        [HttpPost]
        [Route("UpdateMidYearAppraisalStatus")]
        public IActionResult UpdateMidYearAppraisalStatus(vmMidYear midYearVm)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var MidYearDb = db.MidYear.Where(p => p.ProfileId == midYearVm.ProfileId).SingleOrDefault();
                if (MidYearDb != null)
                {
                    MidYearDb.EmployeeName = null;
                    MidYearDb.ReviewDate = null;
                    MidYearDb.EmpSignDate = null;
                    MidYearDb.ModifiedBy = midYearVm.LoggedInUser.NetworkId.ToString();
                    MidYearDb.ModifiedOn = DateTime.Now;
                    db.SaveChanges();

                    return Ok(new { status = "Success" });
                }
                return Ok(new { status = "" });
            }
        }

        [HttpGet]
        [Route("GetTranslationLanguageList")]
        public IActionResult GetTranslationLanguageList()
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var translationLanguageDb = db.TranslationLanguages.Where(p => p.IsActive == true).ToList();
                return Ok(translationLanguageDb);
            }
        }

        [HttpPost]
        [Route("UpdateWelcomeMessage")]
        public IActionResult UpdateWelcomeMessage(vmTranslationLanguages vmtrans)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                string[] stringSeparators = new string[] { "\r\n" };
                string[] Codes = vmtrans.Code.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                string[] Description = vmtrans.WelcomeText.Split(stringSeparators, StringSplitOptions.None);
                for (int i = 0; i < Codes.Length; i++)
                {
                    var TranLangDb = db.TranslationLanguages.Where(p => p.Code == Codes[i]).SingleOrDefault();
                    if (TranLangDb != null)
                    {
                        TranLangDb.WelcomeText = Description[i];
                        TranLangDb.ModifiedBy = "Admin";
                        TranLangDb.ModifiedOn = DateTime.Now;
                        db.SaveChanges();
                    }
                    else
                    {
                        return Ok(new { status = "" });
                    }
                }
                return Ok(new { status = "Success" });
            }
        }

        [HttpGet]
        [Route("GetWelcomeText")]
        public IActionResult GetWelcomeText(string code)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var TranLang = db.TranslationLanguages.Where(p => p.Code == code).FirstOrDefault();
                if (TranLang != null)
                {
                    return Ok(TranLang);
                }
                else
                {
                    var result = db.TranslationLanguages.Where(p => p.Code == "en").FirstOrDefault();
                    return Ok(result);
                }

            }
        }

        [HttpGet]
        [Route("GetProfilesforHREmployee")]
        public IActionResult GetProfilesforHREmployee()
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var allUsers = db._ProfilesListWithCEO_NewSP.FromSqlRaw("ProfilesListWithCEO_New").ToList();
                return Ok(allUsers);
            }
        }

        [HttpGet]
        [Route("GetEmployeeMaster")]
        public IActionResult GetEmployeeMaster()
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var allUsers = db.TblHritmasterData.ToList();
                var dataset = db.TblHritmasterData.
                Select(x => new HRITData
                {
                    AD_USERNAME=x.AdUsername,
                    ASSIGNMENT_STATUS=x.AssignmentStatus,
                    ASSIGNMENT_CATEGORY=x.AssignmentCategory,
                    EmployeeId = x.EmployeeNumber,
                    Name = x.LastName + ',' + x.FirstName,
                    Country = x.CountryName,
                    Division = x.DivisionName,
                    Email = x.EmailAddress,
                    JobFamily = x.JobFamily,
                    JobType = x.DirectIndirect,
                    Location = x.LocationCode,
                    SALARY_BASIS = x.SalaryBasis,
                    Supervisor = x.SupervisorName,
                    START_DATE=x.StartDate,
                    TERMINATIONDATE = x.Terminationdate
                }).ToList();
                return Ok(dataset);
            }
        }

        [HttpGet]
        [Route("GetUsersByAppraisalTypeID")]
        public IActionResult GetUsersByAppraisalTypeID(int AppraisalTypeID)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                var allUsers = db._ProfilesListWithCEO_NewSP.FromSqlRaw("GetUsersByAppraisalTypeID {0}", AppraisalTypeID).ToList();
                return Ok(allUsers);
            }
        }

        [HttpPost]
        [Route("UpdateHRITDataToHTS")]
        public IActionResult UpdateHRITDataToHTS()
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var status = db._SP_HRTItoHTSFeed.FromSqlRaw("SP_HRTItoHTSFeed").ToList().FirstOrDefault();
                    return Ok(status);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetEmployeeAcceesToDevSuppTabs")]
        public IActionResult GetEmployeeAcceesToDevSuppTabs(string NetworkId, string EmployeeNumber)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {
                try
                {
                    var result = db.EmployeeTabAccess.FromSqlRaw("USP_GetEmployeeAcceesToDevSuppTabs {0},{1}", NetworkId, EmployeeNumber).ToList();
                    return Ok(result);
                }
                catch (Exception)
                {
                    return Ok();
                }

            }
        }


        [HttpPost]
        [Route("SaveAssessmentCyclesOnOff")]
        public IActionResult AssessmentCyclesOnOff(AssessmentCyclesOnOff assessment)
        {
            bool status = false;
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    assessment.ModifiedOn = DateTime.UtcNow;
                    var result = db.Database.ExecuteSqlCommand("proc_AssessmentCyclesOnOff_Insert {0},{1},{2},{3},{4},{5}", assessment.AppraisalTypeID, assessment.IsDisabled, assessment.Description, assessment.ModifiedBy, assessment.ModifiedOn, assessment.IsActive);
                    if (result > 0) { status = true; }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(status);
        }




        [HttpGet]
        [Route("GetAssessmentCyclesOnOff")]
        public IActionResult GetAssessmentCyclesOnOff()
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var res = db.SP_AssessmentCycles.FromSqlRaw("proc_AssessmentCyclesOnOff_List").ToList();
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        [Route("GetAssessmentCyclesOnOffByID")]
        public IActionResult GetAssessmentCyclesOnOffByID(string apprisalType)
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var res = db.AssessmentCycles.FromSqlRaw("proc_AssessmentCyclesOnOff_ByID {0}", apprisalType).ToList();
                    return Ok(res);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetEmpProfileTerminationModified")]
        public IActionResult GetEmpProfileTermination_MODFD(string searchParam)
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var currentTerminatedUsers = db.Set<_ProfileUpdateEMPTermination>().FromSqlRaw("ProfilesListAllEMPTermination  {0}", searchParam ?? string.Empty).ToList();
                    return Ok(currentTerminatedUsers);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #region HRreviewUsers


        [HttpPost]
        [Route("CreateHrBPUserAndPermissions")]
        public IActionResult CreateHrBPUserAndPermissions(vmHRBPUserPermissions hrUserPermissionsVM)
        {
            using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
            {

                bool status = false;
                try
                {
                    if (!string.IsNullOrEmpty(hrUserPermissionsVM.BusinessGroupId))
                    {
                        string[] stringSeparators = new string[] { "," };
                        string[] Codes = hrUserPermissionsVM.BusinessGroupId.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in Codes)
                        {
                            HRReviewUsers hRReviewUsers = new HRReviewUsers();
                            hRReviewUsers.BusinessGroupId = Convert.ToInt32(item);
                            hRReviewUsers.CountryId = hrUserPermissionsVM.CountryId;
                            hRReviewUsers.NetworkID = hrUserPermissionsVM.NetworkID;
                            hRReviewUsers.Updatedby = hrUserPermissionsVM.LoggedInUser.NetworkId;
                            hRReviewUsers.IsActive = hrUserPermissionsVM.IsActive;
                            hRReviewUsers.UpdatedOn = DateTime.UtcNow;
                            db.hRReviewUsers.Add(hRReviewUsers);
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }



                return Ok(status);
            }
        }
        [HttpGet]
        [Route("GetAllHRReviewers")]
        public IActionResult GetEmpProfileTermination_MODFD()
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var currentTerminatedUsers = db.Set<vmHRBPUsers>().FromSqlRaw("USP_GETHRReviewers").ToList();
                    return Ok(currentTerminatedUsers);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("UpdateHrBPReviewUsers")]
        public IActionResult UpdateHrBPReviewUsers(vmHRBPUserPermissions hrUserPermissionsVM)
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {

                    var hrPermissionDB = db.hRReviewUsers.Where(p => p.Id == hrUserPermissionsVM.Id).FirstOrDefault();
                    hrPermissionDB.CountryId = hrUserPermissionsVM.CountryId;
                    //here issue is taking updated by from previous list check other entities also;
                    hrPermissionDB.Updatedby = hrUserPermissionsVM.LoggedInUser.NetworkId;
                    hrPermissionDB.UpdatedOn = DateTime.UtcNow;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            return Ok(new { status = "Success" });
        }
        [HttpGet]
        [Route("GetHRReviewersByNetworkID")]
        public IActionResult GetHRReviersByID(string networkID)
        {
            try
            {
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var hrreviwers = db.Set<vmGETHRReviewerDetails>().FromSqlRaw("USP_GETHRReviewerDetails {0}", networkID ?? string.Empty).ToList();
                    return Ok(hrreviwers);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("deleteHrReviewUserAccess")]
        public IActionResult DeleteHrReviewUserAccess(vmHRBPUserPermissions item)
        {
            try
            {
                bool status = false;
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var result = db.Database.ExecuteSqlCommand("USP_DeleteReviewerAccessByID {0} , {1}", item.Id, item.LoggedInUser.NetworkId);
                    if (result > 0) { status = true; }
                    return Ok(status);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("deleteHrReviewUser")]
        public IActionResult DeleteHrReviewUser(vmHRBPUserPermissions item)
        {
            try
            {
                bool Status = false;
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var res = db.Database.ExecuteSqlCommand("USP_DeleteReviewer {0} , {1}", item.NetworkID, item.LoggedInUser.NetworkId);
                    if (res > 0)
                    {
                        Status = true;
                    }
                    return Ok(Status);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        [HttpGet]
        [Route("managersignoff")]
        public ActionResult EmpsignOFF(int apprisalID)
        {
            try
            {
                bool Status = false;
                using (Performance_ManagmentContextDbo db = new Performance_ManagmentContextDbo())
                {
                    var res = db.Database.ExecuteSqlCommand("proc_Mangersignoff {0} ", apprisalID);
                    if (res > 0)
                    {
                        Status = true;
                    }
                    return Ok(Status);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}