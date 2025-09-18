using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]	
public class PlayerController : MonoBehaviour
{

	private float moveSpeed = 1.2f;

	private Rigidbody rb;

	// System
	private float xInput;
	private bool isGrounded;

    void Start()
    {
		rb = GetComponent<Rigidbody>();
		rb.freezeRotation = true;
	}

    // Update is called once per frame
    void Update()
    {
		xInput = Input.GetAxisRaw("Horizontal");

		if (Input.GetButtonDown("Jump") && isGrounded)
			Jump();

		Vector3 prevPos = transform.position;
		transform.Translate(new Vector3(xInput, 0, 0) * moveSpeed * Time.fixedDeltaTime);
	}

	private void Jump()
	{
		Debug.Log("Jump");
		rb.AddForce(Vector3.up * 400);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision != null && collision.collider.CompareTag("Ground")) 
		{
			isGrounded = true;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision != null && collision.collider.CompareTag("Ground"))
		{
			isGrounded = false;
		}
	}
}
