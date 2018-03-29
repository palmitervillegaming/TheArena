using Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Controls.Test.Tests
{
    public class BattleTest : MonoBehaviour, ITest
    {
        public string SceneName
        {
            get
            {
                return "BattleTestScene";
            }

            set
            {
            }
        }

        public void Run()
        {
            //Load Scene
            //Put character in it
            CharacterLoader.LoadMain(0, 0);
            SceneManager.LoadScene(SceneName);
            SceneManager.sceneLoaded += SceneLoaded;
        }

        private void SceneLoaded(UnityEngine.SceneManagement.Scene scene, LoadSceneMode mode)
        {
            CharacterLoader.LoadMain(4, 0);
        }
    }
}
