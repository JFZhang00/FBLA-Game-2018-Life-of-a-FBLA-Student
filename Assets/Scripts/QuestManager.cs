using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class QuestManager : MonoBehaviour {

    public QuestObject[] quests;
    public bool[] questCompleted;

    public DialogueManager dMan;



	// Use this for initialization
	void Start () {
        questCompleted = new bool[quests.Length];
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowQuestText(string questText){

        dMan.dialogueLines = new string[1];
        dMan.dialogueLines[0] = questText;

        dMan.currentLine = 0;
        dMan.ShowDialogue();

    }
}
