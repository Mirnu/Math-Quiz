using Assets.Scripts.Data;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.States.Impl
{
    public class LoadingState : State
    {
        [SerializeField] private Image _questionImage;
        [SerializeField] private TMP_Text _questionText;
        [SerializeField] private LevelContainer _levelContainer;

        public override void Enter()
        {
            LevelData data = _levelContainer.CurrentLevelData;
            if (data.Sprite != null)
            {
                _questionImage.sprite = data.Sprite;
                _questionText.gameObject.SetActive(false);
            }
            else
            {
                _questionText.text = data.Question;
                _questionImage.gameObject.SetActive(false);
            }
            stateMachine.LoadState(States.Game);
        }
    }
}