using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string userName;
    public string race;
    public int characterClass;

    public float health;
    public int level;


    public Player()
    {
        userName ="Default Name";
        race = "Human";
        characterClass = 1;
        health = 80;
        level = 25;
    }

}
