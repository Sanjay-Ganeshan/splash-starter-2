using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EvilAI : MonoBehaviour {

    public int hp;

    public float timeUntilSetDestination = 3f;

    private float timeSinceSetDestination = 0f;

    private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceSetDestination = timeSinceSetDestination + Time.deltaTime;
        if(timeSinceSetDestination > timeUntilSetDestination)
        {
            agent.SetDestination(GameObject.FindGameObjectWithTag("Collector").transform.position);
            timeSinceSetDestination = 0;
        }
	}
}
