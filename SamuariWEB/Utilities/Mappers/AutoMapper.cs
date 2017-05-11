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

            var resultInstance = (TResult)Activator.CreateInstance(typeof(TResult));
            var resultProps = resultInstance.GetType().GetProperties();
            var targetProps = target.GetType().GetProperties();
            foreach (var resultProp in resultProps)
                foreach (var targetProp in targetProps)
                    if (resultProp.Name == targetProp.Name && resultProp.PropertyType == targetProp.PropertyType)
                        SetTargetsValueToResultInstance(target, targetProp, resultProp, resultInstance);
            return resultInstance;
        }

        private static void SetTargetsValueToResultInstance<TResult>(object target, PropertyInfo targetProp,
            PropertyInfo resultProp, TResult resultInstance)
        {
            var value = targetProp.GetValue(target);
            resultProp.SetValue(resultInstance, value);
        }

        private static void ValidateMappingSetup(string targetClassName, string resultClassName)
        {
            if (targetClassName.Replace("ViewModel", "") !=
                resultClassName.Replace("ViewModel", "")) throw new ArgumentException("Invalid mapping");
        }
    }
}
