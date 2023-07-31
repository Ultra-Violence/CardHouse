using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    public Player_Move_script Player_Move_script;

    public int player_damage;
    public int enemy_damage;

    public void fight_left(int enemy_attack, int enemy_armor, int enemy_speed, int enemy_health, int player_attack, int player_armor, int player_speed, int player_health){
        if(enemy_speed < player_speed){
            enemy_damage = enemy_armor - player_attack;
            if(enemy_health >= enemy_damage){
                player_damage = player_armor - enemy_attack;
            }
        }
        else if(enemy_speed >= player_speed){
            player_damage = player_armor - enemy_attack;
            if(player_health >= player_damage){
                enemy_damage = enemy_armor - player_attack;
            }
        }
        
       Player_Move_script.resolt_left(enemy_damage, player_damage);
    }

    public void fight_right(int enemy_attack, int enemy_armor, int enemy_speed, int enemy_health, int player_attack, int player_armor, int player_speed, int player_health){
        if(enemy_speed < player_speed){
            enemy_damage = enemy_armor - player_attack;
            if(enemy_health >= enemy_damage){
                player_damage = player_armor - enemy_attack;
            }
        }
        else if(enemy_speed >= player_speed){
            player_damage = player_armor - enemy_attack;
            if(player_health >= player_damage){
                enemy_damage = enemy_armor - player_attack;
            }
        }

        if(enemy_damage > 0){
            enemy_damage = 0;
        }
        
       Player_Move_script.resolt_right(enemy_damage, player_damage);
    }
}
