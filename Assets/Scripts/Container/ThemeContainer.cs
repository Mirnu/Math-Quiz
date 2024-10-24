using Assets.Scripts.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Container
{
    public class ThemeContainer : MonoBehaviour
    {
        public List<ThemeData> Themes;

        public static ThemeContainer Instance { get; private set; }
        public ThemeData Theme { get; set; }

        private void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}