using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject player;
	public GameObject respawnPoint;
    public GameObject collectable;

	public ParticleSystem winningParticles;

	public Text hud;
    public Text hud2;
	public Canvas gameOverUI;

    //how many times the player dies
    private float deathCount = 0;

    //The amount of ellapsed time
    private float time = 0;

	//Flag that control the state of the game
	private bool isRunning = false;

	// Use this for initialization
	void Start () { InitGame(); }

	// Update is called once per frame
	void Update () {
		if (isRunning) {
			time += Time.deltaTime;

            hud2.text = "Death Count " + deathCount;

            hud.text = "Your time is " + (int)time;

            hud.text = "Your time is " + (int)time;
		} else {
			hud.text = "Your time was " + time;
            hud2.text = "You died " + deathCount + " times";
            
		}

		if(Input.GetButtonDown("Restart")) {
            deathCount = 0;
			RespawnPlayer();
		}
	}

	public void RespawnPlayer() {
		player.gameObject.SetActive(false);
		player.gameObject.transform.position = respawnPoint.transform.position;
		player.gameObject.SetActive(true);

        collectable.gameObject.SetActive(true);
    }

	public void InitGame() {
		time = 0;
		isRunning = true;

		gameOverUI.enabled = false;
		winningParticles.Stop();
		winningParticles.Clear();
		RespawnPlayer();
        deathCount = 0;
	}

	public void Win() {
		isRunning = false;

		gameOverUI.enabled = true;
		winningParticles.Play();
	}
    public void deathCounter()
    {
        deathCount = deathCount + 1;
    }

   
    


}
