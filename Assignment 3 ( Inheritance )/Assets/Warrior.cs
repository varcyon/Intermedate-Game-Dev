using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Player {
    public int weaponDamage;

    public Warrior () {
        name = "Thor";
        health = 150;
        moveSpeed = 20;
        status = "Adventuring";

        playerClass = "Warrior";
        level = 41;
        exp = 15241145;
        stamina = 20;
        intelligence = 1;
        strength = 30;

        weaponDamage = strength * level;
    }

    public Warrior (string _name, int _health, float _moveSpeed, string _status, string _playerClass, int _level, int _exp, int _Stamina, int _intelligence, int _strength) {
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

        weaponDamage = strength * level;
    }

    public void Cleave () {
        Debug.Log (name + " Cleaves through the giant Ogre and splits it in two");
    }

    public void Whirlewind () {
        Debug.Log (name + " spins through the group of goblins sending them flying");
    }
}