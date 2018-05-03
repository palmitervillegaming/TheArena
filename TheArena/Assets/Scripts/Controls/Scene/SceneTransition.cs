using Loaders.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Controls.Scene
{
    class SceneTransition : MonoBehaviour
    {
        public int sceneX;
        public int sceneY;
        public string sceneName;
        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<Player>() != null)
            {
                StaticScene.SceneTransitionMade(sceneX, sceneY);
            }
        }
    }
}
