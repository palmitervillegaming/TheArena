using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Loaders.Players
{
    class PlayerLoader : MonoBehaviour
    {
        public static Dictionary<string, Player> loadedChars = new Dictionary<string, Player>();
        
        /**
         * Load a player resource from path in the saved specified position
         */
        public static Player LoadPlayer(BaseCharacterRepository.CharacterCode code)
        {
            Player p;
            String resourcePath = PlayerResourceMap.GetResourcePath(code);
            try
            {
                if (loadedChars.ContainsKey(resourcePath))
                {
                    p = loadedChars[resourcePath];
                }
                else
                {
                    p = Instantiate(Resources.Load(resourcePath, typeof(Player))) as Player;
                    DontDestroyOnLoad(p);
                    p.Character = BaseCharacterRepository.GetBaseCharacter(code);
                    loadedChars.Add(resourcePath, p);
                }
            } catch (MissingReferenceException e)
            {
                loadedChars.Remove(resourcePath);
                p = LoadPlayer(code);
                //TEMP
                print(e.Message);
            }
            return p;
        }
        
        //TEMP METHOD
        public static Player LoadMain(float x, float y)
        {
            Player p =  LoadPlayer(BaseCharacterRepository.CharacterCode.MAIN);
            return p;
        }
    }
} 
