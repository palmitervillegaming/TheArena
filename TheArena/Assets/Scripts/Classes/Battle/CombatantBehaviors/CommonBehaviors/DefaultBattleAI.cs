using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Classes.Battle.CombatantBehaviors.CommonBehaviors
{
    public abstract class DefaultBattleAI : CombatantBehavior
    {

        public DefaultBattleAI(Combatant combatant)
        {
            Combatant = combatant;
        }

        public DefaultBattleAI(Combatant combatant, Combatant initialTarget)
        {

            Combatant = combatant;
            RB = combatant.GetComponent<Rigidbody2D>();
            Target = initialTarget;
        }

        public Rigidbody2D RB
        {
            get; set;
        }

        public Combatant Combatant
        {
            get; set;
        }
        
        public Combatant Target
        {
            get; set;
        }

        public abstract void GetTarget();

        public virtual void BehaviorUpdate()
        {
            Vector2 next = LocationUtilities.NextLocation(Combatant.transform.position, Target.transform.position, Combatant.speed);
            RB.MovePosition(next);
        }

        
    }
}
