using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour {
    
    public NavMeshAgent nav;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    void OnMouseDown()
    {
        nav.SetDestination(this.transform.position);
    }
}
