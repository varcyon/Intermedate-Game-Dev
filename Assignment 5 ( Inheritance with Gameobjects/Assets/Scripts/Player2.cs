using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Tank {
    // Update is called once per frame
    void Update () {
        shootTimer += Time.deltaTime;
        Move ();
        if (Input.GetKey (KeyCode.RightControl)) {
            Shoot ();
        }

    }
    public override void Move () {

        if (Input.GetKey (KeyCode.UpArrow)) {
            transform.Translate (Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.DownArrow)) {
            transform.Translate (-Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.RightArrow)) {
            transform.Rotate (Vector3.up, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey (KeyCode.LeftArrow)) {
            transform.Rotate (Vector3.up, -rotateSpeed * Time.deltaTime);
        }
    }

    public override void Shoot () {
        if (shootTimer > shootRate) {
            for (int i = 0; i < 100; i++) {
                shootTimer = 0;
                GameObject GO = Instantiate (projectile, shootPoint.transform.position, shootPoint.transform.rotation);
                GO.GetComponent<Rigidbody> ().AddForce (transform.forward * shootForce, ForceMode.Impulse);

            }

        }
    }

}