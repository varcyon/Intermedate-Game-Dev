using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character 
{
    public string name;
    public int health;
    public float moveSpeed;
    public string status;

   public void Move(){
       Debug.Log(name +"is moving somewhere!");
   }
}
