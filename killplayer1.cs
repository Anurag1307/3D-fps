using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class killplayer : MonoBehaviour {
    public Image health;
    public float Health=1.0f;
	// Use this for initialization
	void Start () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("enemy"))
        {
            Health -= 0.1f;
            health.fillAmount = Health;
            if (Health <= 0)
            {
                Destroy(gameObject);

                SceneManager.LoadScene("GameOver");
            }

        }
        if (col.gameObject.tag.Equals("hammer"))
        {
            Health -= 0.4f;
            health.fillAmount = Health;
            if (Health <= 0)
            {
                Destroy(gameObject);

                SceneManager.LoadScene("GameOver");
            }

        }

    }
        // Update is called once per frame
        void Update () {
		
	}
}
