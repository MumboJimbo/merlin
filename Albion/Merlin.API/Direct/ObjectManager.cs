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
    /* Internal type: alb */
    public class ObjectManager
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private alb _internal;
        
        #region Properties
        
        public alb Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public CollisionManager GetCollisionManager() => _internal.w();
        public ClusterDescriptor GetCurrentCluster() => _internal.u();
        public static ObjectManager GetInstance() => alb.a();
        public LocalPlayerCharacter GetLocalPlayerCharacter() => _internal.aa();
        public SimulationObject GetObject(long A_0) => _internal.a((long)A_0);
        public Dictionary<long,ark> GetObjectMap() => (Dictionary<long,ark>)_methodReflectionPool[0].Invoke(_internal,new object[]{});
        public IEnumerable GetObjects() => _internal.z();
        public ICollection<SimulationObject> GetObjects<a>() where a:ark => (ICollection<SimulationObject>)_internal.ak<a>();
        public PlayerCharacter GetPlayerCharacter(Guid A_0) => _internal.a((Guid)A_0);
        
        #endregion
        
        #region Constructor
        
        public ObjectManager(alb instance)
        {
            _internal = instance;
        }
        
        static ObjectManager()
        {
            _methodReflectionPool.Add(typeof(alb).GetMethod("ai", new Type[]{}));
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator alb(ObjectManager instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ObjectManager(alb instance)
        {
            return new ObjectManager(instance);
        }
        
        #endregion
    }
}
