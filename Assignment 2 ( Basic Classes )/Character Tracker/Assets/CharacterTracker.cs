using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTracker : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        Enemy enemy1 = new Enemy ();
        Enemy enemy2 = new Enemy ("Undead", 30, 100);

        Player player1 = new Player ();
        Player player2 = new Player ("Zanatos", "Thief", 50, 5);

        enemy1.EnemyStats ();
        enemy2.EnemyStats ();

        player1.PlayerStats ();
        player2.PlayerStats ();

        enemy1.type = "Fairy";
        enemy1.EnemyStats ();

        player2.health -= enemy1.attack;
        player2.PlayerStats ();
    }

    // Update is called once per frame
    void Update () {

    }
}