using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public enum MenuStateType
    {
        MainMenu,
        Themes,
        Categories,
    }

    public class StateSwitcher : MonoBehaviour
    {
        [SerializeField] private List<MenuState> _states;
        [SerializeField] private MenuState _defaultState;

        public static StateSwitcher Instance { get; private set; }

        public MenuState CurrentState { get; private set; }

        private void Awake()
        {
            Instance = this;
            SwitchState(_defaultState.Type);
        }

        public void SwitchState(MenuStateType state)
        {
            CurrentState.View?.SetActive(false);
            CurrentState = _states.Find(x => x.Type == state);
            CurrentState.View.SetActive(true);
        }
    }

    [Serializable]
    public struct MenuState
    {
        public MenuStateType Type;
        public GameObject View;
    }
}