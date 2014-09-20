using UnityEngine;
using System.Collections;

public class PlayerViewer : MonoBehaviour{
	
	private Animator animator;
	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update()
	{

		float h = Input.GetAxis("Horizontal");
		
		if (h > 0){
			animator.SetInteger("Direction", 0);
		}
		else if (h < 0){
			animator.SetInteger("Direction", 1);
		}
	}
}