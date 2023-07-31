using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_script : MonoBehaviour
{
    public GameObject SettingsMenu;

    public void PlayBtn(){
        SceneManager.LoadScene("SampleScene");
    }

    public void SettingsBtn(){
        SettingsMenu.SetActive(!SettingsMenu.activeInHierarchy);
    }

    public void QuitBtn(){
        Application.Quit();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            SettingsMenu.SetActive(!SettingsMenu.activeInHierarchy);
        }
    }
}
