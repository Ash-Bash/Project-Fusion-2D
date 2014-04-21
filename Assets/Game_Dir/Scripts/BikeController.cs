using UnityEngine;
using System.Collections;

public class BikeController : MonoBehaviour {

	public GameObject BackBikeWheel;

	public float BackWheelSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void FixedUpdate(){

		if(Input.GetKeyDown(KeyCode.A)){

			BackBikeWheel.rigidbody2D.AddTorque(BackWheelSpeed);

		}

	}
}
