using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    //this will allow us to use methods from the game controller
    public GameController gameController;
    public GameObject collectable;
    public GameObject winWall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        collectable.gameObject.SetActive(false);
        winWall.gameObject.SetActive(false);
        
        
    }
}
