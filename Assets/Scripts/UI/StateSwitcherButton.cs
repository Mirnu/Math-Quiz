using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    [RequireComponent(typeof(Button))]
    public class StateSwitcherButton : MonoBehaviour
    {
        [SerializeField] private MenuStateType _type;
        private Button _button;
        private StateSwitcher _stateSwitcher => StateSwitcher.Instance;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnClick);
        }

        protected virtual void OnClick()
        {
            _stateSwitcher.SwitchState(_type); 
        }
    }
}