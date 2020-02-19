using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogre : Enemy {

    public int heads;

    public Ogre () {
        name = "Generic Ogre";
        health = 300;
        moveSpeed = 1f;
        status = "Rampaging";

        enemyType = "Ogre";
        movementType = "stomping";
        attackRange = 4f;
        attackDamage = 15;

        heads = 2;

    }

    public Ogre (string _name, int _health, float _moveSpeed, string _status, string _enemyType, string _movementType, float _attackRange, int _attackDamage, int _headCount) {
        name = _name;
        health = _health;
        moveSpeed = _moveSpeed;
        status = _status;

        enemyType = _enemyType;
        movementType = _movementType;
        attackRange = _attackRange;
        attackDamage = _attackDamage;

        heads = _headCount;

    }

    public void Bash () {
        Debug.Log (name + ", the " + enemyType + ", bashes and bits at the player with all " + heads + " of their heads!!");
    }
}