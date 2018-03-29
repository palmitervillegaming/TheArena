using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Classes.Battle.Formation
{
    public class FormationTrigger : CombatantBehavior
    {   
        public FormationTrigger(Combatant combatant, FormationNode node)
        {
            Node = node;
            Combatant = combatant;
            rb = Combatant.GetComponent<Rigidbody2D>();
        }

        public Rigidbody2D rb
        {
            get;set;
        }

        public FormationNode Node
        {
            get; set;
        }

        public Combatant Combatant
        {
            get;  set;
        }

        public void BehaviorUpdate()
        {
            Vector2 v = LocationUtilities.NextLocation(Combatant.transform.position, Node.transform.position, Combatant.speed);
            rb.MovePosition(v);
        }
    }
}
