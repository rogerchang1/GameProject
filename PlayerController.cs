﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour{
	
	private Animator animator;
	[HideInInspector]
	public bool jump = false;
	
	public float moveForce = 50f;
	public float maxSpeed = 5f;
	public float jumpForce = 5000f;


	private Transform groundDetector;
	private bool grounded = false;

	// Use this for initialization
	void Awake(){
		//setting up references;
		groundDetector = transform.Find ("GroundDetector");
	}
	
	// Update is called once per frame
	void Update()
	{
		// The player is grounded if a linecast to the groundcheck position hits anything on the ground layer.
		grounded = Physics2D.Linecast(transform.position, groundDetector.position, 1 << LayerMask.NameToLayer("Terrain"));  
		
		// If the jump button is pressed and the player is grounded then the player should jump.
		if(Input.GetButtonDown("Jump") && grounded)
			jump = true;
	}
	
	void FixedUpdate ()
	{
		// Cache the horizontal input.
		float h = Input.GetAxis("Horizontal");

		if (grounded && h == 0) 
			rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
		

		if(h * rigidbody2D.velocity.x < maxSpeed) 			
			rigidbody2D.AddForce(Vector2.right * h * moveForce); 		 		
		if(Mathf.Abs(rigidbody2D.velocity.x) > maxSpeed)
			rigidbody2D.velocity = new Vector2(Mathf.Sign(rigidbody2D.velocity.x) * maxSpeed, rigidbody2D.velocity.y);
		
		// If the player should jump...
		if(jump)
		{	
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));
			jump = false;
		}
	}
}