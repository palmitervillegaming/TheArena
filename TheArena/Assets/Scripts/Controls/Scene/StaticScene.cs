using Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Controls.Scene
{
    public class StaticScene : MonoBehaviour
    {
        public static int activeSceneX = 0;
        public static int activeSceneY = 0;
        public static int playerStartX = 0;
        public static int playerStartY = 0;
        public static string activeScene;
        public static Dictionary<String, Vector2> loadedScenes = new Dictionary<String, Vector2>();

        /**
         * Load the starting scene.
         */
        public void Start()
        {
            string activeScene = SceneMap.GetPartition(activeSceneX, activeSceneY);
            loadedScenes.Add(activeScene, new Vector2(activeSceneX, activeSceneY));
            SceneManager.LoadScene(activeScene, LoadSceneMode.Additive);
            SceneManager.sceneLoaded += SceneLoaded;
        }

        public void Update()
        {
        }

        /**
         * When the initial scene is loaded
         */
        private static void SceneLoaded(UnityEngine.SceneManagement.Scene scene, LoadSceneMode mode)
        {
            activeScene = scene.name;
            SceneManager.sceneLoaded -= SceneLoaded;
            StaticScene.LoadAdjacentScenes();
            CharacterLoader.LoadMain(playerStartX, playerStartY);
            SceneManager.SetActiveScene(scene);
        }

        /**
         * Unloads all uneeded scenes 
         */
        private static void UnloadScenes()
        {
            loadedScenes.Keys.ToList().ForEach(loadedScene =>
            {
                Vector2 loc = loadedScenes[loadedScene];
                if (Math.Abs(loc.x - activeSceneX) > 1 || Math.Abs(loc.y - activeSceneY) > 1)
                {
                    SceneManager.UnloadSceneAsync(loadedScene);
                    loadedScenes.Remove(loadedScene);
                    print("Removed Scene: " + loadedScene);
                }
            });
        }

        /**
         * Loads any scenes adjacent to the active scene.
         */
        private static void LoadAdjacentScenes()
        {
            for (int i = activeSceneX - 1; i <= activeSceneX + 1; i++)
            {
                if (i < 0)
                {
                    continue;
                }

                for (int j = activeSceneY - 1; j <= activeSceneY + 1; j++)
                {
                    if (j < 0)
                    {
                        continue;
                    }

                    String sceneName = SceneMap.GetPartition(i, j);
                    
                    if (sceneName == null || loadedScenes.ContainsKey(sceneName))
                    {
                        continue;
                    } else
                    {
                        loadedScenes.Add(sceneName, new Vector2(i, j));
                        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
                        print("Loaded Scene: " + sceneName);
                    }
                }
            }
        }

        /**
         * Call this when the player crosses the bounds into another scene so adjacent scenes are loaded.
         */
        public static void SceneTransitionMade(int x, int y)
        {

            string name = SceneMap.GetPartition(x, y);
            if (activeScene.Equals(name) || name == null)
            {
                return;
            }
            activeSceneX = x;
            activeSceneY = y;
            activeScene = name;
            UnityEngine.SceneManagement.Scene scene = SceneManager.GetSceneByName(name);
            UnloadScenes();
            LoadAdjacentScenes();
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(name));
            //printSceneInfo();
        }

        //public static void printSceneInfo()
        //{
        //    print("Active: " + activeScene);
        //    int sceneCount = SceneManager.sceneCount;
        //    for (int i = 0; i < sceneCount; i++)
        //    {
        //        print("Loaded Scene: " + SceneManager.GetSceneAt(i).name);
        //    }
        //}
    }


}
