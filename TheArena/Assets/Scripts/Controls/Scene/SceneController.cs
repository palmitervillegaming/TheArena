using Controls;
using Loaders.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Controls.Scene
{
    class SceneController : MonoBehaviour
    {
        public static SceneTransition currentTransition
        {
            get;set;
        }

        public static void MakeTransition(SceneTransition st)
        {
            currentTransition = st;
            SceneManager.LoadScene(st.sceneName);
            SceneManager.sceneLoaded += LoadCharacter;
        }

        public static void LoadCharacter(UnityEngine.SceneManagement.Scene scene, LoadSceneMode mode)
        {
            GameControl.Instance.Party.CurrentPlayer = PlayerLoader.LoadMain(currentTransition.sceneX, currentTransition.sceneY);
        }
    }
}
