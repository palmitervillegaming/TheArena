using UnityEngine;
using System.Collections;
using Assets.Scripts.Classes.Battle;
using System.Collections.Generic;
using Controls;

public class Enemy : Combatant
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        BattleControl.Instance.EnterBattle(this);
    }
}
