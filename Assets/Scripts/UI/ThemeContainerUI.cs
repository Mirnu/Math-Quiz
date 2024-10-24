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

        private void OnEnable()
        {
            foreach (Transform theme in transform)
            {
                Destroy(theme.gameObject);
            }

            foreach (var theme in _categoryContainer.CurrentCategory)
            {
                ThemeButton button = Instantiate(_prefab, transform);
                button.Init(theme);
            }
        }
    }
}