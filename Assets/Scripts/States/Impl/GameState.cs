using Assets.Scripts.Data;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.States.Impl
{
    public class GameState : State
    {
        [SerializeField] private List<AnswerView> _answers;
        [SerializeField] private LevelContainer _levelContainer;

        public override void Enter()
        {
            LevelData data = _levelContainer.CurrentLevelData;

            for (int i = 0; i < _answers.Count; i++)
            {
                AnswerView answerView = _answers[i];
                string answer = data.Answers[i];

                answerView.TextView.text = answer;
                answerView.Button.onClick.AddListener(
                    i == data.RightAnswerIndex ? OnRightAnswerClick : OnFalseAnswerClick);
            }
        }

        public override void Exit()
        {
            for (int i = 0; i < _answers.Count; i++)
            {
                AnswerView answerView = _answers[i];
                answerView.Button.onClick.RemoveAllListeners();
            }
        }

        private void OnRightAnswerClick()
        {
            stateMachine.LoadState(States.Win);
        }

        private void OnFalseAnswerClick()
        {
            stateMachine.LoadState(States.Lose);
        }
    }
    

    [Serializable]
    public struct AnswerView
    {
        public Button Button;
        public TMP_Text TextView;
    }
}
