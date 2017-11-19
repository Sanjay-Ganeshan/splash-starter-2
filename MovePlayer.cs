using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float movementSpeed = 4.0f;
    public float angularSpeed = 120.0f;
    public string s = "hello there";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        this.gameObject.transform.Translate(verticalMovement * movementSpeed * Time.deltaTime * Vector3.forward, Space.Self);
        this.gameObject.transform.Rotate(Vector3.up, horizontalMovement * Time.deltaTime * angularSpeed, Space.Self);


    }
}
