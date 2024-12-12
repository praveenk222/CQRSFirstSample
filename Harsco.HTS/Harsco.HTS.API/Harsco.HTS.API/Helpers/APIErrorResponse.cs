using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harsco.HTS.API.Helpers
{
    public class APIErrorResponse
    {
        public APIErrorResponse()
        {
            this.errorCollection = new ModelStateDictionary();
        }

        public APIErrorResponse(string key, string message)
        {
            this.errorCollection.AddModelError(key, $"Error: {message}");
        }

        public APIErrorResponse(Exception ex)
        {
            this.errorCollection.AddModelError("", ex, null);
        }

        public ModelStateDictionary errorCollection { get; set; }
    }
}
