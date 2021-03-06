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
    /* Internal type: ar3 */
    public class MountItemObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private ar3 _internal;
        
        #region Properties
        
        public ar3 Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public MountItemObject(ar3 instance)
        {
            _internal = instance;
        }
        
        static MountItemObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator ar3(MountItemObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator MountItemObject(ar3 instance)
        {
            return new MountItemObject(instance);
        }
        
        #endregion
    }
}
