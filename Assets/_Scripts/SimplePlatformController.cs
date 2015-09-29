using UnityEngine;
using System.Collections;


public class SimplePlatformController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	[HideInInspector] public bool facingRight = true;
	[HideInInspector] public bool jump = true;

	public float moveForce = 365f;
	public float maxSpeed = 5f;
	public float jumpForce = 1000f;
	public Transform groundCheck;

	// PRIVATE INSTANCE VARIABLES
	private bool grounded = false;
	private Animator anim;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
