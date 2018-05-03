using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;
using Loaders.Party;

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

        private Party party;
        public Party Party
        {
            get
            {
                if (party == null)
                {
                    LoadParty();
                }
                return party;
            }
            set
            {
                party = value;

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

        public void LoadParty()
        {
            Party = PartyLoader.LoadParty();
        }
    }
}
