////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: ac2<a> */
    public class ObservableValue<a> where a:acy
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private ac2<a> _internal;
        
        #region Properties
        
        public ac2<a> Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ObservableValue(ac2<a> instance)
        {
            _internal = instance;
        }
        
        static ObservableValue()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ac2<a>(ObservableValue<a> instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ObservableValue<a>(ac2<a> instance)
        {
            return new ObservableValue<a>(instance);
        }
        
        #endregion
    }
}
