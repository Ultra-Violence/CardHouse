using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest_script : MonoBehaviour
{   
    public Player_Stats_script Player_Stats;
    public Image slot1;
    public Image slot2;
    public Image slot3;
    public Image slot4;
    public Image slot5;
    public Image slot6;
    public Image slot7;
    public Image slot8;
    public Image slot9;
    public Image slot10;
    public Image slot11;
    public Image slot12;
    public Image slot13;
    public Image slot14;
    public Image slot15;
    public Image slot16;

    public List<string> player_items_list = new List<string>(){};

    public void take_item(string item_name){
        Sprite new_item = Resources.Load<Sprite>("items/"+item_name);
        if(slot1.enabled == false){
            slot1.sprite = new_item;
            slot1.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == false){
            slot2.sprite = new_item;
            slot2.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == false){
            slot3.sprite = new_item;
            slot3.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == false){
            slot4.sprite = new_item;
            slot4.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == false){
            slot5.sprite = new_item;
            slot5.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == false){
            slot6.sprite = new_item;
            slot6.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == true & slot7.enabled == false){
            slot7.sprite = new_item;
            slot7.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == true & slot7.enabled == true & slot8.enabled == false){
            slot8.sprite = new_item;
            slot8.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == true & slot7.enabled == true & slot8.enabled == true & slot9.enabled == false){
            slot9.sprite = new_item;
            slot9.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == true & slot7.enabled == true & slot8.enabled == true & slot9.enabled == true & slot10.enabled == false){
            slot10.sprite = new_item;
            slot10.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == true & slot7.enabled == true & slot8.enabled == true & slot9.enabled == true & slot10.enabled == true & slot11.enabled == false){
            slot11.sprite = new_item;
            slot11.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == true & slot7.enabled == true & slot8.enabled == true & slot9.enabled == true & slot10.enabled == true & slot11.enabled == true & slot12.enabled == false){
            slot12.sprite = new_item;
            slot12.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == true & slot7.enabled == true & slot8.enabled == true & slot9.enabled == true & slot10.enabled == true & slot11.enabled == true & slot12.enabled == true & slot13.enabled == false){
            slot13.sprite = new_item;
            slot13.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == true & slot7.enabled == true & slot8.enabled == true & slot9.enabled == true & slot10.enabled == true & slot11.enabled == true & slot12.enabled == true & slot13.enabled == true & slot14.enabled == false){
            slot14.sprite = new_item;
            slot14.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == true & slot7.enabled == true & slot8.enabled == true & slot9.enabled == true & slot10.enabled == true & slot11.enabled == true & slot12.enabled == true & slot13.enabled == true & slot14.enabled == true & slot15.enabled == false){
            slot15.sprite = new_item;
            slot15.enabled = true;
            eqp_item(item_name);
        }
        else if(slot1.enabled == true & slot2.enabled == true & slot3.enabled == true & slot4.enabled == true & slot5.enabled == true & slot6.enabled == true & slot7.enabled == true & slot8.enabled == true & slot9.enabled == true & slot10.enabled == true & slot11.enabled == true & slot12.enabled == true & slot13.enabled == true & slot14.enabled == true & slot15.enabled == true & slot16.enabled == false){
            slot16.sprite = new_item;
            slot16.enabled = true;
            eqp_item(item_name);
        }
    }

    public void eqp_item(string item_name){
        if(item_name == "Wizard Hat"){
            Player_Stats.exp_modifier += 0.25f;
            Player_Stats.health_max -= 1;
        }
        else if(item_name == "Sapphire Staff"){
            Player_Stats.attack += 1;
            Player_Stats.exp_modifier += 0.25f;
            Player_Stats.health_max -= 1;
        }
        else if(item_name == "Emerald Staff"){
            Player_Stats.attack += 1;
            Player_Stats.exp_modifier += 0.25f;
            Player_Stats.health_max -= 1;
        }
        else if(item_name == "Ruby Staff"){
            Player_Stats.attack += 1;
            Player_Stats.exp_modifier += 0.25f;
            Player_Stats.health_max -= 1;
        }
        else if(item_name == "Topaz Staff"){
            Player_Stats.attack += 1;
            Player_Stats.exp_modifier += 0.25f;
            Player_Stats.health_max -= 1;
        }
        else if(item_name == "Wooden Staff"){
            Player_Stats.exp_modifier += 0.25f;
        }
        else if(item_name == "Magic Wand"){
            Player_Stats.exp_modifier += 0.25f;
            Player_Stats.health_max -= 1;
        }
        else if(item_name == "Wooden Armor"){
            Player_Stats.armor_items += 1;
            Player_Stats.speed -= 2; 
        }
        else if(item_name == "Wooden Shield"){
            Player_Stats.armor_items += 1;
            Player_Stats.speed -= 2; 
        }
        else if(item_name == "Wooden Sword"){
            Player_Stats.attack += 1;
        }
        else if(item_name == "Silver Sword"){
            Player_Stats.attack += 2;
        }
        else if(item_name == "Monster Egg"){
            Player_Stats.attack -= 6;
            Player_Stats.armor_items += 3;
            Player_Stats.speed += 3;
        }
        else if(item_name == "Monster Eye"){
            Player_Stats.attack += 3;
            Player_Stats.armor_items -= 6;
            Player_Stats.speed += 3;
        }
        else if(item_name == "Rune Stone"){
            Player_Stats.attack += 3;
            Player_Stats.armor_items += 3;
            Player_Stats.speed -= 6;
        }
        else if(item_name == "Leather Helmet"){
            Player_Stats.armor_items += 1;
            Player_Stats.speed += 1;
        }
        else if(item_name == "Leather Boot"){
            Player_Stats.armor_items += 1;
            Player_Stats.speed += 1;
        }
        else if(item_name == "Leather Armor"){
            Player_Stats.armor_items += 1;
            Player_Stats.speed += 1;
        }
        else if(item_name == "Knife"){
            Player_Stats.attack += 1;
            Player_Stats.speed += 1;
        }
        else if(item_name == "Iron Sword"){
            Player_Stats.attack += 2;
            Player_Stats.speed -= 1;
        }
        else if(item_name == "Iron Shield"){
            Player_Stats.armor_items += 2;
            Player_Stats.speed -= 4;
            Player_Stats.health_max += 2;
        }
        else if(item_name == "Iron Helmet"){
            Player_Stats.armor_items += 2;
            Player_Stats.speed -= 4;
            Player_Stats.health_max += 2;
        }
        else if(item_name == "Iron Boot"){
            Player_Stats.armor_items += 2;
            Player_Stats.speed -= 4;
            Player_Stats.health_max += 2;
        }
        else if(item_name == "Iron Armor"){
            Player_Stats.armor_items += 2;
            Player_Stats.speed -= 4;
            Player_Stats.health_max += 2;
        }
        else if(item_name == "Helm"){
            Player_Stats.armor_items += 3;
            Player_Stats.speed -= 5;
            Player_Stats.health_max += 3;
        }
        else if(item_name == "Hammer"){
            Player_Stats.attack += 1;
            Player_Stats.speed -= 2;
            Player_Stats.health_max += 1;
        }
        else if(item_name == "Golden Sword"){
            Player_Stats.attack += 3;
            Player_Stats.armor_items -= 3;
        }
        else if(item_name == "Bow"){
            Player_Stats.attack += 1;
            Player_Stats.armor_items -= 1;
        }
        else if(item_name == "Axe"){
            Player_Stats.attack += 2;
            Player_Stats.armor_items -= 2;
        }
        else if(item_name == "Cut Emerald"){
            Player_Stats.health_max += 2;
            Player_Stats.health += 2;
        }
        else if(item_name == "Cut Ruby"){
            Player_Stats.attack += 1;
        }
        else if(item_name == "Cut Sapphire"){
            Player_Stats.armor_items += 1;
        }
        else if(item_name == "Cut Topaz"){
            Player_Stats.speed += 1;
        }
        else if(item_name == "Pearl"){
            Player_Stats.speed += 2;
            Player_Stats.armor_items -= 1;
        }
        else if(item_name == "Obsidian"){ 
            Player_Stats.armor_items += 2;
            Player_Stats.speed -= 1;
        }
        else if(item_name == "Diamond"){
            Player_Stats.health_max += 2;
            Player_Stats.health += 2;
            Player_Stats.attack += 1;
            Player_Stats.armor_items += 1;
            Player_Stats.speed += 1;
        }
    }


}
