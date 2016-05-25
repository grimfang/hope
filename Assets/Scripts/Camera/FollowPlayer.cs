using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	[SerializeField]
	private Transform playerTransform;


	// Adding the SerializeField tag keeps it private but shows it in the editor to be modified.
	[SerializeField]
	private float zOffset;

		
	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3 (playerTransform.position.x, playerTransform.position.y, zOffset); 
	}
}
