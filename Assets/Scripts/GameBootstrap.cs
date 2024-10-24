using Assets.Scripts.Container;
using Assets.Scripts.Data;
using Assets.Scripts.States;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameBootstrap : MonoBehaviour
    {
        [SerializeField] private LevelContainer _levelContainer;
        [SerializeField] private StateMachine _stateMachine;
        private ThemeContainer _themeContainer => ThemeContainer.Instance;
        

        private void Awake()
        {
            _levelContainer.Theme = _themeContainer.Theme;

            _stateMachine.LoadState(States.States.Loading);
        }
    }
}