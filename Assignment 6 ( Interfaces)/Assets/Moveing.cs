using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveing : MonoBehaviour, IMove {
    // Start is called before the first frame update
    public void Move () {
        transform.position += new Vector3 (Random.Range (-2, 2), Random.Range (-2, 2), Random.Range (-2, 2));
    }
}