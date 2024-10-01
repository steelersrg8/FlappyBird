using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    
	//The Ship
	public GameObject pipes;

    //The interval
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnNext", 1, 3);
    }
    void Update()
    {
       
    }

    void SpawnNext(){
        Instantiate(pipes, new Vector3(transform.position.x,Random.Range(-3.0f,3.0f),0), Quaternion.identity);
    }
}
