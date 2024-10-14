using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    [RequireComponent(typeof(Button))]
    public class ExitButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();

            _button.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            Application.Quit();
        }
    }
}