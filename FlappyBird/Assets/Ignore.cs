using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignore : MonoBehaviour {

    public Transform pipePrefab;

	void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Pipe")
        {
            Physics2D.IgnoreCollision(pipePrefab.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        }
    }
}
