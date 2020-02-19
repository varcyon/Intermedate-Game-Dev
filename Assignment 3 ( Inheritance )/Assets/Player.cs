using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : Character
{
    public string playerClass;
    public int level;
    public int exp;
    public int stamina;
    public int intelligence;
    public int strength;

    public void DisplayStats(){
        Debug.Log(name +", the "+playerClass+ ", has " + health + " health and is level " + level +", They have "+stamina+ " stamina, "+intelligence+ ", and "+ strength + " strength.");
    }

}
