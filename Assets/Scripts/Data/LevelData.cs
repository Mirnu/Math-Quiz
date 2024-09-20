using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Data
{
    [CreateAssetMenu(menuName = "Data/LevelData")]
    public class LevelData : ScriptableObject
    {
        public string Question;
        public List<string> Answers;
        public int RightAnswerIndex;
        public Sprite Sprite;
    }
}