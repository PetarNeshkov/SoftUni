﻿using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldNames)
        {
            Type classType = Type.GetType(className);

            var fields = classType
                .GetFields(BindingFlags.Instance
                | BindingFlags.Static 
                | BindingFlags.Public 
                | BindingFlags.NonPublic)
                .Where(x => fieldNames.Contains(x.Name));

            Object classInstance = Activator.CreateInstance(classType);

            StringBuilder result = new StringBuilder();

            result.AppendLine($"Class under investigation: {className}");

            foreach (var field in fields)
            {
                result.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return result.ToString().TrimEnd();
        }

        public string AnalyzeAcessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] nonPublicFields = classType.GetFields(BindingFlags.Instance 
                | BindingFlags.Public);

            var nonPublicGetters = classType
                .GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.Name.StartsWith("get"));

            var publicSetters = classType
                .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .Where(x => x.Name.StartsWith("set"));

            var result = new StringBuilder();

            foreach (var field in nonPublicFields)
            {
                result.AppendLine($"{field.Name} must be private!");
            }

            foreach (var getter in nonPublicGetters)
            {
                result.AppendLine($"{getter.Name} have to be public!");
            }

            foreach (var setter in publicSetters)
            {
                result.AppendLine($"{setter.Name} have to be private!");
            }

            return result.ToString().TrimEnd();
        }

        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);

            MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.Instance 
                | BindingFlags.NonPublic);

            StringBuilder result = new StringBuilder();

            result.AppendLine($"All Private Methods of Class: {className}");
            result.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (var method in privateMethods)
            {
                result.AppendLine($"{method.Name}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
