using Merlin.API.Direct;

namespace Merlin.Profiles.Expedition.Mobs {
	class HereticMageMob : Mob {
		public override string Name => "MOB_HERETIC_MAGE_01";

		public override Spell[] Spells => new Spell[1] {
			new Spell(SpellCategory.Damage, SpellTarget.Ground, Combat.Evade.Left, "melee_areadamage")
		};
	}
}
