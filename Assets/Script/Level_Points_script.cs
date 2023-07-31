using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Points_script : MonoBehaviour
{
    public Player_Stats_script Player_Stats;
    
    public GameObject plus_health;
    public GameObject plus_attack;
    public GameObject plus_armor;
    public GameObject plus_speed;

    public int lvl_points;

    private void Update() {
        if(lvl_points > 0){
            plus_health.SetActive(true);
            plus_attack.SetActive(true);
            plus_armor.SetActive(true);
            plus_speed.SetActive(true);
        }
        else {
            plus_health.SetActive(false);
            plus_attack.SetActive(false);
            plus_armor.SetActive(false);
            plus_speed.SetActive(false);
        }
    }

    public void plus_health_button(){
        Player_Stats.health_max += 2;
        Player_Stats.health += 2;
        lvl_points -= 1;
    }
    public void plus_attack_button(){
        Player_Stats.attack += 1;
        lvl_points -= 1;
    }
    public void plus_armor_button(){
        Player_Stats.armor_items += 1;
        lvl_points -= 1;
    }
    public void plus_speed_button(){
        Player_Stats.speed += 1;
        lvl_points -= 1;
    }
}
