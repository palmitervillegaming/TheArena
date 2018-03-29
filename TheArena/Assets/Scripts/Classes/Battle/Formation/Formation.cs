using Assets.Scripts.Classes.Battle.Formation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Classes.Battle.Formation
{
    public class Formation<Combatant> : MonoBehaviour
    {
        public Combatant Leader
        {
            get; set;
        }

        public List<Combatant> Combatants
        {
            get; set;
        }

        public List<FormationNode> Nodes
        {
            get; set;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
