using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public float rotateSpeed = .1f;
	public float h;
	public float v;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");
		v = Input.GetAxis("Vertical");
		rotateVertical ();
	}

	void rotateVertical(){
		this.transform.Rotate (h, v, 0);
	}
}
