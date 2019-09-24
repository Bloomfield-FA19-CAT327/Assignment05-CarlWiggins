using UnityEngine;

public class Hazard2 : MonoBehaviour {
	private GameController gameControler;

	void Start () {
//        gameControler = GameObject.Find("GameController").GetComponent<GameController>();
        gameControler = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}
	
	void OnTriggerEnter(Collider other) { gameControler.RespawnPlayer(); }
}
