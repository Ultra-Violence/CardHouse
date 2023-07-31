using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Move_script : MonoBehaviour
{
    public GameObject far_left;
    public GameObject pos0;
    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject far_right;

    public GameObject GameOverMenu;

    public Player_Stats_script Player_Stats;
    public Enemy_Stats_Left_script Enemy_Stats_Left;
    public Enemy_Stats_Right_script Enemy_Stats_Right;
    public Fight Fight;
    public Chest_script Chest_script;

    public Sprite enemy_sprite_skeleton;
    public Sprite enemy_sprite_zombie;
    public Sprite enemy_sprite_cloud; 
    public Sprite enemy_sprite_necromancer;
    public Sprite enemy_sprite_boss1;
    public Sprite enter_right_sprite; 
    public Sprite enter_left_sprite; 
    public Sprite chest_sprite;

    public AudioSource left_audio; 
    public AudioSource right_audio;
    public AudioClip chest_sound;
    public AudioClip skeleton_hit_sound;
    public AudioClip zombie_hit_sound;
    public AudioClip cloud_hit_sound;
    public AudioClip necro_hit_sound;
    public AudioClip boss1_hit_sound;
    public AudioClip skeleton_death_sound;
    public AudioClip zombie_death_sound;
    public AudioClip cloud_death_sound;
    public AudioClip necro_death_sound;
    public AudioClip boss1_death_sound;
    

    private List<string> list_of_tags_1_3 = new List<string>(){"enter", "enter", "chest", "enemy_skeleton" };
    private List<string> list_of_tags_3_6 = new List<string>(){"enter", "enter", "chest","enemy_skeleton", "enemy_skeleton", "enemy_zombie"};
    private List<string> list_of_tags_6_9 = new List<string>(){"enter", "enter" , "chest", "enemy_cloud",  "enemy_skeleton", "enemy_zombie", "enemy_zombie" , "enemy_necromancer"};
    private List<string> list_of_tags_10 = new List<string>(){"enter", "enter", "chest", "enemy_cloud" , "enemy_cloud" , "enemy_necromancer" , "enemy_necromancer" , "enemy_boss1"};
    private List<string> chest_items_list = new List<string>(){"Crystal", "Cut Emerald", "Cut Ruby", "Cut Sapphire", "Cut Topaz", "Diamond", "Obsidian", "Pearl", "Axe", "Book", "Book 2", "Book 3", "Bow", "Emerald Staff", "Golden Sword", "Hammer", "Helm", "Iron Armor", "Iron Boot", "Iron Helmet", "Iron Shield", "Iron Sword", "Knife", "Leather Armor", "Leather Boot", "Leather Helmet", "Magic Wand", "Monster Egg", "Monster Eye", "Red Potion 2", "Red Potion 3", "Red Potion", "Ruby Staff", "Rune Stone", "Sapphire Staff", "Silver Sword", "Topaz Staff", "Wizard Hat", "Wooden Armor", "Wooden Shield", "Wooden Staff", "Wooden Sword"};

    
    public void left_button(){
        if(GameOverMenu.activeInHierarchy == false){
        if(pos1.tag == "enter"){
            pos1.tag = pos0.tag;
            pos0.tag = far_left.tag;
            random_lists_left();
            
        }
        else if(pos1.tag == "chest"){
            pos1.tag = pos0.tag;
            left_audio.clip = chest_sound;
            left_audio.Play();
            Chest_script.take_item(chest_items_list[Random.Range(0, chest_items_list.Count )]);
            pos0.tag = far_left.tag;
            random_lists_left();
        }
        else if(pos1.tag == "enemy_cloud" | pos1.tag == "enemy_skeleton" | pos1.tag == "enemy_zombie" | pos1.tag == "enemy_necromancer" | pos1.tag == "enemy_boss1"){
            if(pos1.tag == "enemy_cloud"){
                left_audio.clip = cloud_hit_sound;
                left_audio.Play();
            }
            else if(pos1.tag == "enemy_skeleton"){
                left_audio.clip = skeleton_hit_sound;
                left_audio.Play();
            }
            else if(pos1.tag == "enemy_zombie"){
                left_audio.clip = zombie_hit_sound;
                left_audio.Play();
            }
            else if(pos1.tag == "enemy_necromancer"){
                left_audio.clip = necro_hit_sound;
                left_audio.Play();
            }
            else if(pos1.tag == "enemy_boss1"){
                left_audio.clip = boss1_hit_sound;
                left_audio.Play();
            }
            Fight.fight_left(Enemy_Stats_Left.attack, Enemy_Stats_Left.armor, Enemy_Stats_Left.speed, Enemy_Stats_Left.health, Player_Stats.attack, Player_Stats.armor, Player_Stats.speed, Player_Stats.health);
        }   
        }
    }

    public void left_move_button(){
        if(GameOverMenu.activeInHierarchy == false){
        if(Player_Stats.armor >= Enemy_Stats_Left.attack){
            Player_Stats.health += 0;
        }
        else if(Player_Stats.armor < Enemy_Stats_Left.attack){
            Player_Stats.health = Player_Stats.health + Player_Stats.armor - Enemy_Stats_Left.attack;
        }
        if(far_right.tag == "enemy_boss1"){
            list_of_tags_10.Add("enemy_boss1");
        }
        far_right.tag = pos3.tag;
        pos3.tag = pos2.tag;
        pos2.tag = pos1.tag;
        pos1.tag = pos0.tag;
        pos0.tag = far_left.tag;
        random_lists_left();

        Enemy_Stats_Right.attack = Enemy_Stats_Left.attack;
        Enemy_Stats_Right.armor = Enemy_Stats_Left.armor;
        Enemy_Stats_Right.speed = Enemy_Stats_Left.speed;
        Enemy_Stats_Right.health = Enemy_Stats_Left.health;
        
        if(pos1.tag == "enemy_cloud"){
                Enemy_Stats_Left.attack = 15;
                Enemy_Stats_Left.armor = 2;
                Enemy_Stats_Left.speed = 9;
                Enemy_Stats_Left.health = 5;
        }
        else if(pos1.tag == "enemy_skeleton"){
                Enemy_Stats_Left.attack = 6;
                Enemy_Stats_Left.armor = 3;
                Enemy_Stats_Left.speed = 4;
                Enemy_Stats_Left.health = 8; 
        }
        else if(pos1.tag == "enemy_zombie"){
                Enemy_Stats_Left.attack = 7;
                Enemy_Stats_Left.armor = 6;
                Enemy_Stats_Left.speed = 2;
                Enemy_Stats_Left.health = 16;
        }
        else if(pos1.tag == "enemy_necromancer"){
                Enemy_Stats_Left.attack = 9;
                Enemy_Stats_Left.armor = 4;
                Enemy_Stats_Left.speed = 6;
                Enemy_Stats_Left.health = 18;
        }
        else if(pos1.tag == "enemy_boss1"){
                Enemy_Stats_Left.attack = 17;
                Enemy_Stats_Left.armor = 8;
                Enemy_Stats_Left.speed = 5;
                Enemy_Stats_Left.health = 22;
        }
        
        }
    }

    public void right_move_button(){
        if(GameOverMenu.activeInHierarchy == false){
        if(Player_Stats.armor >= Enemy_Stats_Right.attack){
            Player_Stats.health += 0;
        }
        else if(Player_Stats.armor < Enemy_Stats_Right.attack){
            Player_Stats.health = Player_Stats.health + Player_Stats.armor - Enemy_Stats_Right.attack;
        }
        if(far_left.tag == "enemy_boss1"){
            list_of_tags_10.Add("enemy_boss1");
        }
        far_left.tag = pos0.tag;
        pos0.tag = pos1.tag;
        pos1.tag = pos2.tag;
        pos2.tag = pos3.tag;
        pos3.tag = far_right.tag;
        random_lists_right();

        Enemy_Stats_Left.attack = Enemy_Stats_Right.attack;
        Enemy_Stats_Left.armor = Enemy_Stats_Right.armor;
        Enemy_Stats_Left.speed = Enemy_Stats_Right.speed;
        Enemy_Stats_Left.health = Enemy_Stats_Right.health;

        if(pos2.tag == "enemy_cloud"){
                Enemy_Stats_Right.attack = 15;
                Enemy_Stats_Right.armor = 2;
                Enemy_Stats_Right.speed = 9;
                Enemy_Stats_Right.health = 5;
        }
        else if(pos2.tag == "enemy_skeleton"){
                Enemy_Stats_Right.attack = 6;
                Enemy_Stats_Right.armor = 3;
                Enemy_Stats_Right.speed = 4;
                Enemy_Stats_Right.health = 8; 
        }
        else if(pos2.tag == "enemy_zombie"){
                Enemy_Stats_Right.attack = 7;
                Enemy_Stats_Right.armor = 6;
                Enemy_Stats_Right.speed = 2;
                Enemy_Stats_Right.health = 16;
        }
        else if(pos2.tag == "enemy_necromancer"){
                Enemy_Stats_Right.attack = 9;
                Enemy_Stats_Right.armor = 4;
                Enemy_Stats_Right.speed = 6;
                Enemy_Stats_Right.health = 18;
        }
        else if(pos2.tag == "enemy_boss1"){
                Enemy_Stats_Right.attack = 17;
                Enemy_Stats_Right.armor = 8;
                Enemy_Stats_Right.speed = 5;
                Enemy_Stats_Right.health = 22;
        }
        
        }
    }

    public void right_button(){
        if(GameOverMenu.activeInHierarchy == false){
        if(pos2.tag == "enter"){
            pos2.tag = pos3.tag;
            pos3.tag = far_right.tag;
            random_lists_right();
        }
        else if(pos2.tag == "chest"){
            pos2.tag = pos3.tag;
            right_audio.clip = chest_sound;
            right_audio.Play();
            Chest_script.take_item(chest_items_list[Random.Range(0, chest_items_list.Count )]);
            pos3.tag = far_right.tag;
            random_lists_right();
        }
        else if(pos2.tag == "enemy_cloud" | pos2.tag == "enemy_skeleton" | pos2.tag == "enemy_zombie" | pos2.tag == "enemy_necromancer" | pos2.tag == "enemy_boss1"){
            if(pos2.tag == "enemy_cloud"){
                right_audio.clip = cloud_hit_sound;
                right_audio.Play();
            }
            else if(pos2.tag == "enemy_skeleton"){
                right_audio.clip = skeleton_hit_sound;
                right_audio.Play();
            }
            else if(pos2.tag == "enemy_zombie"){
                right_audio.clip = zombie_hit_sound;
                right_audio.Play();
            }
            else if(pos2.tag == "enemy_necromancer"){
                right_audio.clip = necro_hit_sound;
                right_audio.Play();
            }
            else if(pos2.tag == "enemy_boss1"){
                right_audio.clip = boss1_hit_sound;
                right_audio.Play();
            }
            Fight.fight_right(Enemy_Stats_Right.attack, Enemy_Stats_Right.armor, Enemy_Stats_Right.speed, Enemy_Stats_Right.health, Player_Stats.attack, Player_Stats.armor, Player_Stats.speed, Player_Stats.health);
        }
        }
    }

    public void resolt_left(int enemy_damage, int player_damage){
        if(GameOverMenu.activeInHierarchy == false){
        if(enemy_damage < 0){
            Enemy_Stats_Left.health += enemy_damage;
        }
        if(player_damage < 0){
            Player_Stats.health += player_damage;
        }
        
        if(Enemy_Stats_Left.health <= 0){
            if(pos1.tag =="enemy_cloud"){
                Player_Stats.plus_exp(9);
                left_audio.clip = cloud_death_sound;
                left_audio.Play();

            }
            else if(pos1.tag =="enemy_skeleton"){
                Player_Stats.plus_exp(3);
                left_audio.clip = skeleton_death_sound;
                left_audio.Play();
            }
            else if(pos1.tag =="enemy_zombie"){
                Player_Stats.plus_exp(6);
                left_audio.clip = zombie_death_sound;
                left_audio.Play();
            }
            else if(pos1.tag =="enemy_necromancer"){
                Player_Stats.plus_exp(12);
                left_audio.clip = necro_death_sound;
                left_audio.Play();
            }
            else if(pos1.tag =="enemy_boss1"){
                Player_Stats.plus_exp(15);
                left_audio.clip = boss1_death_sound;
                left_audio.Play();
                GameOverMenu.SetActive(true);
            }
            pos1.tag = pos0.tag;
            pos0.tag = far_left.tag;
            random_lists_left();
            
        }
        }

    }

    public void resolt_right(int enemy_damage, int player_damage){
        if(GameOverMenu.activeInHierarchy == false){
        if(enemy_damage < 0){
            Enemy_Stats_Right.health += enemy_damage;
        }
        if(player_damage < 0){
            Player_Stats.health += player_damage;
        }
        if(Enemy_Stats_Right.health <= 0){
            if(pos2.tag =="enemy_cloud"){
                Player_Stats.plus_exp(9);
                right_audio.clip = cloud_death_sound;
                right_audio.Play();
            }
            else if(pos2.tag =="enemy_skeleton"){
                Player_Stats.plus_exp(3);
                right_audio.clip = skeleton_death_sound;
                right_audio.Play();
            }
            else if(pos2.tag =="enemy_zombie"){
                Player_Stats.plus_exp(6);
                right_audio.clip = zombie_death_sound;
                right_audio.Play();
            }
            else if(pos2.tag =="enemy_necromancer"){
                Player_Stats.plus_exp(12);
                right_audio.clip = necro_death_sound;
                right_audio.Play();
            }
            else if(pos2.tag =="enemy_boss1"){
                Player_Stats.plus_exp(15);
                right_audio.clip = boss1_death_sound;
                right_audio.Play();
                GameOverMenu.SetActive(true);
            }
            pos2.tag = pos3.tag;
            pos3.tag = far_right.tag;
            random_lists_right();
            
        }
        }

    }

    private void Update() {
        if(far_left.tag == "enemy_cloud"){
            far_left.GetComponent<Image>().sprite = enemy_sprite_cloud;
        }
        else if(far_left.tag == "enemy_skeleton"){
            far_left.GetComponent<Image>().sprite = enemy_sprite_skeleton;  
        }
        else if(far_left.tag == "enemy_zombie"){
            far_left.GetComponent<Image>().sprite = enemy_sprite_zombie;  
        }
        else if(far_left.tag == "enemy_necromancer"){
            far_left.GetComponent<Image>().sprite = enemy_sprite_necromancer;  
        }
        else if(far_left.tag == "enemy_boss1"){
            far_left.GetComponent<Image>().sprite = enemy_sprite_boss1;  
        }
        else if(far_left.tag == "enter"){
            far_left.GetComponent<Image>().sprite = enter_left_sprite;
        }
        else if(far_left.tag == "chest"){
            far_left.GetComponent<Image>().sprite = chest_sprite;
        }

        if(pos0.tag == "enemy_cloud"){
            pos0.GetComponent<Image>().sprite = enemy_sprite_cloud;
        }
        else if(pos0.tag == "enemy_skeleton"){
            pos0.GetComponent<Image>().sprite = enemy_sprite_skeleton;  
        }
        else if(pos0.tag == "enemy_zombie"){
            pos0.GetComponent<Image>().sprite = enemy_sprite_zombie;  
        }
        else if(pos0.tag == "enemy_necromancer"){
            pos0.GetComponent<Image>().sprite = enemy_sprite_necromancer;  
        }
        else if(pos0.tag == "enemy_boss1"){
            pos0.GetComponent<Image>().sprite = enemy_sprite_boss1;  
        }
        else if(pos0.tag == "enter"){
            pos0.GetComponent<Image>().sprite = enter_left_sprite;
        }
        else if(pos0.tag == "chest"){
            pos0.GetComponent<Image>().sprite = chest_sprite;
        }

        if(pos1.tag == "enemy_cloud"){
            pos1.GetComponent<Image>().sprite = enemy_sprite_cloud;
            if(Enemy_Stats_Left.health <= 0){
                Enemy_Stats_Left.attack = 10;
                Enemy_Stats_Left.armor = 2;
                Enemy_Stats_Left.speed = 9;
                Enemy_Stats_Left.health = 5;
            }
        }
        else if(pos1.tag == "enemy_skeleton"){
            pos1.GetComponent<Image>().sprite = enemy_sprite_skeleton;
            if(Enemy_Stats_Left.health <= 0){
                Enemy_Stats_Left.attack = 6;
                Enemy_Stats_Left.armor = 3;
                Enemy_Stats_Left.speed = 4;
                Enemy_Stats_Left.health = 8;
            }   
        }
        else if(pos1.tag == "enemy_zombie"){
            pos1.GetComponent<Image>().sprite = enemy_sprite_zombie;
            if(Enemy_Stats_Left.health <= 0){
                Enemy_Stats_Left.attack = 7;
                Enemy_Stats_Left.armor = 6;
                Enemy_Stats_Left.speed = 2;
                Enemy_Stats_Left.health = 16;
            }   
        }
        else if(pos1.tag == "enemy_necromancer"){
            pos1.GetComponent<Image>().sprite = enemy_sprite_necromancer;
            if(Enemy_Stats_Left.health <= 0){
                Enemy_Stats_Left.attack = 9;
                Enemy_Stats_Left.armor = 4;
                Enemy_Stats_Left.speed = 6;
                Enemy_Stats_Left.health = 18;
            }   
        }
        else if(pos1.tag == "enemy_boss1"){
            pos1.GetComponent<Image>().sprite = enemy_sprite_boss1;
            if(Enemy_Stats_Left.health <= 0){
                Enemy_Stats_Left.attack = 17;
                Enemy_Stats_Left.armor = 8;
                Enemy_Stats_Left.speed = 5;
                Enemy_Stats_Left.health = 22;
            }   
        }
        else if(pos1.tag == "enter"){
            pos1.GetComponent<Image>().sprite = enter_left_sprite;
            Enemy_Stats_Left.attack = 0;
            Enemy_Stats_Left.armor = 0;
            Enemy_Stats_Left.speed = 0;
            Enemy_Stats_Left.health = 0;
        }
        else if(pos1.tag == "chest"){
            pos1.GetComponent<Image>().sprite = chest_sprite;
        }

        if(pos2.tag == "enemy_cloud"){
            pos2.GetComponent<Image>().sprite = enemy_sprite_cloud;
            if(Enemy_Stats_Right.health <= 0){
                Enemy_Stats_Right.attack = 15;
                Enemy_Stats_Right.armor = 2;
                Enemy_Stats_Right.speed = 9;
                Enemy_Stats_Right.health = 5;
            }
        }
        else if(pos2.tag == "enemy_skeleton"){
            pos2.GetComponent<Image>().sprite = enemy_sprite_skeleton;
            if(Enemy_Stats_Right.health <= 0){
                Enemy_Stats_Right.attack = 6;
                Enemy_Stats_Right.armor = 3;
                Enemy_Stats_Right.speed = 4;
                Enemy_Stats_Right.health = 8;
            } 
        }
        else if(pos2.tag == "enemy_zombie"){
            pos2.GetComponent<Image>().sprite = enemy_sprite_zombie;
            if(Enemy_Stats_Right.health <= 0){
                Enemy_Stats_Right.attack = 7;
                Enemy_Stats_Right.armor = 6;
                Enemy_Stats_Right.speed = 2;
                Enemy_Stats_Right.health = 16;
            } 
        }
        else if(pos2.tag == "enemy_necromancer"){
            pos2.GetComponent<Image>().sprite = enemy_sprite_necromancer;
            if(Enemy_Stats_Right.health <= 0){
                Enemy_Stats_Right.attack = 9;
                Enemy_Stats_Right.armor = 4;
                Enemy_Stats_Right.speed = 6;
                Enemy_Stats_Right.health = 18;
            }   
        }
        else if(pos2.tag == "enemy_boss1"){
            pos2.GetComponent<Image>().sprite = enemy_sprite_boss1;
            if(Enemy_Stats_Right.health <= 0){
                Enemy_Stats_Right.attack = 17;
                Enemy_Stats_Right.armor = 8;
                Enemy_Stats_Right.speed = 5;
                Enemy_Stats_Right.health = 22;
            }   
        }
        else if(pos2.tag == "enter"){
            pos2.GetComponent<Image>().sprite = enter_right_sprite;
            Enemy_Stats_Right.attack = 0;
            Enemy_Stats_Right.armor = 0;
            Enemy_Stats_Right.speed = 0;
            Enemy_Stats_Right.health = 0;
        }
        else if(pos2.tag == "chest"){
            pos2.GetComponent<Image>().sprite = chest_sprite;
        }

        if(pos3.tag == "enemy_cloud"){
            pos3.GetComponent<Image>().sprite = enemy_sprite_cloud;
        }
        else if(pos3.tag == "enemy_skeleton"){
            pos3.GetComponent<Image>().sprite = enemy_sprite_skeleton;  
        }
        else if(pos3.tag == "enemy_zombie"){
            pos3.GetComponent<Image>().sprite = enemy_sprite_zombie;  
        }
        else if(pos3.tag == "enemy_necromancer"){
            pos3.GetComponent<Image>().sprite = enemy_sprite_necromancer;   
        }
        else if(pos3.tag == "enemy_boss1"){
            pos3.GetComponent<Image>().sprite = enemy_sprite_boss1;  
        }
        else if(pos3.tag == "enter"){
            pos3.GetComponent<Image>().sprite = enter_right_sprite;
        }
        else if(pos3.tag == "chest"){
            pos3.GetComponent<Image>().sprite = chest_sprite;
        }

        if(far_right.tag == "enemy_cloud"){
            far_right.GetComponent<Image>().sprite = enemy_sprite_cloud;
        }
        else if(far_right.tag == "enemy_skeleton"){
            far_right.GetComponent<Image>().sprite = enemy_sprite_skeleton;  
        }
        else if(far_right.tag == "enemy_zombie"){
            far_right.GetComponent<Image>().sprite = enemy_sprite_zombie;  
        }
        else if(far_right.tag == "enemy_necromancer"){
            far_right.GetComponent<Image>().sprite = enemy_sprite_necromancer;   
        }
        else if(far_right.tag == "enemy_boss1"){
            far_right.GetComponent<Image>().sprite = enemy_sprite_boss1;  
        }
        else if(far_right.tag == "enter"){
            far_right.GetComponent<Image>().sprite = enter_right_sprite;
        }
        else if(far_right.tag == "chest"){
            far_right.GetComponent<Image>().sprite = chest_sprite;
        }
    }

    public void random_lists_left(){
        if(Player_Stats.level >= 1 & Player_Stats.level < 3){
                far_left.tag = list_of_tags_1_3[Random.Range(0, list_of_tags_1_3.Count)];
            }
            else if(Player_Stats.level >= 3 & Player_Stats.level < 6){
                far_left.tag = list_of_tags_3_6[Random.Range(0, list_of_tags_3_6.Count)];
            }
            else if(Player_Stats.level >= 6 & Player_Stats.level <= 9){
                far_left.tag = list_of_tags_6_9[Random.Range(0, list_of_tags_6_9.Count)];
            }
            else if(Player_Stats.level == 10){
                far_left.tag = list_of_tags_10[Random.Range(0, list_of_tags_10.Count)];
                string BossBool = far_left.tag;
                    if(BossBool == "enemy_boss1"){
                        list_of_tags_10.Remove("enemy_boss1");
                    }
            }
    }
    public void random_lists_right(){
        if(Player_Stats.level >= 1 & Player_Stats.level < 3){
                far_right.tag = list_of_tags_1_3[Random.Range(0, list_of_tags_1_3.Count)];
            }
            else if(Player_Stats.level >= 3 & Player_Stats.level < 6){
                far_right.tag = list_of_tags_3_6[Random.Range(0, list_of_tags_3_6.Count)];
            }
            else if(Player_Stats.level >= 6 & Player_Stats.level <= 9){
                far_right.tag = list_of_tags_6_9[Random.Range(0, list_of_tags_6_9.Count)];
            }
            else if(Player_Stats.level == 10){
                far_right.tag = list_of_tags_10[Random.Range(0, list_of_tags_10.Count)];
                string BossBool = far_right.tag;
                if(BossBool == "enemy_boss1"){
                    list_of_tags_10.Remove("enemy_boss1");
                }
            }
    }
    
    
}
