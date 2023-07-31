using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings_script : MonoBehaviour
{
    public GameObject Settings_HUD;

    public Slider music_slider;
    public Slider effect_sound_slider;

    public AudioSource left_audio;
    public AudioSource right_audio;
    public AudioSource player_audio;

    void Awake()
    {
        music_slider.value = PlayerPrefs.GetFloat("music_slider_save");
        effect_sound_slider.value = PlayerPrefs.GetFloat("effect_slider_save");
    }

    
    void Update()
    {
        PlayerPrefs.SetFloat("music_slider_save", music_slider.value);
        PlayerPrefs.SetFloat("effect_slider_save", effect_sound_slider.value);

        if(Input.GetKeyDown(KeyCode.Escape)){
            Settings_HUD.SetActive(!Settings_HUD.activeInHierarchy);
        }
        player_audio.volume = music_slider.value;
        right_audio.volume = effect_sound_slider.value;
        left_audio.volume = effect_sound_slider.value;
    }

    public void ReturnBtn(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitBtn(){
        Application.Quit();
    }
}
