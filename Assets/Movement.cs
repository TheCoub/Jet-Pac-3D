using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Rigidbody phys;
	public float packForce = 1.0f;
	public float movementSpeed = 1.0f;
	public float strafeSpeed = .75f;
	public float rotateSpeed = 2.0f;
	public float h;
	public float v;
	public float speedCap = 25;

	// Use this for initialization
	void Start () {
		phys = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		moveUp ();
		turn ();
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis("Vertical");
		moveFoward ();
		moveBackwards ();
		moveLeft ();
		moveRight ();
	}

	void moveUp(){
		if (Input.GetKey (KeyCode.Space)) {
			phys.AddForce(0, packForce, 0);
		}
	}

	void moveFoward(){
		if (Input.GetKey (KeyCode.W) && phys.velocity.magnitude <= speedCap) {
			phys.AddForce(transform.forward * movementSpeed);
		}
	}

	void moveBackwards(){
		if (Input.GetKey (KeyCode.S) && phys.velocity.magnitude <= speedCap) {
			phys.AddForce(transform.forward * movementSpeed * -1);
		}
	}

	void moveLeft(){
		if (Input.GetKey (KeyCode.A) && phys.velocity.magnitude <= speedCap) {
			phys.AddForce(transform.right * strafeSpeed * -1);
		}
	}

	void moveRight(){
		if (Input.GetKey (KeyCode.D) && phys.velocity.magnitude <= speedCap) {
			phys.AddForce(transform.right * strafeSpeed);
		}
	}


	void turn(){
		if(Input.GetKey(KeyCode.E)){
			transform.Rotate (0, rotateSpeed, 0);
		}
		if(Input.GetKey(KeyCode.Q)){
			transform.Rotate (0, rotateSpeed * -1, 0);
		}
		phys.transform.Rotate (0, v * rotateSpeed, 0);
	}

}
