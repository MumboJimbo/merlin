using System;
using System.Collections.Generic;
using System.Linq;
using Merlin.API.Direct;


using UnityEngine;

namespace Merlin.API
{
    public class Spell
    {
        #region Static

        #endregion

        #region Fields

        private LocalPlayerCharacterView _owner;
        private SpellSlot _internalSpell;
        private CharacterSpellSlot _slot;

        #endregion

        #region Properties and Events

        public CharacterSpellSlot SpellSlot => _slot;

        public LocalPlayerCharacterView Owner => _owner;

        public SpellConfiguration Configuration
        {
            get
            {
                if (_internalSpell != null)
                    return new SpellConfiguration(_internalSpell.GetSpellDescriptor());

                return default(SpellConfiguration);
            }
        }

        public string Name
        {
            get
            {
                var configuration = Configuration;

                if (configuration != null)
                    return configuration.Name;

                return String.Empty;
            }
        }

        public SpellCategory Category
        {
            get
            {
                var configuration = Configuration;

                if (configuration != null)
                    return configuration.Category;

                return SpellCategory.None;
            }
        }

        public SpellTarget Target
        {
            get
            {
                var configuration = Configuration;

                if (configuration != null)
                    return configuration.Target;

                return SpellTarget.None;
            }
        }

        public int Cost
        {
            get
            {
                var configuration = Configuration;

                if (configuration != null)
                    return configuration.Cost;

                return 0;
            }
        }

        public bool IsReady => _internalSpell.GetCooldownPercent(Albion.Common.Time.GameTimeStamp.Now) == 100f;

        #endregion

        #region Constructors and Cleanup

        public Spell(LocalPlayerCharacterView owner, adu internalSpell, CharacterSpellSlot slot)
        {
            _owner = owner;
            _internalSpell = internalSpell;
            _slot = slot;
        }

        #endregion

        #region Methods

        #endregion
    }

    public class SpellConfiguration
    {
        #region Static

        #endregion

        #region Fields

        private CastSpellDescriptor _internalConfiguration; //g0

        #endregion

        #region Properties and Events

        public string Name
        {
            get
            {
                if (_internalConfiguration != null)
                    return _internalConfiguration.parent.GetName();

                return String.Empty;
            }
        }

        public SpellCategory Category
        {
            get
            {
                if (_internalConfiguration != null)
                    return _internalConfiguration.parent.GetSpellCategory();

                return SpellCategory.None;
            }
        }

        public SpellTarget Target
        {
            get
            {
                if (_internalConfiguration != null)
                    return _internalConfiguration.parent.GetSpellTarget();

                return SpellTarget.None;
            }
        }

        public int Cost
        {
            get
            {
                if (_internalConfiguration != null)
                    return _internalConfiguration.parent.Internal.dv;

                return 0;
            }
        }

        #endregion

        #region Constructors and Cleanup

        public SpellConfiguration(g0 internalConfiguration)
        {
            _internalConfiguration = internalConfiguration;
        }

        #endregion

        #region Methods

        #endregion
    }

    public static class SpellFilter
    {
        public static IEnumerable<Spell> Slot(this IEnumerable<Spell> spells, CharacterSpellSlot spellSlot)
        {
            return spells.Where<Spell>(spell => spell.SpellSlot == spellSlot);
        }

        public static IEnumerable<Spell> Category(this IEnumerable<Spell> spells, SpellCategory category)
        {
            return spells.Where<Spell>(spell => spell.Category == category);
        }

        public static IEnumerable<Spell> Target(this IEnumerable<Spell> spells, SpellTarget target)
        {
            return spells.Where<Spell>(spell => spell.Target == target);
        }

        public static IEnumerable<Spell> Ignore(this IEnumerable<Spell> spells, string name)
        {
            return spells.Where<Spell>(spell => !spell.Name.Contains(name));
        }

        public static IEnumerable<Spell> Ready(this IEnumerable<Spell> spells)
        {
            return spells.Where<Spell>(spell => spell.IsReady);
        }
    }
}