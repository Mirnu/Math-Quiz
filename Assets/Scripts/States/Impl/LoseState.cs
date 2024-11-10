using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.States.Impl
{
    public class LoseState : State
    {
        [SerializeField] private GameObject _losePanel;
        [SerializeField] private Button _restartButton;
        [SerializeField] private TMP_Text _loseText;

        private List<string> _words = new List<string>() 
        {
            "Переиграй, у тебя все получится!",
            "Давай еще попытку", 
            "У всех бывает",
            "Опыт - это наши ошибки"
        };

        public override void Enter()
        {
            _loseText.text = _words[Random.Range(0, _words.Count)];
            _losePanel.SetActive(true);
            _restartButton.onClick.AddListener(OnRestartButtonClick);
        }

        private void OnRestartButtonClick()
        {
            _losePanel.SetActive(false);
            _restartButton.onClick.RemoveListener(OnRestartButtonClick);
            stateMachine.LoadState(States.Loading);
        }
    }
}
