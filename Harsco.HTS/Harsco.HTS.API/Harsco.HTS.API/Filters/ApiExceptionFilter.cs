using Harsco.HTS.API.Helpers;
using Harsco.HTS.Plotform.Exceptions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Filters
{
    public class ApiExceptionFilter : IExceptionFilter
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IModelMetadataProvider _modelMetadataProvider;

        public ApiExceptionFilter(IHostingEnvironment hostingEnvironment, IModelMetadataProvider modelMetadataProvider)
        {
            _hostingEnvironment = hostingEnvironment;
            _modelMetadataProvider = modelMetadataProvider;
        }

        public void OnException(ExceptionContext context)
        {
            if (context.Exception is DuplicateRecordException)
            {
                context.ModelState.AddModelError(string.Empty, context.Exception.Message);
                context.Result = new BadRequestObjectResult(context.ModelState.Errors());
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is UnAuthorisedAccessException)
            {
                context.ModelState.AddModelError(string.Empty, context.Exception.Message);
                context.Result = new UnauthorizedObjectResult(context.ModelState.Errors());
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            }
            else
            {
                context.ModelState.AddModelError(string.Empty, context.Exception.Message);
                context.Result = new ObjectResult(context.ModelState.Errors());
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
        }
    }
}
