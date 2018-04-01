using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Controls.Scene
{
    public static class SceneMap
    {
        public const int sizeX = 100;
        public const int sizeY = 100;
        public const int loadFactor = 1;
        private static String[,] Map = new string[100, 100];

        static SceneMap() {
            Map[0, 0] = "Test_0_0";
            Map[1, 0] = "Test_0_1";
            Map[2, 0] = "Test_0_2";
            Map[3, 0] = "Test_0_3";
            Map[0, 1] = "Test_1_0";
            Map[1, 1] = "Test_1_1";
            Map[2, 1] = "Test_1_2";
            Map[3, 1] = "Test_1_3";
            //Map[2, 0] = "Test_2_0";
            //Map[2, 1] = "Test_2_1";
            //Map[2, 2] = "Test_2_2";
            //Map[2, 3] = "Test_2_3";
            //Map[3, 0] = "Test_3_0";
            //Map[3, 1] = "Test_3_1";
            //Map[3, 2] = "Test_3_2";
            //Map[3, 3] = "Test_3_3";
        }

        public static String GetPartition(int x, int y)
        {
            return Map[x, y];
        }

        public static void LoadMap(String json)
        {

        }
    }
}
