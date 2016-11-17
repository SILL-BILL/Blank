using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private CharacterController controller;
	private Animator animator;
	private Vector3 moveDirection = Vector3.zero;


	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void moveToLeft(){

	}

	public void moveToRight(){

	}
}
