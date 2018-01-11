using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBuys : MonoBehaviour {

    private PlayerController player;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.numberOfChocolates -= 4;
        player.money += 4;
    }




    

    
}
