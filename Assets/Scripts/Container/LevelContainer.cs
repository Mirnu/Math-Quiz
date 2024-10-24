using Assets.Scripts.States.Impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Data
{
    public class LevelContainer : MonoBehaviour
    {
        [SerializeField] private int _currentLevel;

        public ThemeData Theme;

        public int CurrentLevel => _currentLevel;
        public List<LevelData> LevelDatas => Theme.Levels;
        public LevelData CurrentLevelData => LevelDatas[CurrentLevel];

        public LevelData NextLevel()
        {
            _currentLevel++;
            return LevelDatas.Count > _currentLevel ? LevelDatas[CurrentLevel] : null;
        }
    }
}