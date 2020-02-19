using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    public string enemyType;
    public string movementType;
    public float attackRange;
    public int attackDamage;
    

    public void Retreat(){
        status = "Retreating";
        Debug.Log(name + " retreats at the speed of " + moveSpeed);
    }

    public void DisplayStatus(){
        Debug.Log(name + " is at " +health+ " health and is "+ status);
    }
}
