using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    float horizontal;
    float vertical;
    public float maxSpeed = 10.0f;
    public float movementSpeed = 10.0f;
    PlayerStats playerStats;
    Animator animator;

	// Use this for initialization
	void Start ()
    {
        playerStats = GetComponent<PlayerStats>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        movementSpeed = maxSpeed * playerStats.stamina;
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        animator.SetBool("Left", horizontal < 0);
        animator.SetBool("Right", horizontal > 0);
        animator.SetBool("Up", vertical > 0);
        animator.SetBool("Down", vertical < 0);

        Vector3 vector = new Vector3(horizontal, vertical, 0);
        transform.position += vector * movementSpeed * Time.deltaTime;
        
	}
}
