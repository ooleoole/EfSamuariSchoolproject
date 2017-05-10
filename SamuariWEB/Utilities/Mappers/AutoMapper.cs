using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Remotion.Linq.Clauses.ResultOperators;

namespace SamuraiWEB.Utilities.Mappers
{
    public static class AutoMapper
    {
        public static TResult Map<TResult>(object target)
        {
            var targetClassName = target.GetType().Name;
            var resultClassName = typeof(TResult).Name;

            ValidateMappingSetup(targetClassName, resultClassName);

            
            var targetPropMap = GetPropertiesMap(target);
            var instance = (TResult)Activator.CreateInstance(typeof(TResult));
            var resultPropMap = GetPropertiesMap(instance);

            return (TResult)Activator.CreateInstance(typeof(TResult));
        }

        private static List<List<PropertyInfo>> GetPropertiesMap(object obj)
        {
            bool looper;
            var objProperties = GetTargetsProperties(obj);
            var propMap = new List<List<PropertyInfo>>();
            do
            {
                var simpleProperties = new List<PropertyInfo>();
                var nextLevelOfProps = new List<PropertyInfo>();
                foreach (var property in objProperties)
                {
                    var propType = property.PropertyType;
                    if (propType.GetTypeInfo().IsClass && propType != typeof(string))
                    {
                        var test = property.PropertyType.GetProperties();
                        nextLevelOfProps.AddRange(test);
                    }
                    else
                    {
                        simpleProperties.Add(property);
                    }
                }
                objProperties = nextLevelOfProps;
                looper = nextLevelOfProps.Count != 0;
                propMap.Add(simpleProperties);
            } while (looper);
            return propMap;
        }

        private static List<PropertyInfo> GetTargetsProperties(object target)
        {
            return target.GetType().GetProperties().ToList();
        }

        private static void ValidateMappingSetup(string targetClassName, string resultClassName)
        {
            if (targetClassName.Replace("ViewModel", "") !=
                resultClassName.Replace("ViewModel", "")) throw new ArgumentException("Invalid mapping");
        }
    }
}
