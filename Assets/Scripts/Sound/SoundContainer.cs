using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Sound
{
    public enum SoundType
    {
        HoverButton,
        ClickButton,
        Win,
        Lose
    }

    public class SoundContainer : MonoBehaviour
    {
        public List<SoundConf> _soundConfs;

        public static SoundContainer Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public AudioClip GetSound(SoundType type)
        {
            return _soundConfs.Find(x => x.Type == type).Clip;
        }
    }

    [Serializable]
    public struct SoundConf
    {
        public SoundType Type;
        public AudioClip Clip;
    }
}