using Assets.Scripts.Container;
using Assets.Scripts.Data;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class ThemeContainerUI : MonoBehaviour
    {
        [SerializeField] private CategoryContainer _categoryContainer;
        [SerializeField] private ThemeButton _prefab;
        [SerializeField] private GameObject _uiContainer;

        private void OnEnable()
        {
            Debug.Log("ВОТ СТОЛЬКО КАТЕГОРИЙ: " + _categoryContainer.CurrentCategory.Count);
            foreach (var theme in _categoryContainer.CurrentCategory)
            {
                ThemeButton button = Instantiate(_prefab, _uiContainer.transform);
                Debug.Log(nameof(theme));
                button.Init(theme);
            }
        }

        private void OnDisable()
        {
            foreach (Transform theme in _uiContainer.transform)
            {
                Destroy(theme.gameObject);
            }
        }
    }
}