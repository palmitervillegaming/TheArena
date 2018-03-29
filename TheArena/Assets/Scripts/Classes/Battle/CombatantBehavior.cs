using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Classes.Battle
{
    public interface CombatantBehavior
    {
        Combatant Combatant
        {
            get; set;
        }

        void BehaviorUpdate();
    }
}
