using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorcerer : Player {

    public int spellDamage;
    public int manaPool;

    public Sorcerer () {
        name = "James";
        health = 30;
        moveSpeed = 30f;
        status = "Reading";

        playerClass = "Sorcerer";
        level = 23;
        exp = 10000;
        stamina = 4;
        intelligence = 20;
        strength = 3;

        spellDamage = intelligence;
        manaPool = intelligence * level;
    }

    public Sorcerer (string _name, int _health, float _moveSpeed, string _status, string _playerClass, int _level, int _exp, int _Stamina, int _intelligence, int _strength) {
        name = _name;
        health = _health;
        moveSpeed = _moveSpeed;
        status = _status;

        playerClass = _playerClass;
        level = _level;
        exp = _exp;
        stamina = _Stamina;
        intelligence = _intelligence;
        strength = _strength;

        spellDamage = intelligence;
        manaPool = intelligence * level;
    }

    public void CastFireball(){
        Debug.Log(name+" casts Fireball and roasts the puny Goblin for "+spellDamage+" damage.");
    }

    public void CastIceStorm(){
        Debug.Log ( name +" casts Icestorm and freezes everything");
    }

}