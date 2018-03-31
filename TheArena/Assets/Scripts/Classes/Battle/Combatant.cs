using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Assets.Scripts.Classes.Battle;

namespace Assets.Scripts.Classes.Battle
{


    public class Combatant : MonoBehaviour, IDisposable
    {

        public Combatant() : base()
        {
            CombatantBehaviors = new List<CombatantBehavior>();
        }

        public float speed;
        public int health;

        public enum CombatantRole
        {
            SENTINEL = 0,
            ARCHER = 1,
            HEALER = 1 >> 1
        }

        public CombatantStats Stats
        {
            get; set;
        }

        public List<CombatantBehavior> CombatantBehaviors
        {
            get; set;
        }

        public CombatantRole Role
        {
            get; set;
        }

        public bool IsPlayer
        {
            get; set;
        }

        public void AttachBehavior(CombatantBehavior behavior)
        {
            behavior.Combatant = this;
            CombatantBehaviors.Add(behavior);
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            foreach (CombatantBehavior behavior in CombatantBehaviors)
            {
                behavior.BehaviorUpdate();
            }
        }

        public bool IsDead
        {
            get; set;
        }

        public void Dispose()
        {
            IsDead = true;
        }
    }
}
