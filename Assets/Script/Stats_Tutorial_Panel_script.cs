using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats_Tutorial_Panel_script : MonoBehaviour
{
    public Text panel_name;
    public Text panel_info;

    private void Update() {
        gameObject.GetComponent<Transform>().position = new Vector3(Input.mousePosition.x - 250, Input.mousePosition.y, 0);
    }

    public void view(string name){
        if(name == "Health"){
            panel_name.text = name;
            panel_info.text = "This is the main characteristic, if your health level drops below zero, you will die.";
        }
        else if(name == "Attack"){
            panel_name.text = name;
            panel_info.text = "This characteristic shows how hard you hit.";
        }
        else if(name == "Armor"){
            panel_name.text = name;
            panel_info.text = "Any attack that an enemy deals to you is reduced by the value of this characteristic.";
        }
        else if(name == "Speed"){
            panel_name.text = name;
            panel_info.text = "The one who has more Speed strikes first. If this characteristic falls below zero, it also affects the Armor.";
        }
    }
}
