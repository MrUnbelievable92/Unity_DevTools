﻿using System;

namespace DevTools
{
    /// <summary>    Methods must be static, parameterless and return a boolean, representing the test result.   </summary>
    
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class UnitTestAttribute : Attribute
    {
        public UnitTestAttribute(params string[] categories)
        {
            Categories = categories ?? new string[0];
        }


        public string[] Categories { get; protected set; }
    }
}