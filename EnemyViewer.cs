using UnityEngine;
using System.Collections;

public class EnemyViewer : MonoBehaviour{
	
	private Animator animator;
	public int d;
	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update()
	{

		
		if (d > 0){
			animator.SetInteger("Direction", 0);
		}
		else if (d < 0){
			animator.SetInteger("Direction", 1);
		}
	}

	public void setDirection (int dir){
		d = dir;
	}
}