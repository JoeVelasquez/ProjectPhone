using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeCircle : MonoBehaviour {

    public AudioClip warningClip;
    public AudioSource warningSource;

	// Use this for initialization
	void Start () {
        warningSource.clip = warningClip;
	}

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Monster Entered the SafeCircle");
        warningSource.Play();
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Monster is within SafeCircle");        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Monster Exited the SafeCircle");
    }
}
