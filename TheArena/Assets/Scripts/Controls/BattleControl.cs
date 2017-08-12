using UnityEngine;
using System.Collections;

public class BattleControl : MonoBehaviour
{

    public static BattleControl instance;
    public BattleData data;

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
