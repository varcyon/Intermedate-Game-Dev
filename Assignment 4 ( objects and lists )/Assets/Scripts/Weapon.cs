using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon {
    public float weight;
    public string weaponName;
    public int damage;

    public virtual void MakeSound () {
        Debug.Log ("The weapon SCREAMS, 'I'm a weapon!'");
    }

    public virtual void WeaponStats () {
        Debug.Log ("The weight of this " + weaponName + " is " + weight + " lbs");
    }
}