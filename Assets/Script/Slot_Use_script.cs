using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Use_script : MonoBehaviour
{
    public Player_Stats_script Player_Stats;
    public Player_Move_script Player_Move_script;
    public Image slot;
    public Tutorial_Panel_script tutorial_panel;

    public Enemy_Stats_Left_script Enemy_Stats_Left;
    public Enemy_Stats_Right_script Enemy_Stats_Right;

    public GameObject GameOverMenu;

    public void slot_button(){
        if(GameOverMenu.activeInHierarchy == false){
        if(slot.sprite.name =="Book"){
            Player_Stats.plus_exp(10);
            slot.enabled = false;
        }
        else if(slot.sprite.name =="Book 2"){
            Player_Stats.plus_exp(20);
            slot.enabled = false;
        }
        else if(slot.sprite.name =="Book 3"){
            Player_Stats.plus_exp(30);
            slot.enabled = false;
        }
        else if(slot.sprite.name =="Red Potion"){
            Player_Stats.health += 10;
            slot.enabled = false;
        }
        else if(slot.sprite.name =="Red Potion 2"){
            Player_Stats.health += 20;
            slot.enabled = false;
        }
        else if(slot.sprite.name =="Red Potion 3"){
            Player_Stats.health += 30;
            slot.enabled = false;
        }
        else if(slot.sprite.name =="Crystal"){
            Player_Move_script.resolt_left(5, 0);
            Player_Move_script.resolt_right(5, 0);
            slot.enabled = false;
        }
        }
    }

    public void tutorial_panel_info(){
        tutorial_panel.view(slot.sprite.name);
    }
}
