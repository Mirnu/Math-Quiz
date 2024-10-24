using Assets.Scripts.Data;
using Assets.Scripts.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Container
{
    public class CategoryContainerUI : MonoBehaviour
    {
        [SerializeField] private List<CategoryData> _categories;
        [SerializeField] private CategoryButton _categoryPrefab;
        [SerializeField] private CategoryContainer _container;

        private void Awake()
        {
            foreach (var category in _categories)
            {
                CategoryButton button = Instantiate(_categoryPrefab, transform);
                button.Init(category);
                button.Clicked += OnClicked;
            }
        }

        private void OnClicked(CategoryData data)
        {
            _container.CurrentCategory = data;
        }
    }
}