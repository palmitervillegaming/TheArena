using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public static GameControl instance;
    private String GameDataPath
    {
        get { return Application.persistentDataPath + "/userdata.dat"; }
    }

    public GameData data = new GameData();

    public bool IsTesting = true;
    public bool isXml = true;


    public void NewGame()
    {
        GameData data = new GameData();
        Character character = new Character();
        //TEMP
        SceneManager.LoadScene("BattleScene");
        SceneManager.sceneLoaded += NewGameLoaded;
    }

    private void NewGameLoaded(Scene scene, LoadSceneMode mode)
    {
        Player poo = Instantiate(Resources.Load("Prefab/Characters/Poo", typeof(Player))) as Player;
        poo.character = BaseCharacterRepository.GetBaseCharacter(BaseCharacterRepository.CharacterCode.MAIN);
        poo.transform.TransformVector(new Vector3(0, 0));
    }

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
