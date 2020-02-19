using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phaser : Weapon {
    public string phaserColor { get; private set; }
    public string damageType { get; private set; }

    public Phaser () {
        weaponName = "Hand Phaser MK14";
        weight = 1f;
        damage = 500;
        phaserColor = "Blue";
        damageType = "ice";

    }

    public Phaser (string _name, float _weight, string _phaserColor, int _damage, string _damageType) {
        weaponName = _name;
        weight = _weight;
        damage = _damage;
        phaserColor = _phaserColor;
        damageType = _damageType;
    }

    public override void MakeSound () {
        Debug.Log ("Beeeeeeeeeeeeeeeeeeeeaammmmmmmmm");
    }

    public override void WeaponStats () {
        base.WeaponStats ();
        Debug.Log ("This "+weaponName+ " is an "+damageType+  " type with the beam color of " +phaserColor+ " does "+damage+ " damage");
    }
}