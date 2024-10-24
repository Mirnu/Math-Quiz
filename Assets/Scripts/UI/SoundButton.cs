using Assets.Scripts.Sound;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    [RequireComponent(typeof(Button))]
    [RequireComponent(typeof(AudioSource))]
    public class SoundButton : MonoBehaviour, IPointerEnterHandler
    {
        private AudioSource _audioSource;
        private Button _button;
        private SoundContainer _soundContainer => SoundContainer.Instance;

        public void OnPointerEnter(PointerEventData eventData)
        {
            Debug.Log(1);
            PlaySound(SoundType.HoverButton);
        }

        private void Awake()
        {
            _button = GetComponent<Button>();
            _audioSource = GetComponent<AudioSource>();

            _button.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            PlaySound(SoundType.ClickButton);
        }

        private void PlaySound(SoundType type)
        {
            AudioClip clip = _soundContainer.GetSound(type);
            _audioSource.Stop();
            _audioSource.PlayOneShot(clip);
        }
    }
}