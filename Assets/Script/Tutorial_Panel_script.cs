using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_Panel_script : MonoBehaviour
{   
    public Text item_name_view;
    public Text item_info_view;
    
    void Update()
    {
        gameObject.GetComponent<Transform>().position = new Vector3(Input.mousePosition.x, Input.mousePosition.y +180, 0);
    }

    public void view(string item_name){
        item_name_view.text = item_name;

        if(item_name == "Wizard Hat"){
            item_info_view.text = "experience modifier: +25%\nMax Health: -1";
        }
        else if(item_name == "Sapphire Staff"){
            item_info_view.text = "experience modifier: +25%\nMax Health: -1\nAttack: +1";
        }
        else if(item_name == "Emerald Staff"){
            item_info_view.text = "experience modifier: +25%\nMax Health: -1\nAttack: +1";
        }
        else if(item_name == "Ruby Staff"){
            item_info_view.text = "experience modifier: +25%\nMax Health: -1\nAttack: +1";
        }
        else if(item_name == "Topaz Staff"){
            item_info_view.text = "experience modifier: +25%\nMax Health: -1\nAttack: +1";
        }
        else if(item_name == "Wooden Staff"){
            item_info_view.text = "experience modifier: +25%";
        }
        else if(item_name == "Magic Wand"){
            item_info_view.text = "experience modifier: +25%\nMax Health: -1";
        }
        else if(item_name == "Wooden Armor"){
            item_info_view.text = "Armor: +1\nSpeed: -2";
        }
        else if(item_name == "Wooden Shield"){
            item_info_view.text = "Armor: +1\nSpeed: -2";
        }
        else if(item_name == "Wooden Sword"){
            item_info_view.text = "Attack: +1";
        }
        else if(item_name == "Silver Sword"){
            item_info_view.text = "Attack: +2";
        }
        else if(item_name == "Monster Egg"){
            item_info_view.text = "Attack: -6\nArmor: +3\nSpeed: +3";
        }
        else if(item_name == "Monster Eye"){
            item_info_view.text = "Attack: +3\nArmor: -6\nSpeed: +3";
        }
        else if(item_name == "Rune Stone"){
            item_info_view.text = "Attack: +3\nArmor: +3\nSpeed: -6";
        }
        else if(item_name == "Leather Helmet"){
            item_info_view.text = "Armor: +1\nSpeed: +1";
        }
        else if(item_name == "Leather Boot"){
            item_info_view.text = "Armor: +1\nSpeed: +1";
        }
        else if(item_name == "Leather Armor"){
            item_info_view.text = "Armor: +1\nSpeed: +1";
        }
        else if(item_name == "Knife"){
            item_info_view.text = "Attack: +1\nSpeed: +1";
        }
        else if(item_name == "Iron Sword"){
            item_info_view.text = "Attack: +2\nSpeed: -1";
        }
        else if(item_name == "Iron Shield"){
            item_info_view.text = "Armor: +2\nSpeed: -4\nMax Health: +2";
        }
        else if(item_name == "Iron Helmet"){
            item_info_view.text = "Armor: +2\nSpeed: -4\nMax Health: +2";
        }
        else if(item_name == "Iron Boot"){
            item_info_view.text = "Armor: +2\nSpeed: -4\nMax Health: +2";
        }
        else if(item_name == "Iron Armor"){
            item_info_view.text = "Armor: +2\nSpeed: -4\nMax Health: +2";
        }
        else if(item_name == "Helm"){
            item_info_view.text = "Armor: +3\nSpeed: -5\nMax Health: +3";
        }
        else if(item_name == "Hammer"){
            item_info_view.text = "Attack: +1\nSpeed: -2\nMax Health: +1";
        }
        else if(item_name == "Golden Sword"){
            item_info_view.text = "Attack: +3\nArmor: -3";
        }
        else if(item_name == "Bow"){
            item_info_view.text = "Attack: +1\nArmor: -1";
        }
        else if(item_name == "Axe"){
            item_info_view.text = "Attack: +2\nArmor: -2";
        }
        else if(item_name == "Book"){
            item_info_view.text = "can be used for:\n+10 experience";
        }
        else if(item_name == "Book 2"){
            item_info_view.text = "can be used for:\n+20 experience";
        }
        else if(item_name == "Book 3"){
            item_info_view.text = "can be used for:\n+30 experience";
        }
        else if(item_name == "Red Potion"){
            item_info_view.text = "can be used for:\n+10 health";
        }
        else if(item_name == "Red Potion 2"){
            item_info_view.text = "can be used for:\n+20 health";
        }
        else if(item_name == "Red Potion 3"){
            item_info_view.text = "can be used for:\n+30 health";
        }
        else if(item_name == "Crystal"){
            item_info_view.text = "can be used for:\ndeal 5 damage to the sides";
        }
        else if(item_name == "Cut Emerald"){
            item_info_view.text = "Max Health: +2\nHealth: +2";
        }
        else if(item_name == "Cut Ruby"){
            item_info_view.text = "Attack: +1";
        }
        else if(item_name == "Cut Sapphire"){ 
            item_info_view.text = "Armor: +1";
        }
        else if(item_name == "Cut Topaz"){ 
            item_info_view.text = "Speed: +1";
        }
        else if(item_name == "Pearl"){ 
            item_info_view.text = "Speed: +2\nArmor: -1";
        }
        else if(item_name == "Obsidian"){ 
            item_info_view.text = "Armor: +2\nSpeed: -1";
        }
        else if(item_name == "Diamond"){
            item_info_view.text = "Max Health: +2\nHealth: +2\nAttack: +1\nArmor: +1\nSpeed: +1";
        }

    }
}
