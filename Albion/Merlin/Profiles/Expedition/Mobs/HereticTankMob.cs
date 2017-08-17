using Merlin.API.Direct;

namespace Merlin.Profiles.Expedition.Mobs {
	class HereticTankMob : Mob {
		public override string Name => "MOB_HERETIC_TANK_01";
		public override Spell[] Spells => new Spell[1] {
			new Spell(SpellCategory.CrowdControl, SpellTarget.Ground, Combat.Evade.Behind, "melee_shieldslam")
		};
	}
}
