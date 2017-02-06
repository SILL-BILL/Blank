using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private CharacterController controller;
	private Animator animator;
	private float x;
	private float y;
	private Vector3 velocity;
	public float jumpPower;
	public float speed;


	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		animator = GetComponent<Animator> ();
		velocity = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {

		if (controller.isGrounded) {
			velocity = Vector3.zero;
		}

		x = Input.GetAxis("Horizontal");
		y = Input.GetAxis("Vertical");
		Vector3 input = new Vector3(x, 0, y);
		//　方向キーが多少押されている
		if(input.magnitude > 0.1f && !animator.GetCurrentAnimatorStateInfo(0).IsName("Jump")) {
			animator.SetFloat("Run", input.magnitude);
			transform.LookAt(transform.position + input);
			velocity += input.normalized * 2;
			//　キーの押しが小さすぎる場合は移動しない
		} else {
			animator.SetFloat("Run", 0);
		}
		if(Input.GetButtonDown("Jump") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Jump")) {
			animator.SetBool("Jump", true);
			velocity.y += jumpPower;
		}
	
		velocity.y += Physics.gravity.y * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime * speed);
	}

	public void moveToLeft(){

	}

	public void moveToRight(){

	}

	public void Jump(){

	}
}
