using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loaders.Players
{
    public class PlayerResourceMap
    {
        private static Dictionary<BaseCharacterRepository.CharacterCode, String> CodeResourceMap = new Dictionary<BaseCharacterRepository.CharacterCode, String>();
        private const String CHARACTER_RESOURCE_PATH = "Prefab/Characters/";
        
        static PlayerResourceMap() {
            CodeResourceMap.Add(BaseCharacterRepository.CharacterCode.MAIN, CHARACTER_RESOURCE_PATH + "Main");
            CodeResourceMap.Add(BaseCharacterRepository.CharacterCode.TEST_MAIN_1, CHARACTER_RESOURCE_PATH + "TestMain1");
        }

        public static String GetResourcePath(BaseCharacterRepository.CharacterCode code)
        {
            return CodeResourceMap[code];
        }
    }
}
