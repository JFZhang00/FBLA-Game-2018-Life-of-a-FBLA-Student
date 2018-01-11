using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour {

    public int questNumber;
    public QuestManager qMan;

    public string startText;
    public string finishText;

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartQuest(){
        qMan.ShowQuestText(startText);

    }

    public void EndQuest(){
        qMan.ShowQuestText(finishText);
        qMan.questCompleted[questNumber] = true;
        gameObject.SetActive(false);

    }
}
