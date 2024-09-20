using UnityEngine;

namespace Assets.Scripts.States
{
    public abstract class State : MonoBehaviour
    {
        protected StateMachine stateMachine;

        public void Init(StateMachine stateMachine)
        {
            this.stateMachine = stateMachine;
        }

        public virtual void Enter() { }
        public virtual void Exit() { }
    }
}