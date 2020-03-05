using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour , IRotate
{
    public void RotateThis () {
        transform.Rotate (new Vector3 (0, 30f, 0));
    }
}