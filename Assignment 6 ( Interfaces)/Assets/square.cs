<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour, ITakeDamage
{
    int health = 10;

    public void TakeDamage(int amount){
        health -= amount;
        Debug.Log("Square has "+health+ " health!.");

        if( health <= 0){
            Destroy(this.gameObject);
        }
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour, ITakeDamage
{
    int health = 10;

    public void TakeDamage(int amount){
        health -= amount;
        Debug.Log("Square has "+health+ " health!.");

        if( health <= 0){
            Destroy(this.gameObject);
        }
    }
}
>>>>>>> master
