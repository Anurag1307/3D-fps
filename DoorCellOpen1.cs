//Controls the opening of door

using UnityEngine.UI;
using UnityEngine;

public class DoorCellOpen1 : MonoBehaviour {

	public float Distance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject Door;



	void Update () {
		Distance = rayCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (Distance <= 2) {
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}
		if (Input.GetButtonDown("action")) {
			if (Distance <= 2) {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				Door.GetComponent<Animation> ().Play ("FenceDoorLeft");


			}
		}
	}

	void OnMouseExit() {
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
}
