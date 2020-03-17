<<<<<<< HEAD
﻿using UnityEngine;
public class MainControl : MonoBehaviour {
    void Update () {
        {
            if (Input.GetMouseButtonDown (0)) {

                Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast (ray, out hitInfo)) {
                    ITakeDamage damagable = hitInfo.collider.GetComponent<ITakeDamage> ();
                    if (damagable != null) {
                        damagable.TakeDamage (1);
                    }

                    IRotate rotate = hitInfo.collider.GetComponent<IRotate> ();
                    if (rotate != null) {
                        rotate.RotateThis ();
                    }

                    IMove move = hitInfo.collider.GetComponent<IMove> ();
                    if (move != null) {
                        move.Move ();
                    }

                    IChangeSize changeSize = hitInfo.collider.GetComponent<IChangeSize> ();
                    if (changeSize != null) {
                        changeSize.ChangeSize ();
                    }
                }
            }
        }
    }
=======
﻿using UnityEngine;
public class MainControl : MonoBehaviour {
    void Update () {
        {
            if (Input.GetMouseButtonDown (0)) {

                Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast (ray, out hitInfo)) {
                    ITakeDamage damagable = hitInfo.collider.GetComponent<ITakeDamage> ();
                    if (damagable != null) {
                        damagable.TakeDamage (1);
                    }

                    IRotate rotate = hitInfo.collider.GetComponent<IRotate> ();
                    if (rotate != null) {
                        rotate.RotateThis ();
                    }

                    IMove move = hitInfo.collider.GetComponent<IMove> ();
                    if (move != null) {
                        move.Move ();
                    }

                    IChangeSize changeSize = hitInfo.collider.GetComponent<IChangeSize> ();
                    if (changeSize != null) {
                        changeSize.ChangeSize ();
                    }
                }
            }
        }
    }
>>>>>>> master
}