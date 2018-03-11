using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Controls
{
    class CharacterLoader : MonoBehaviour
    {
        public static Dictionary<string, Player> loadedChars = new Dictionary<string, Player>();

        public static void LoadPlayer(string resourcePath, float x, float y)
        {
            try
            {
                Player p;
                if (loadedChars.ContainsKey(resourcePath) && !loadedChars[resourcePath].isDead)
                {
                    p = loadedChars[resourcePath];
                }
                else
                {
                    p = Instantiate(Resources.Load(resourcePath, typeof(Player))) as Player;
                    p.character = BaseCharacterRepository.GetBaseCharacter(BaseCharacterRepository.CharacterCode.MAIN);
                    loadedChars.Add(resourcePath, p);
                }
                p.transform.position = new Vector3(x, y);
            } catch (MissingReferenceException e)
            {
                loadedChars.Remove(resourcePath);
                LoadPlayer(resourcePath, x, y);
            }
        }
        
        public static void LoadMain(float x, float y)
        {
            LoadPlayer("Prefab/Characters/Poo", x, y);
        }
    }
} 
