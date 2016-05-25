using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour {

	public int speed; 

	private Rigidbody playerRigidBody;
	private float horizontalMovement;

	// Use this for initialization
	void Start () {
		playerRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		horizontalMovement = Input.GetAxis ("Horizontal");
	}

	void FixedUpdate(){
		if (horizontalMovement != 0.0f) {
			playerRigidBody.AddForce (new Vector3(horizontalMovement * speed, 0.0f, 0.0f));
		}
	}
}
