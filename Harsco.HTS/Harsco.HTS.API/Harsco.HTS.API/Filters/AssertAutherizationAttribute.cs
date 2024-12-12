using Harsco.HTS.API.Controllers;
//using Harsco.Services.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Filters
{
    public class AssertAutherizationAttribute : ActionFilterAttribute
    {
        public string FeatureAccessCode { get; set; }

        //public override void OnActionExecuting(ActionExecutingContext context)
        //{
        //    IAutherizationManager autherizationManager = (IAutherizationManager)context.HttpContext.RequestServices.GetService(typeof(IAutherizationManager));

        //    string[] scopeRequiredByAPI = new string[] { "AllFeaturesAccess" };
        //    var userAccessResult = autherizationManager.AssertAutherization(scopeRequiredByAPI, FeatureAccessCode);

        //    if (userAccessResult == null)
        //    {
        //        context.ModelState.AddModelError("", $"Unauthorized access detected for {FeatureAccessCode} feature.");
        //        context.Result = new UnauthorizedObjectResult(context.ModelState);
        //        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
        //    }
        //    else
        //    {
        //        ((APIControllerBase)context.Controller).UserId = userAccessResult.UserId;
        //        ((APIControllerBase)context.Controller).UserRoleAccessLevel = userAccessResult.AccessLevelId;
        //        ((APIControllerBase)context.Controller).UserRoleAccessLevelEntity = userAccessResult.AccessLevelEntities;
        //    }
        //}
    }
}
