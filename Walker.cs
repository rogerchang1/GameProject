using UnityEngine;
using System.Collections;

public class Walker : MonoBehaviour {

	private EnemyViewer ev;
	public float walkSpeed = 2.0f;
	public float wallLeft = 0.0f;
	public float wallRight = 5.0f;

	float walkingDirection = 1.0f;

	Vector2 walkAmount;

	// Use this for initialization
	void Start () {
		ev = GameObject.Find("SlimeSprite").GetComponent<EnemyViewer> ();
	}
	
	// Update is called once per frame
	void Update () {
		walkAmount.x = walkingDirection * walkSpeed * Time.deltaTime;
		
		if (walkingDirection > 0.0f && transform.position.x >= wallRight) {
				walkingDirection = -1.0f;
				ev.setDirection(-1);
		} else if (walkingDirection < 0.0f && transform.position.x <= wallLeft) {
				walkingDirection = 1.0f;
				ev.setDirection(1);
		}
		transform.Translate(walkAmount);
	}
}
