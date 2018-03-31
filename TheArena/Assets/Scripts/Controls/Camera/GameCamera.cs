using Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Controls.Camera
{
    public class GameCamera : MonoBehaviour
    {
        Vector3 offset;
        float z;
        // Use this for initialization
        void Start()
        {
            //Calculate and store the offset value by getting the distance between the player's position and camera's position.
            offset = GameControl.Instance.CurrentPlayer != null ? transform.position - GameControl.Instance.CurrentPlayer.transform.position : transform.position;
            z = transform.position.z;
        }

        public void Update()
        {
            transform.position = GameControl.Instance.CurrentPlayer != null ? GameControl.Instance.CurrentPlayer.transform.position : transform.position;
            transform.position = new Vector3(transform.position.x, transform.position.y, z);
        }
    }
}
