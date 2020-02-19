using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy {
    public int bombCount;

    public Goblin () {
        name = "Generic Goblin";
        health = 100;
        moveSpeed = 3f;
        status = "Idle";

        enemyType = "Goblin";
        movementType = "running";
        attackRange = 2.3f;
        attackDamage = 3;

        bombCount = 10;
    }

    public Goblin (string _name, int _health, float _moveSpeed, string _status, string _enemyType, string _movementType, float _attackRange, int _attackDamage, int _bombCount) {
        name = _name;
        health = _health;
        moveSpeed = _moveSpeed;
        status = _status;

        enemyType = _enemyType;
        movementType = _movementType;
        attackRange = _attackRange;
        attackDamage = _attackDamage;

        bombCount = _bombCount;
    }

    public void ThrowBombs () {
        Debug.Log (name + ", the " + enemyType + ", throws a bomb!!");
        bombCount--;
    }
}