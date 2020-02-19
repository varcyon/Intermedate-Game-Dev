using UnityEngine;

public class Player {
    public string name;
    public string type;
    public int attack;
    public int health;

    public Player () {
        name = "Varcyon";
        type = "Necromancer";
        attack = 9000;
        health = 1000;
    }

    public Player (string _name, string _type, int _attack, int _health) {
        name = _name;
        type = _type;
        attack = _attack;
        health = _health;
    }

    public void PlayerStats () {
        Debug.Log ("The player named " + name + " is a " + type + ". They have " + health + " health points and an attack of " + attack);
    }
}