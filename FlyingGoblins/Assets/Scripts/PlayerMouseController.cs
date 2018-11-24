using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseController : MonoBehaviour {

	public float movementSpeed = 5.0f;
    public float minimalDistance = 0.5f;

    public Vector3 finalPosition;

    void Start()
    {
        finalPosition = transform.position;
    }

    void Update()
    {
        //Move();
        if (Input.GetMouseButton(0))
        {
            Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = 0;
            finalPosition = targetPosition;
        }
    }

    private void Move()
    {
        if (Vector3.Distance(finalPosition, transform.position) < minimalDistance)
        {
            finalPosition = transform.position;
            return;
        }
        Vector3 targetPosition = finalPosition;
        targetPosition.Normalize();
        transform.position += targetPosition * movementSpeed * Time.deltaTime;
    }
}
