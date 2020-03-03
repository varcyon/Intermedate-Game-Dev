using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour {
    public float speed;
    public float rotateSpeed;
    public GameObject shootPoint;
    public GameObject projectile;
    public int shootRate;
    public float shootTimer;
    public float shootForce;
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        Move ();
    }

    public virtual void Move () {

        if (Input.GetKey (KeyCode.W)) {
            transform.Translate (Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.S)) {
            transform.Translate (-Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.D)) {
            transform.Rotate (Vector3.up, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.A)) {
            transform.Rotate (Vector3.up, -rotateSpeed * Time.deltaTime);
        }
    }

    public virtual void Shoot () {
        GameObject GO = Instantiate (projectile, shootPoint.transform.position, shootPoint.transform.rotation);
        GO.GetComponent<Rigidbody> ().AddForce (transform.forward*shootForce, ForceMode.Impulse);
    }
}
