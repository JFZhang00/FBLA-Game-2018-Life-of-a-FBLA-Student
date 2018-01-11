using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuitGame : MonoBehaviour {

    public GameObject QuitPanel;
    public bool QuitOpen;
    public bool quitGameExists;

    void Start()
    {
        QuitPanel.SetActive(false);
        if (!quitGameExists)
        {
            quitGameExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(QuitPanel);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && QuitOpen == false){
            QuitOpen = true;
            QuitPanel.SetActive(true);
        } else if (Input.GetKeyDown(KeyCode.Escape) && QuitOpen == true)
        {
            QuitOpen = false;
            QuitPanel.SetActive(false);
        }

      /*  
        if (Input.GetKeyDown(KeyCode.Escape) && QuitOpen){
            QuitOpen = true;
            QuitPanel.SetActive(true);
        }   
        if (Input.GetKeyDown(KeyCode.Escape) && QuitOpen){
            QuitOpen = false;
            QuitPanel.SetActive(false);
        }
        */
    }

    public void QuitApplication(){
        Debug.Log("Quit Game");
        Application.Quit();

    }
}
