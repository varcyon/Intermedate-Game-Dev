using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    List<Weapon> weapons = new List<Weapon>();

    void Start()
    {
        weapons.Add(new Phaser());
        weapons.Add(new Phaser("Little Mighty",1.3f,"Red",600,"Fire"));
        weapons.Add(new Phaser("E-Radiator",1.7f,"Green",300,"Radiation"));

        weapons.Add(new Grenade());
        weapons.Add(new Grenade("Pebble", 4f,20f,200,30f));
        weapons.Add(new Grenade("Big Daddy", 10f,100f,350,90));

        foreach (Weapon w in weapons)
        {   Debug.Log("//////////////////////////");
            w.MakeSound();
            w.WeaponStats();
        }
    }

}
