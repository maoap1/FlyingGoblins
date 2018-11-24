using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseController : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Vector3 targetPoint = hit.point;
                targetPoint.z = 0;
                targetPoint.Normalize();
                transform.Translate(targetPoint);
            }


        }
    }
}
