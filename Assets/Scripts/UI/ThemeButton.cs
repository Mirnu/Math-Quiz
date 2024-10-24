using Assets.Scripts.Container;
using Assets.Scripts.Data;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class ThemeButton : SceneSwitchableButton
    {
        [SerializeField] private ThemeData _themeData;

        public void Init(ThemeData data)
        {
            _themeData = data;
            textView.text = data.Name;
        }

        protected override void OnClick()
        {
            ThemeContainer.Instance.Theme = _themeData;
            base.OnClick();
        }
    }
}