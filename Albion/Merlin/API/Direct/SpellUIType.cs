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

namespace Merlin.API.Direct
{
    /* Internal type: gz.SpellUiType */
    public enum SpellUiType
    {
        None = 0,
        Heal = 1,
        CrowdControl = 2,
        Damage = 3,
        Buff = 4,
        Debuff = 5,
        Movement = 6
    }

    public static class SpellUiTypeExtensions
    {
        public static gz.SpellUiType ToInternal(this SpellUiType instance)
        {
            return (gz.SpellUiType)instance;
        }
        
        public static SpellUiType ToWrapped(this gz.SpellUiType instance)
        {
            return (SpellUiType)instance;
        }
    }
}