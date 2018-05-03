using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Controls.Keys
{
    public class KeyController : MonoBehaviour
    {
        public static KeyBinding CurrentBinding;

        public void Start()
        {
            CurrentBinding = new OverworldKeyBinding();    
        }

        public void Update()
        {
            if (Input.GetKeyDown("escape")) {
                CurrentBinding.FireAction("escape");
            }
        }
    }
}
