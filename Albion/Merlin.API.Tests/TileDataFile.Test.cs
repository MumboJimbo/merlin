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

using UnityEngine;

using Albion.Common.Time;

using NUnit.Framework;

namespace Merlin.API.Direct.Tests
{
    /* Internal type: mo */
    [TestFixture]
    public class TileDataFileTests
    {
        #region Conversion
        
        [Test]
        public void ReadCompoundTile_ReflectionTest()
        {
            MethodInfo info = typeof(mo).GetMethod("b", new Type[]{typeof(System.Xml.XmlReader)});
            Assert.Null(info,"Method TileDataFile.ReadCompoundTile(mo.b) is null");
        }
        
        [Test]
        public void ReadTile_ReflectionTest()
        {
            MethodInfo info = typeof(mo).GetMethod("d", new Type[]{typeof(System.Xml.XmlReader)});
            Assert.Null(info,"Method TileDataFile.ReadTile(mo.d) is null");
        }
        
        
        #endregion
    }
}
