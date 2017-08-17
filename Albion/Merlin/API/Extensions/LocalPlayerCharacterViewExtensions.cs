using Merlin.API.Direct;
using Merlin.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using UnityEngine;

using YinYang.CodeProject.Projects.SimplePathfinding.Helpers;
using YinYang.CodeProject.Projects.SimplePathfinding.PathFinders.AStar;

namespace Merlin
{
    public static class LocalPlayerCharacterViewExtensions
    {

		private static MethodInfo _startCastInternalTarget;
        private static MethodInfo _startCastInternalPosition;
        private static MethodInfo _doActionStaticObjectInteraction;

        static LocalPlayerCharacterViewExtensions()
        {
            var inputHandlerType = typeof(LocalInputHandler);

            _startCastInternalTarget = inputHandlerType.GetMethod("StartCastInternal", BindingFlags.NonPublic | BindingFlags.Instance,
                                            Type.DefaultBinder, new Type[] { typeof(byte), typeof(FightingObjectView) }, null);

            _startCastInternalPosition = inputHandlerType.GetMethod("StartCastInternal", BindingFlags.NonPublic | BindingFlags.Instance,
                                            Type.DefaultBinder, new Type[] { typeof(byte), typeof(ahl) }, null);

            _doActionStaticObjectInteraction = inputHandlerType.GetMethod("DoActionStaticObjectInteraction", BindingFlags.NonPublic | BindingFlags.Instance);
        }

        public static LocalPlayerCharacter GetCharacter(this LocalPlayerCharacterView view) => view.LocalPlayerCharacter;
        public static bool IsUnderAttack(this LocalPlayerCharacterView view, out FightingObjectView attacker)
        {
            var entities = GameManager.GetInstance().GetEntities<MobView>((entity) => {
                var target = ((FightingObjectView)entity).GetAttackTarget();

                if (target != null && target == view)
                    return true;

                return false;
            });

            attacker = entities.FirstOrDefault();

            return attacker != default(FightingObjectView);

        }
        public static Spell[] GetSpells(this LocalPlayerCharacterView instance)
        {
            var internalSpells = instance.LocalPlayerCharacter.tg();
            var spells = new Spell[internalSpells.Length];

            for (int i = 0; i < spells.Length; i++)
            {
                if (internalSpells[i] != null)
                    spells[i] = new Spell(instance, internalSpells[i], (CharacterSpellSlot)i);
            }

            return spells;
        }
        public static float GetWeightPercentage(this LocalPlayerCharacterView view)
        {
            return view.GetCharacter().GetLoad() / view.GetCharacter().GetMaxLoad() * 100.0f * 2f;
        }
        public static bool IsCastingSpell(this LocalPlayerCharacterView view)
        {
            if (view.GetCharacter().IsCastingSpell() != 4)
                return false;

            return true;
        }
        public static void SetSelectedObject(this LocalPlayerCharacterView view, SimulationObjectView simulation)
        {
            if (simulation == default(SimulationObjectView))
                view.InputHandler.SetSelectedObjectId(-1L);
            else
                view.InputHandler.SetSelectedObjectId(simulation.Id);
        }
        public static void AttackSelectedObject(this LocalPlayerCharacterView view)
        {
            view.InputHandler.AttackCurrentTarget();
        }
        public static void Interact(this LocalPlayerCharacterView view, WorldObjectView target)
        {
            _doActionStaticObjectInteraction.Invoke(view.InputHandler, new object[] { target, String.Empty });
        }

        public static void CastOn(this LocalPlayerCharacterView instance, CharacterSpellSlot slot, FightingObjectView target)
        {
            _startCastInternalTarget.Invoke(instance.InputHandler, new object[] { (byte)slot, target });
        }

        public static void CastAt(this LocalPlayerCharacterView instance, CharacterSpellSlot slot, Vector3 target)
        {
            _startCastInternalPosition.Invoke(instance.InputHandler, new object[] { (byte)slot, target.c() });
        }

        public static void CastOnSelf(this LocalPlayerCharacterView instance, CharacterSpellSlot slot)
        {
            instance.CastOn(slot, instance);
        }


        public static bool TryFindPath(this LocalPlayerCharacterView instance, AStarPathfinder pathfinder, Vector3 target,
                                    StopFunction<Vector2> stopFunction, out List<Vector3> results)
        {
            results = new List<Vector3>();

            var pivotPoints = new List<Vector2>();
            var path = new List<Vector2>();

            var startLocation = new Vector2((int)instance.transform.position.x, (int)instance.transform.position.z);
            var endLocation = new Vector2((int)target.x, (int)target.z);

            var landscape = instance;

            if (pathfinder.TryFindPath(startLocation, endLocation, stopFunction, out path, out pivotPoints, true))
            {
                foreach (var point in path)
                    results.Add(new Vector3(point.x, 0.5f, point.y));
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
