using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Stats_script : MonoBehaviour
{
    public Level_Points_script Level_Points;

    public GameObject GameOverMenu;

    public Text health_view;
    public Text attack_view;
    public Text armor_view;
    public Text speed_view;

    public int attack = 5;
    public int armor = 2;
    public int speed = 4;
    public int health = 10;
    public int health_max = 10;
    public float exp_modifier = 1f;
    public int armor_items = 0;
    public int level = 1;
    public int player_exp = 0;

    public void plus_exp(int exp){
        player_exp += (int)(exp * exp_modifier);
    }


    private void Update() {
        if(speed >= 0){
            armor = armor_items;
        }
        else {
            armor = armor_items + speed;
        }
        

        if(player_exp >= 10 & level == 1){
            Level_Points.lvl_points += 1;
            level = 2;
            player_exp -= 10;
        }
        else if(player_exp >= 20 & level == 2){
            Level_Points.lvl_points += 1;
            level = 3;
            player_exp -= 20;
        }
        else if(player_exp >= 30 & level == 3){
            Level_Points.lvl_points += 1;
            level = 4;
            player_exp -= 30;
        }
        else if(player_exp >= 40 & level == 4){
            Level_Points.lvl_points += 1;
            level = 5;
            player_exp -= 40;
        }
        else if(player_exp >= 50 & level == 5){
            Level_Points.lvl_points += 1;
            level = 6;
            player_exp -= 50;
        }
        else if(player_exp >= 60 & level == 6){
            Level_Points.lvl_points += 1;
            level = 7;
            player_exp -= 60;
        }
        else if(player_exp >= 70 & level == 7){
            Level_Points.lvl_points += 1;
            level = 8;
            player_exp -= 70;
        }
        else if(player_exp >= 80 & level == 8){
            Level_Points.lvl_points += 1;
            level = 9;
            player_exp -= 80;
        }
        else if(player_exp >= 90 & level == 9){
            Level_Points.lvl_points += 1;
            level = 10;
            player_exp -= 90;
        }


        if(health <= 0){
            GameOverMenu.SetActive(true);
        }
        if(health > health_max){
            health = health_max;
        }

        health_view.text = ":"+health.ToString()+"/"+health_max.ToString();
        attack_view.text = ":"+attack.ToString();
        armor_view.text = ":"+armor.ToString();
        speed_view.text = ":"+speed.ToString();

    }
}
