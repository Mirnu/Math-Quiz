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
        [SerializeField] private Button _nextButton;

        public override void Enter()
        {
            LevelData data = _levelContainer.CurrentLevelData;
            _nextButton.onClick.AddListener(() => OnRightAnswerClick());
            _nextButton.gameObject.SetActive(!data.IsQuestion);

            for (int i = 0; i < _answers.Count; i++)
            {
                AnswerView answerView = _answers[i];
                string answer = data.Answers.Count > i ? data.Answers[i] : "";

                answerView.Panel.SetActive(data.IsQuestion);
                answerView.TextView.text = answer;
                answerView.Button.onClick.AddListener(
                    i == data.RightAnswerIndex ? OnRightAnswerClick : OnFalseAnswerClick);
            }
        }

        public override void Exit()
        {
            _nextButton.onClick.RemoveAllListeners();

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
        public GameObject Panel;
    }
}
