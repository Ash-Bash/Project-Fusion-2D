using UnityEngine;
using System.Collections;

public class BikeController : MonoBehaviour {

	public GameObject BackBikeWheel;
	public GameObject FrontBikeWheel;

	public float BackWheelSpeed;
	public float FrontWheelSpeed;

	public float BikeSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void FixedUpdate(){

		if(Input.GetKeyDown(KeyCode.A)){

			BackBikeWheel.rigidbody2D.AddTorque(-BackWheelSpeed);
			//FrontBikeWheel.rigidbody2D.AddTorque(-FrontWheelSpeed);
			//rigidbody2D.AddForce(transform.right * BikeSpeed);

		}

	}
}
