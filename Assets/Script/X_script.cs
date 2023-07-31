using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class X_script : MonoBehaviour
{
    public Image slot;
    public Player_Stats_script Player_Stats;

    public GameObject GameOverMenu;

    private void Update() {
        if(slot.enabled == true){
            gameObject.GetComponent<Image>().enabled = true;
        }
        else{
            gameObject.GetComponent<Image>().enabled = false;
        }
    }

    public void delete_slot(){
        if(GameOverMenu.activeInHierarchy == false){
        slot.enabled = false;
        if(slot.sprite.name == "Wizard Hat"){
            Player_Stats.exp_modifier -= 0.25f;
            Player_Stats.health_max += 1;
        }
        else if(slot.sprite.name == "Sapphire Staff"){
            Player_Stats.attack -= 1;
            Player_Stats.exp_modifier -= 0.25f;
            Player_Stats.health_max += 1;
        }
        else if(slot.sprite.name == "Emerald Staff"){
            Player_Stats.attack -= 1;
            Player_Stats.exp_modifier -= 0.25f;
            Player_Stats.health_max += 1;
        }
        else if(slot.sprite.name == "Ruby Staff"){
            Player_Stats.attack -= 1;
            Player_Stats.exp_modifier -= 0.25f;
            Player_Stats.health_max += 1;
        }
        else if(slot.sprite.name == "Topaz Staff"){
            Player_Stats.attack -= 1;
            Player_Stats.exp_modifier -= 0.25f;
            Player_Stats.health_max += 1;
        }
        else if(slot.sprite.name == "Wooden Staff"){
            Player_Stats.exp_modifier -= 0.25f;
        }
        else if(slot.sprite.name == "Magic Wand"){
            Player_Stats.exp_modifier -= 0.25f;
            Player_Stats.health_max += 1;
        }
        else if(slot.sprite.name == "Wooden Armor"){
            Player_Stats.armor_items -= 1;
            Player_Stats.speed += 2; 
        }
        else if(slot.sprite.name == "Wooden Shield"){
            Player_Stats.armor_items -= 1;
            Player_Stats.speed += 2; 
        }
        else if(slot.sprite.name == "Wooden Sword"){
            Player_Stats.attack -= 1;
        }
        else if(slot.sprite.name == "Silver Sword"){
            Player_Stats.attack -= 2;
        }
        else if(slot.sprite.name == "Monster Egg"){
            Player_Stats.attack += 6;
            Player_Stats.armor_items -= 3;
            Player_Stats.speed -= 3;
        }
        else if(slot.sprite.name == "Monster Eye"){
            Player_Stats.attack -= 3;
            Player_Stats.armor_items += 6;
            Player_Stats.speed -= 3;
        }
        else if(slot.sprite.name == "Rune Stone"){
            Player_Stats.attack -= 3;
            Player_Stats.armor_items -= 3;
            Player_Stats.speed += 6;
        }
        else if(slot.sprite.name == "Leather Helmet"){
            Player_Stats.armor_items -= 1;
            Player_Stats.speed -= 1;
        }
        else if(slot.sprite.name == "Leather Boot"){
            Player_Stats.armor_items -= 1;
            Player_Stats.speed -= 1;
        }
        else if(slot.sprite.name == "Leather Armor"){
            Player_Stats.armor_items -= 1;
            Player_Stats.speed -= 1;
        }
        else if(slot.sprite.name == "Knife"){
            Player_Stats.attack -= 1;
            Player_Stats.speed -= 1;
        }
        else if(slot.sprite.name == "Iron Sword"){
            Player_Stats.attack -= 2;
            Player_Stats.speed += 1;
        }
        else if(slot.sprite.name == "Iron Shield"){
            Player_Stats.armor_items -= 2;
            Player_Stats.speed += 4;
            Player_Stats.health_max -= 2;
        }
        else if(slot.sprite.name == "Iron Helmet"){
            Player_Stats.armor_items -= 2;
            Player_Stats.speed += 4;
            Player_Stats.health_max -= 2;
        }
        else if(slot.sprite.name == "Iron Boot"){
            Player_Stats.armor_items -= 2;
            Player_Stats.speed += 4;
            Player_Stats.health_max -= 2;
        }
        else if(slot.sprite.name == "Iron Armor"){
            Player_Stats.armor_items -= 2;
            Player_Stats.speed += 4;
            Player_Stats.health_max -= 2;
        }
        else if(slot.sprite.name == "Helm"){
            Player_Stats.armor_items -= 3;
            Player_Stats.speed += 5;
            Player_Stats.health_max -= 3;
        }
        else if(slot.sprite.name == "Hammer"){
            Player_Stats.attack -= 1;
            Player_Stats.speed += 2;
            Player_Stats.health_max -= 1;
        }
        else if(slot.sprite.name == "Golden Sword"){
            Player_Stats.attack -= 3;
            Player_Stats.armor_items += 3;
        }
        else if(slot.sprite.name == "Bow"){
            Player_Stats.attack -= 1;
            Player_Stats.armor_items += 1;
        }
        else if(slot.sprite.name == "Axe"){
            Player_Stats.attack -= 2;
            Player_Stats.armor_items += 2;
        }
        else if(slot.sprite.name == "Cut Emerald"){
            Player_Stats.health_max -= 2;
            Player_Stats.health -= 2;
        }
        else if(slot.sprite.name == "Cut Ruby"){
            Player_Stats.attack -= 1;
        }
        else if(slot.sprite.name == "Cut Sapphire"){
            Player_Stats.armor_items -= 1;
        }
        else if(slot.sprite.name == "Cut Topaz"){
            Player_Stats.speed -= 1;
        }
        else if(slot.sprite.name == "Pearl"){
            Player_Stats.speed -= 2;
            Player_Stats.armor_items -= 1;
        }
        else if(slot.sprite.name == "Obsidian"){ 
            Player_Stats.armor_items -= 2;
            Player_Stats.speed += 1;
        }
        else if(slot.sprite.name == "Diamond"){
            Player_Stats.health_max -= 2;
            Player_Stats.health -= 2;
            Player_Stats.attack -= 1;
            Player_Stats.armor_items -= 1;
            Player_Stats.speed -= 1;
        }
    }
    }

}
