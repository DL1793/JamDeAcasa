using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMove : MonoBehaviour
{
	public float viteza;
	public Rigidbody corp;
	public bool pamant = true;

	private void Start()
	{
		corp = GetComponent<Rigidbody>();
	}

	void Update()
	{
		if (Input.GetButtonDown("Jump") && pamant)
		{
			corp.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
			pamant = true;
		}
		PlayerMovement();


	}

	void PlayerMovement()
	{
		float hor = Input.GetAxis("Horizontal");
		float ver = Input.GetAxis("Vertical");
		Vector3 playerMovement = new Vector3(hor, 0f, ver) * viteza * Time.deltaTime;
		transform.Translate(playerMovement, Space.Self);
	}
	private void OnCollision(Collision collision)
	{
		if (collision.gameObject.tag == "Ground")
		{
			pamant = true;
		}
	}
}
