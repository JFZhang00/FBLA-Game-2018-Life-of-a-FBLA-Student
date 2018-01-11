using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestObject : MonoBehaviour {

    public int questNumber;
    public QuestManager qMan;

    public string startText;
    public string finishText;
    public EndMenu EndMenu;
    private PlayerController player;

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        player = FindObjectOfType<PlayerController>();
	}

    public void StartQuest(){
        qMan.ShowQuestText(startText);

    }

    public void EndQuest(){
        if (player.money >= 16)
        {
            qMan.ShowQuestText(finishText);
            qMan.questCompleted[questNumber] = true;
            gameObject.SetActive(false);
            SceneManager.LoadScene("EndScene");
        }

    }
}
