using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour {

	// Editor Configs for player 
	public int speed;
	public int jumpHeight;

	// Components
	private Rigidbody playerRigidBody;

	// movement & jumping
	private float horizontalMovement;
	private bool isOnGround;
	private bool isOnJumpSurface;
	private float doJump;

	// Use this for initialization
	void Start () {
		playerRigidBody = GetComponent<Rigidbody> ();
		doJump = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		horizontalMovement = Input.GetAxis ("Horizontal");
		doJump = Input.GetAxis ("Jump");
	}

	void FixedUpdate(){
		if (horizontalMovement != 0.0f) {
			playerRigidBody.AddForce (new Vector3(horizontalMovement * speed, 0.0f, 0.0f));
		}

		if (doJump != 0.0f) {
			if (isOnGround || isOnJumpSurface) {
				playerRigidBody.AddForce (new Vector3 (0.0f, doJump * speed + jumpHeight, 0.0f), ForceMode.Impulse);
				isOnGround = false;
				isOnJumpSurface = false;
			}
		}
	}

	void OnCollisionEnter(Collision otherObject){
		if (otherObject.gameObject.tag == "JumpSurface") {
			//Debug.Log("OtherObject: " + otherObject.gameObject.name);
			isOnJumpSurface = true;
		} else if (otherObject.gameObject.tag == "GroundPlane") {
			isOnGround = true;
		} else {
			isOnGround = false;
			isOnJumpSurface = false;
		}
	}
}
