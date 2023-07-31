using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icons_Stats_script : MonoBehaviour
{
    public Stats_Tutorial_Panel_script Stats_Tutorial_Panel;
    public void tutorial_panel_info(){
        Stats_Tutorial_Panel.view(gameObject.name);
    }
}
