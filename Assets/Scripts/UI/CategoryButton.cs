using Assets.Scripts.Data;
using System;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class CategoryButton : StateSwitcherButton
    {
        [SerializeField] private TMP_Text _textView;

        public event Action<CategoryData> Clicked;
        private CategoryData _data;

        public void Init(CategoryData data)
        {
            _data = data;
            _textView.text = data.Name;
        }

        protected override void OnClick()
        {
            Clicked?.Invoke(_data);
            base.OnClick();
        }
    }
}