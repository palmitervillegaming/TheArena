using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Controls.Scene
{
    class SceneTransition : MonoBehaviour
    {
        public float x;
        public float y;
        public string sceneName;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            SceneController.MakeTransition(this);
        }
    }
}
