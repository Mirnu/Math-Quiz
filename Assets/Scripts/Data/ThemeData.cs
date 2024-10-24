using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Data
{
    [CreateAssetMenu(fileName = "ThemeData", menuName = "ThemeData", order = 1)]
    public class ThemeData : ScriptableObject
    {
        public string Name;
        public List<LevelData> Levels;
    }
}