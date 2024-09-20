using Assets.Scripts.Data;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.States.Impl
{
    public class WinState : State
    {
        [SerializeField] private LevelContainer _levelContainer;

        public override void Enter()
        {
            if (_levelContainer.NextLevel() == null)
            {
                SceneManager.LoadScene("Menu");
                return;
            }
            stateMachine.LoadState(States.Loading);
        }
    }
}
