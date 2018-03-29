using Assets.Scripts.Classes.Battle.CombatantBehaviors.CommonBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Classes.Battle.CombatantBehaviors.AllyBehaviors
{
    public class DefaultAllyAI : DefaultBattleAI
    {
        public DefaultAllyAI(Combatant combatant) : base(combatant)
        {
        }

        public override void GetTarget()
        {
            if (!Combatant.IsPlayer)
            {
                Target = BattleControl.Instance.Battle.enemies.First().Value;
            }
        }

        public override void BehaviorUpdate()
        {
            if (!Combatant.IsPlayer)
            {
                base.BehaviorUpdate();
            }
        }
    }
}
