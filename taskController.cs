using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class taskController : MonoBehaviour {
    public GameObject Task;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("task"))
        {
            Task.SetActive(true);
        }
        if (Input.GetButtonUp("task"))
        {
            Task.SetActive(false);
        }

    }
    
}
