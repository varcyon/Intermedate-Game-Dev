using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        Ogre ogre = new Ogre ();
        Goblin goblin = new Goblin ();

        Sorcerer sorcerer = new Sorcerer ();
        Warrior warrior = new Warrior ();
        Necromancer necromancer = new Necromancer ();

        Debug.Log ("//////////////////////////////");
        ogre.Bash ();
        ogre.Retreat ();
        ogre.DisplayStatus ();
        ogre.Move ();

        Debug.Log ("//////////////////////////////");
        goblin.ThrowBombs ();
        goblin.Retreat ();
        goblin.DisplayStatus ();
        goblin.Move ();

        Debug.Log ("//////////////////////////////");
        sorcerer.DisplayStats ();
        sorcerer.CastFireball ();
        sorcerer.CastIceStorm ();
        sorcerer.Move ();

        Debug.Log ("//////////////////////////////");
        warrior.DisplayStats ();
        warrior.Whirlewind ();
        warrior.Cleave ();
        warrior.Move ();

        Debug.Log ("//////////////////////////////");
        necromancer.DisplayStats ();
        necromancer.SummonSkeleton ();
        necromancer.Drainlife ();
        necromancer.Move ();

    }

}