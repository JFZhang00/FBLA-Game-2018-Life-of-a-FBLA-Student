using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour {

    private QuestManager qMan;
    public int questNumber;
    public bool startQuest;
    public bool endQuest;

	// Use this for initialization
	void Start () {
        qMan = FindObjectOfType<QuestManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("COllision");
        if (collision.gameObject.name == "Player" && !qMan.questCompleted[questNumber]){
                if (startQuest && !qMan.quests[questNumber].gameObject.activeSelf){
                    qMan.quests[questNumber].gameObject.SetActive(true);
                    qMan.quests[questNumber].StartQuest();
                   
                }
                 if (startQuest && qMan.quests[questNumber].gameObject.activeSelf)
                 {
                qMan.quests[questNumber].gameObject.SetActive(true);
                qMan.quests[questNumber].EndQuest();

                  }
               
            

        }
    }
}
