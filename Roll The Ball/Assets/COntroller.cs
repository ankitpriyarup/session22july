using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COntroller : MonoBehaviour
{
	public float speed;

	void Update ()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody>();
		Vector3 movement = new Vector3(horizontal, 0, vertical);
		rigidbody.AddForce(movement * speed);
	}
}
