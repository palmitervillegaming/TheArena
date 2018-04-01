using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;
using Controls;

namespace Controls {
    public class GameControl {

        static GameControl()
        {
            Instance = new GameControl();
        }

        public static GameControl Instance
        {
            get;set;
        }

        private String GameDataPath
        {
            get { return Application.persistentDataPath + "/userdata.dat"; }
        }

        public GameData data = new GameData();
        public Dictionary<int, Ally> currentAllies = new Dictionary<int, Ally>();
        public bool IsTesting = true;
        public bool isXml = true;
        private Player currentPlayer;
        public Player CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }
            set
            {
                currentPlayer = value;
                if (!currentAllies.ContainsKey(currentPlayer.GetInstanceID()))
                {
                    currentAllies.Add(currentPlayer.GetInstanceID(), value);
                }
            }
        }


        public void NewGame()
        {
            GameData data = new GameData();
            Character character = new Character();
            //TEMP
            SceneManager.LoadScene("BattleScene");
            SceneManager.sceneLoaded += NewGameLoaded;
        }

        private void NewGameLoaded(UnityEngine.SceneManagement.Scene scene, LoadSceneMode mode)
        {
            Player p = CharacterLoader.LoadMain(0, 0);
            CurrentPlayer = p;
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
        }

    }
}
