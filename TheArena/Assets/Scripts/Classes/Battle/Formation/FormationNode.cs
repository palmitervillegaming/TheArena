using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Classes.Battle.Formation
{
    public class FormationNode : MonoBehaviour
    {
        public bool Attached
        {
            get; set;
        }

        public Combatant.CombatantRole Role
        {
            get; set;
        }

        public Combatant Combatant
        {
            get; set;
        }
    }
}
