//basic usage of collision triggers

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mount1 : MonoBehaviour {
    public GameObject objective002;
    public GameObject objective003;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        objective002.SetActive(false);
        objective003.SetActive(true);
    }
}
