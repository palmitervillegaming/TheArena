using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    private String GameDataPath
    {
        get { return Application.persistentDataPath + "/userdata.dat"; }
    }
    public GameData data = new GameData();
    public bool IsTesting = true;

	// Use this for initialization
	void Awake () {
		if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
            Load();
        } else if(instance != this)
        {
            Destroy(gameObject);
        }
	}

    private void OnDestroy()
    {
        Save();
    }

    /// <summary>
    /// Save the user's game data
    /// </summary>
    public void Save()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = File.Open(GameDataPath, FileMode.OpenOrCreate);
        formatter.Serialize(stream, data);
        stream.Close();
        print("Saved!");
    }

    /// <summary>
    /// Load the user's game data.
    /// </summary>
    public void Load()
    {
        FileStream stream = File.Open(GameDataPath, FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();
        data = (GameData)formatter.Deserialize(stream);
        stream.Close();
        print("Loaded!");
    }

}
