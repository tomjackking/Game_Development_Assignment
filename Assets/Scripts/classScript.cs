﻿
//use this to store stats/abilities for classes/enemies change depending on class/enemy, save as for that class

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classScript : MonoBehaviour
{
    //TODO: TAKE VALUE FROM ABILITY SELECTION SET ints TO VALUE FOR SWITCH STATEMENTS
    //Setup for switch statements (might change later)
    public static int wep_1 = 0;
    public static int wep_2 = 0;
    public static int abil_1 = 0;
    public static int abil_2 = 0;

    //Stat setup (might change later)
    public int strength;
    public int agility;
    public int intelligence;
    public int health;
    public int movement;
    public int initiative; //change depending on class

    //extra setup for referencing
    public int classNum;
    public int unitNum;

    // Start is called before the first frame update
    void Start()
    {
        switch (classNum) 
        {
            case 0: //warrior
                strength = Random.Range(7, 9);
                agility = Random.Range(5, 7);
                intelligence = Random.Range(2, 5);
                health = Random.Range(110, 130);
                movement = 3;
                initiative = Random.Range(1, 11) + agility;
                break;
            case 1: //priest
                strength = Random.Range(5, 7);
                agility = Random.Range(5, 7);
                intelligence = Random.Range(6, 8);
                health = Random.Range(100, 120);
                movement = 3;
                initiative = Random.Range(1, 11) + agility;
                break;
            case 2: //mage
                strength = Random.Range(2, 5);
                agility = Random.Range(6, 8);
                intelligence = Random.Range(7, 9);
                health = Random.Range(90, 110);
                movement = 3;
                initiative = Random.Range(1, 11) + agility;
                break;
            case 3: //rogue
                strength = Random.Range(6, 8);
                agility = Random.Range(7, 9);
                intelligence = Random.Range(5, 6);
                health = Random.Range(100, 110);
                movement = 3;
                initiative = Random.Range(1, 11) + agility;
                break;
            case 4: //marksman
                strength = Random.Range(2, 5);
                agility = Random.Range(6, 8);
                intelligence = Random.Range(2, 5);
                health = Random.Range(90, 110);
                movement = 3;
                initiative = Random.Range(1, 11) + agility;
                break;

        }
        //generates stats for classes (change value ranges based on class)

        
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    void primaryWeapon()
    {
        switch (wep_1)
        {
            case 2:
                //Enter code to set this weapon
                break;
            case 1:
                //Enter code to set this weapon
                break;
            default:
                //deal strength in dmg
                int range = 1;
                int dmg = strength * 1;
                break;
        }
        switch (wep_2)
        {
            case 2:
                //Enter code to set this weapon
                break;
            case 1:
                //Enter code to set this weapon
                break;
            default:
                //deal strength in dmg
                int dmg = strength * 1;
                break;
        }
        switch (abil_1)
        {
            case 2:
                //Enter code to set this weapon
                break;
            case 1:
                //Enter code to set this weapon
                break;
            default:
                //deal strength in dmg
                int dmg = strength * 1;
                break;
        }
        switch (abil_2)
        {
            case 2:
                //Enter code to set this weapon
                break;
            case 1:
                //Enter code to set this weapon
                break;
            default:
                //deal strength in dmg
                int dmg = strength * 1;
                break;
        }
    }
}
