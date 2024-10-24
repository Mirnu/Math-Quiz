using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    [Serializable]
    public enum Scenes
    {
        Menu,
        Game
    }

    [RequireComponent(typeof(Button))]
    public class SceneSwitchableButton : MonoBehaviour
    {
        public Scenes Target;
        private Button _button;
        protected TMP_Text textView;

        private void Awake()
        {
            textView = GetComponentInChildren<TMP_Text>();
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnClick);
        }

        protected virtual void OnClick()
        {
            string name = Enum.GetName(typeof(Scenes), Target);
            SceneManager.LoadScene(name);
        }
    }
}