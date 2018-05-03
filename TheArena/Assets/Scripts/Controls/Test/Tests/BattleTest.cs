using Controls;
using Loaders.Players;
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
                return "StaticScene";
            }

            set
            {
            }
        }

        public void Run()
        {
            //Load Scene
            //Put character in it
            SceneManager.LoadScene(SceneName);
        }


    }
}
