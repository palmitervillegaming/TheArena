using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleControl : MonoBehaviour
{
    public static BattleControl instance;
    public BattleData data;
    public Ally currentPlayer;
    public Enemy target;
    public HashSet<Enemy> enemies;
    public HashSet<Ally> allies;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
            data = new BattleData();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    
}
