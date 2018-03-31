using Assets.Scripts.Classes.Battle.CombatantBehaviors.AllyBehaviors;
using Assets.Scripts.Classes.Battle.CombatantBehaviors.EnemyBehaviors;
using Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Classes.Battle
{
    class BattleControl
    {
        public static BattleControl instance;
        public static BattleControl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BattleControl();
                }
                return instance;
            }
        }

        public Battle Battle
        {
            get;set; 
        }

        public bool InProgress
        {
            get; set;
        }

        public void StartBattle()
        {
            Battle = Battle ?? new Battle();

            //TODO add entire part to battle
            Player p = GameControl.Instance.CurrentPlayer;
            Battle.allies.Add(p.GetInstanceID(), p);

            Battle.allies.Values.ToList().ForEach(ally =>
            {
                ally.AttachBehavior(new DefaultAllyAI(ally));
            });

            Battle.enemies.Values.ToList().ForEach(enemy =>
            {
                enemy.AttachBehavior(new DefaultEnemyAI(enemy));
            });

            InProgress = true; 
        }

        public void EnterBattle(Enemy enemy)
        {
            Battle = Battle ?? new Battle();

            Battle.enemies.Add(enemy.GetInstanceID(), enemy);

            if (InProgress)
            {
                enemy.AttachBehavior(new DefaultEnemyAI(enemy));
            } else
            {
                StartBattle();
            }
        }

        //TODO create formation methods (these were deleted)
    }
}
