using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject Menu;
    public GameObject aboutMenu;
    public Camera cameraMenu;
    private PlayerController player;

   /* void Awake()
    {
       


    }
*/

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerController>();

        if (player.openMenuNumber < 1)
        {
            cameraMenu.enabled = true;
            Menu.SetActive(true);
            aboutMenu.SetActive(false);
        } else{
            Destroy(Menu);
        }
       
    }


    // Update is called once per frame
    void Update () {
        
	}

    public void PlayGame(){
        Debug.Log("Play Game");
        Menu.SetActive(false);
        cameraMenu.enabled = false;
        player.openMenuNumber++;
    }

    public void AboutMenu(){
        Menu.SetActive(false);
        aboutMenu.SetActive(true);
    }

    public void GoBack(){
        Menu.SetActive(true);
        aboutMenu.SetActive(false);

    }

    public void QuitApplication(){
        Application.Quit();

    }
}
