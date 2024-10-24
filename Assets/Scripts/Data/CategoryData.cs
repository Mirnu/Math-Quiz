using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Data
{
    [CreateAssetMenu(fileName = "CategoryData", menuName = "Data/CategoryData")]
    public class CategoryData : ScriptableObject, IEnumerable<ThemeData>
    {
        [SerializeField] private ThemeData[] _themes;
        [SerializeField] private string _name;
        public string Name => _name;

        private ThemeEnumerator _enumerator;

        public IEnumerator<ThemeData> GetEnumerator()
        {
            if (_enumerator == null)
            {
                _enumerator = new ThemeEnumerator(_themes);
            }
            return _enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class ThemeEnumerator : IEnumerator<ThemeData>
        {
            private ThemeData[] _themes;
            private int _position = -1;

            public ThemeEnumerator(ThemeData[] themes)
            {
                _themes = themes;
            }

            public ThemeData Current => _themes[_position];

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public bool MoveNext()
            {
                return ++_position < _themes.Length;
            }

            public void Reset()
            {
                _position = -1;
            }
        }
    }
}