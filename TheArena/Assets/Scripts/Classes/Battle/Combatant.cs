using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Assets.Scripts.Classes.Battle;

namespace Assets.Scripts.Classes.Battle
{

    public class Combatant : MonoBehaviour
    {

        public Combatant() : base()
        {
            CombatantBehaviors = new List<CombatantBehavior>();
        }

        public string characterName;
        private int level;
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
                //TODO Scale stats based on level
            }
        }
        public int currentHealth;
        public int maxHealth;
        public int currentMana;
        public int maxMana;
        public int currentStamina;
        public int maxStamina;
        public int currentFocus;
        public int maxFocus;
        public int atk;
        public int spd;

        public float speed;
        public float startX;
        public float startY;

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
    }
}
