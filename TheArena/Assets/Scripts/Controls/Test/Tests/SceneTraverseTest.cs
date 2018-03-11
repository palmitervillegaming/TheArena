using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controls.Test.Tests
{
    public class SceneTraverseTest : MonoBehaviour, ITest
    {
        public string SceneName
        {
            get {
                return "TestC";
            }
            set { }
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
            CharacterLoader.LoadMain(0, 0);
        }
    }
}
