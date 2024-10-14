using Assets.Scripts.Data;
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
            }
            else
            {
                _questionText.text = data.Question;
            }
            _questionText.gameObject.SetActive(data.Sprite == null);
            _questionImage.gameObject.SetActive(data.Sprite != null);
            stateMachine.LoadState(States.Game);
        }
    }
}