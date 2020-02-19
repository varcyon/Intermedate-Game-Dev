using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : Weapon {
    public float blastRadius { get; private set; }
    public float arc { get; private set; }

    public Grenade () {
        weaponName = "Grenade MK4";
        weight = 2.23f;
        blastRadius = 5f;
        damage = 100;
        arc = 45f;
    }

    public Grenade (string _name, float _weight, float _blastRadius, int _damage, float _arc) {
        weaponName = _name;
        weight = _weight;
        blastRadius = _blastRadius;
        damage = _damage;
        arc = _arc;
    }

    public override void MakeSound () {
        Debug.Log("The " +weaponName+ " goes BOOM!!!");
    }

    public override void WeaponStats(){
        base.WeaponStats();
        Debug.Log("Its blast radius is "+blastRadius+ " and it causes "+damage+ " damage. With a "+arc+ " degree arc.");
    }
}