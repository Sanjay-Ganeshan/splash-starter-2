using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float spawnTime = 4.0f;

    public GameObject whatToSpawn;

    private float timeSinceSpawn = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceSpawn += Time.deltaTime;
        if(timeSinceSpawn > spawnTime)
        {
            Instantiate(whatToSpawn, this.gameObject.transform);
            timeSinceSpawn = 0;
        }
	}
}
