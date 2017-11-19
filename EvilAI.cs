using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilAI : MonoBehaviour {

    public int hp;

    public float timeUntilSetDestination = 3f;

    private float timeSinceSetDestination = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceSetDestination = timeSinceSetDestination + Time.deltaTime;
        if(timeSinceSetDestination > timeUntilSetDestination)
        {
            // SET THE DESTINATION
            timeSinceSetDestination = 0;
        }
	}
}
