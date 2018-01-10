using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {

    private PlayerController player;
    private CameraController theCamera;

    public string pointName;


    // Use this for initialization
    void Start () {
        player = FindObjectOfType<PlayerController>();
        theCamera = FindObjectOfType<CameraController>();
       if (pointName == player.startPoint)
       {
            Debug.Log("Changing");
            player.transform.position = gameObject.transform.position;
            theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
       }

     }
	
	// Update is called once per frame
	void Update () {
        
        
	}
}
