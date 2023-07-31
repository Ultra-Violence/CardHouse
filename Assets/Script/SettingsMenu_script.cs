using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu_script : MonoBehaviour
{
    public Slider music_slider;

    public AudioSource Music;

    void Awake()
    {
        music_slider.value = PlayerPrefs.GetFloat("music_slider_save");
    }

    private void Update() {
        PlayerPrefs.SetFloat("music_slider_save", music_slider.value);
        Music.volume = music_slider.value;
    }


}
