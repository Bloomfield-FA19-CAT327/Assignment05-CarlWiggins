using UnityEngine;
using System.Collections;

public class Hazard : MonoBehaviour {
	public GameObject respawnPoint;
    public GameController gameController;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
        gameController.deathCounter();


		other.gameObject.SetActive(false);
		other.gameObject.transform.position = respawnPoint.transform.position;
		other.gameObject.SetActive(true);
	}
}
