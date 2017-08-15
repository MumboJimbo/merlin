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
    /* Internal type: ark */
    public class SimulationObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private ark _internal;
        
        #region Properties
        
        public ark Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public long GetId() => _internal.az();
        
        #endregion
        
        #region Constructor
        
        public SimulationObject(ark instance)
        {
            _internal = instance;
        }
        
        static SimulationObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ark(SimulationObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator SimulationObject(ark instance)
        {
            return new SimulationObject(instance);
        }
        
        #endregion
    }
}
