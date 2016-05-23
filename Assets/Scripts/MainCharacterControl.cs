using UnityEngine;
using System.Collections;

public class MainCharacterControl : MonoBehaviour {

    public int movementSpeed = 10;

    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate () {
        rigidBody.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, Input.GetAxis("Vertical") * movementSpeed);

    }
}
