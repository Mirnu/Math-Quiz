using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.States
{
    public enum States
    { 
        Loading,
        Game,
        Win,
        Lose,
        Settings
    }

    public class StateMachine : MonoBehaviour
    {

        [SerializeField] private State LoadingState;
        [SerializeField] private State GameState;
        [SerializeField] private State WinState;
        [SerializeField] private State LoseState;
        [SerializeField] private State SettingsState;

        private Dictionary<States, State> _statesMap = new();

        public State CurrentState { private set; get; }

        private void Awake()
        {
            _statesMap[States.Loading] = LoadingState;
            _statesMap[States.Game] = GameState;
            _statesMap[States.Lose] = LoseState;
            _statesMap[States.Win] = WinState;
            _statesMap[States.Settings] = SettingsState;

            foreach (var state in _statesMap)
            {
                state.Value.Init(this);
            }

            LoadState(States.Loading);
        }

        public void LoadState(States state)
        {
            CurrentState?.Exit();
            CurrentState = _statesMap[state];
            CurrentState.Enter();
        }
    }
}