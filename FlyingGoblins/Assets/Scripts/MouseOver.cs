using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour {

	public float scalingConstant = 1.1f;

    private Vector3 oldScale;
    private Vector3 newScale;

    // Use this for initialization
    void Start()
    {
        oldScale = transform.localScale;
        newScale = new Vector3(oldScale.x * scalingConstant, oldScale.y * scalingConstant, oldScale.z);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        transform.localScale = newScale;
    }
    void OnMouseExit()
    {
        transform.localScale = oldScale;
    }
}
