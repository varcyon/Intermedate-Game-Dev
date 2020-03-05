using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour, IChangeSize, IRotate {
    int sizeCount = 0;
    public void ChangeSize () {
        Vector3 size = transform.localScale;
        transform.localScale = size + Vector3.one;
        sizeCount++;
        if(sizeCount > 4){
            transform.localScale = Vector3.one;
            sizeCount = 0;
        }
    }

    public void RotateThis () {
        transform.Rotate (new Vector3 (0, 15, 0));
    }

}