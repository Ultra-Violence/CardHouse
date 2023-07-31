using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Stats_Left_script : MonoBehaviour
{
    public GameObject health_icon;
    public GameObject attack_icon;
    public GameObject armor_icon;
    public GameObject speed_icon;

    public Text health_view;
    public Text attack_view;
    public Text armor_view;
    public Text speed_view;

    public int attack = 0;
    public int armor = 0;
    public int speed = 0;
    public int health = 0;

    private void Update() {

        if(gameObject.tag == "enemy_cloud" | gameObject.tag == "enemy_skeleton" | gameObject.tag == "enemy_zombie" | gameObject.tag == "enemy_necromancer" | gameObject.tag == "enemy_boss1"){
            health_icon.SetActive(true);
            attack_icon.SetActive(true);
            armor_icon.SetActive(true);
            speed_icon.SetActive(true);
        }
        else {
            health_icon.SetActive(false);
            attack_icon.SetActive(false);
            armor_icon.SetActive(false);
            speed_icon.SetActive(false);
        }
        
        health_view.text = ":"+health.ToString();
        attack_view.text = ":"+attack.ToString();
        armor_view.text = ":"+armor.ToString();
        speed_view.text = ":"+speed.ToString();
    }

}
