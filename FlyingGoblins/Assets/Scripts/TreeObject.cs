using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeObject : MonoBehaviour {

    public float scalingConstant = 1.1f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnMouseDown()
    {
        transform.localScale += new Vector3(transform.localScale.x * scalingConstant,
                                            transform.localScale.y * scalingConstant,
                                            0);
    }
}
