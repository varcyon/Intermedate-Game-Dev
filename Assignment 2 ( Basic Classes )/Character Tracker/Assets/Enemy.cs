using UnityEngine;

public class Enemy {
    public string type;
    public int attack;
    public int health;

    public Enemy () {
        type = "Orc";
        attack = 10;
        health = 50;
    }

    public Enemy (string _type, int _attack, int _health) {
        type = _type;
        attack = _attack;
        health = _health;
    }

    public void EnemyStats () {
        Debug.Log ("The " + type + " has " + health + " health left and has an attack of " + attack);
    }
}