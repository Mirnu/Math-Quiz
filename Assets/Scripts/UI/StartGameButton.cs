using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class StartGameButton : MonoBehaviour
    {
        private Button _button;
        
        private void Awake()
        {
            _button = GetComponent<Button>();

            _button.onClick.AddListener(() =>
            {
                SceneManager.LoadScene("Game");
            });
        }
    }
}