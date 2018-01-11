using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject Menu;
    public GameObject aboutMenu;
    public Camera cameraMenu;
    public PlayerController player;
    public GameUI gameui;
    public bool menubool;


    // Use this for initialization
    void start()
    {

        if (player.openMenuNumber == 0)
        {
            Debug.Log("Opening");
            cameraMenu.enabled = true;
            Menu.SetActive(true);
            aboutMenu.SetActive(false);
        }
        else
        {
            Destroy(Menu);
        }
       
    }


    // Update is called once per frame
    void Update () {
        
	}

    public void PlayGame(){
        player.openMenuNumber++;
        menubool = gameui.gameUIExists;
        gameui.menu.SetActive(menubool);
        Menu.SetActive(false);
        cameraMenu.enabled = false;


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
