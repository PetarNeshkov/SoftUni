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

            var classFields = classType.GetFields(BindingFlags.Instance
                 | BindingFlags.Static
                 | BindingFlags.Public
                 | BindingFlags.NonPublic).Where(x => fieldNames.Contains(x.Name));

            Object classInstance = Activator.CreateInstance(classType);
            StringBuilder fieldsInfo = new StringBuilder();

            fieldsInfo.AppendLine($"Class under investigation: {className}");
            foreach (var field in classFields)
            {
                fieldsInfo.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return fieldsInfo.ToString().TrimEnd();
        }
    }
}
