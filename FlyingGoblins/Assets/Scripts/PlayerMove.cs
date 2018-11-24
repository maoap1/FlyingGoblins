using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    float horizontal;
    float vertical;
    public float MaxSpeed = 10f;
    public float MovementSpeed;
    PlayerStats playerStats;

	// Use this for initialization
	void Start () {
        playerStats = GetComponent<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
        MovementSpeed = MaxSpeed * playerStats.stamina;
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 vector = new Vector3(horizontal, vertical,0);
        transform.position += vector * MovementSpeed * Time.deltaTime;
        

	}
}
