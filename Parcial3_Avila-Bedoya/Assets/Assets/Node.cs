using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node : MonoBehaviour {

    // Use this for initialization

    [SerializeField] protected Node[] children = new Node[0];

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool Execute()
    {
        return true;
          
    }
}
