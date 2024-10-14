using System;
using System.Collections;
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
        [SerializeField] private Scenes _target;
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            string name = Enum.GetName(typeof(Scenes), _target);
            SceneManager.LoadScene(name);
        }
    }
}