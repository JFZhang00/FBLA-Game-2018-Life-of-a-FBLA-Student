using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public GameObject menu;
    public Text value;
    public Text NumberOfChocolates;
    private PlayerController player;
    public bool gameUIExists;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        if (!gameUIExists)
        {
            gameUIExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

       

	}
	
	// Update is called once per frame
	void Update () {
        value.text = player.money.ToString();
        NumberOfChocolates.text = player.numberOfChocolates.ToString();

	}
}
