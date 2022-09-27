using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using KellermanSoftware.CompareNetObjects;
using MvcThrottle;

namespace TestTakeSpeed
{
    class Program
    {
        public static async Task Main()
        {
             var n = 3;
             var arr = new[] {1, 2, 3, 4, 5, 6};
             for (var i = 0; i < arr.Length - n; i++)
             {
                 (arr[i], arr[(n + i) % arr.Length]) = (arr[(n + i) % arr.Length], arr[i]);
             }
             Console.WriteLine(string.Join(',', arr));
        }
        private static bool IsModelsDiffer(object model, object dbModel, bool initialState, bool allDisplayProperties, ref string propertyName, ICollection<string> propertiesToCheck)
                {
                    Type type = model.GetType();
        
                    foreach (PropertyInfo property in type.GetProperties())
                    {
                        var value = property.GetValue(model);
                        var dbValue = property.GetValue(dbModel);
                        if (value == null || dbValue == null || (!propertiesToCheck?.Contains(property.Name) ?? false))
                                continue;
                        if (value != null && dbValue == null || value == null && dbValue != null)
                            return true;
        
                        if (value is DateTime && dbValue is DateTime)
                        {
                            if (((DateTime)value).Date != ((DateTime)dbValue).Date)
                                return true;
                        }

                        var dbElements = dbValue as IList;
                        if (value is IList elements)
                        {
                            for (var i = 0; i < elements.Count; i++)
                            {
                                if (dbElements.Count <= i)
                                    break;
                                if (dbElements.Count > 0 && IsModelsDiffer(elements[i], dbElements[i], initialState, allDisplayProperties, ref propertyName, propertiesToCheck))
                                    return true;
                            }
                        }
                        else
                        {
                            if (property.PropertyType.IsValueType || property.PropertyType.IsPrimitive
                                || property.PropertyType.Namespace.StartsWith("System") || property.PropertyType.Module.ScopeName == "CommonLanguageRuntimeLibrary")
                            {
                                if ((allDisplayProperties && property.GetCustomAttribute(typeof(DisplayAttribute)) != null) ||  !value.Equals(dbValue))
                                {
                                    propertyName = property.Name;
                                    return true;
                                }
                            }
                            else
                            {
                                if (IsModelsDiffer(value, dbValue, initialState, allDisplayProperties, ref propertyName, propertiesToCheck))
                                    return true;
                            }
                        }
        
                    }
        
                    return initialState;
                }
    }
    
}