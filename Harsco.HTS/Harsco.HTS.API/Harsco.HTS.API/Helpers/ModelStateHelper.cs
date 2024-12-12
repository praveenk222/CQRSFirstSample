using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Harsco.HTS.API.Helpers
{
    public static class ModelStateHelper
    {
        public static Dictionary<string, string[]> Errors(this ModelStateDictionary modelState)
        {
            if (!modelState.IsValid)
            {
                return modelState.ToDictionary(
                   kvp => kvp.Key,
                   kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray());
            }

            return null;
        }

        public static void BindModelTo<T, TEntity>(this T model, TEntity efModel) where T : class
        {
            PropertyInfo pInfo;
            foreach (var tProperty in model.GetType().GetProperties())
            {
                try
                {
                    pInfo = efModel.GetType().GetProperty(tProperty.Name);
                    if (pInfo != null)
                        if (!IsGenericCollection(tProperty))
                            pInfo.SetValue(efModel, tProperty.GetValue(model));
                }
                catch (Exception ex)
                {
                    string errorMsg = "There was an issue in BindModelTo for fields: " + efModel.GetType().GetProperty(tProperty.Name).ToString() + "<br/><br/>" + ex.Message;
                    throw new Exception(errorMsg);
                }
            }
        }

        private static bool IsGenericCollection(PropertyInfo PInfo)
        {
            Type tColl = typeof(ICollection<>);
            Type gType = (PInfo.PropertyType.IsGenericType ? PInfo.PropertyType.GetGenericTypeDefinition() : null);
            bool isCollection = gType != null && (tColl.IsAssignableFrom(gType.GetGenericTypeDefinition()) || gType.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == tColl));
            return isCollection;
        }
    }
}