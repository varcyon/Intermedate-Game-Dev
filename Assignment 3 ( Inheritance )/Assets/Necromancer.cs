using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necromancer : Player {

    public int minionMax;
    public int corpsePool;

    public Necromancer () {
        name = "Varcyon";
        health = 60;
        moveSpeed = 15f;
        status = "Summoning";

        playerClass = "Necromancer";
        level = 100;
        exp = 999999999;
        stamina = 6;
        intelligence = 30;
        strength = 5;

        minionMax = intelligence;
        corpsePool = intelligence * level;
    }

    public Necromancer (string _name, int _health, float _moveSpeed, string _status, string _playerClass, int _level, int _exp, int _Stamina, int _intelligence, int _strength) {
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

        minionMax = intelligence;
        corpsePool = intelligence * level;
    }

    public void SummonSkeleton () {
        Debug.Log (name + " Summons a skeleton from the grave, it races toward the Ogre and ravages it");
    }
    public void Drainlife () {
        Debug.Log (name + " drains the life force all things nearby to heal himself");
    }
}