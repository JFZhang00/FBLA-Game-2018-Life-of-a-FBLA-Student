using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChocolate : MonoBehaviour {

    private PlayerController player;
    private GameUI gameui;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        gameui = FindObjectOfType<GameUI>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay2D(Collider2D collision)
    {
        player.numberOfChocolates = 16;

    }
}
