using Assets.Scripts.Classes.Battle.CombatantBehaviors.CommonBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Classes.Battle.CombatantBehaviors.EnemyBehaviors
{
    public class DefaultEnemyAI : DefaultBattleAI
    {
        public DefaultEnemyAI(Combatant combatant) : base(combatant)
        {
        }

        public override void GetTarget()
        {
            //TODO implement something smarter than this based on distance, priorities?
            Target = Target ?? BattleControl.Instance.Battle.allies.First().Value;
        }
    }
}
