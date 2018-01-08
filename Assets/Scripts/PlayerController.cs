using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public float speed = 5f;
    private Rigidbody2D rb;
    private DialogueManager dMan;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        dMan = FindObjectOfType<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");


        if (moveHorizontal > 0.5f || moveHorizontal < -0.5f)
        {
            //transform.Translate(new Vector3(moveHorizontal * moveSpeed * Time.deltaTime, 0f, 0f));
            rb.velocity = new Vector2(moveHorizontal * speed * Time.deltaTime, rb.velocity.y);
        }
        if (moveVertical > 0.5f || moveVertical < -0.5f)
        {
            //transform.Translate(new Vector3(0f, moveVertical * moveSpeed * Time.deltaTime, 0f));
            rb.velocity = new Vector2(rb.velocity.x, moveVertical * speed * Time.deltaTime);
      
        }

        if (moveHorizontal < 0.5f && moveHorizontal > -0.5f)
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);

        }
        if (moveVertical < 0.5f && moveVertical > -0.5f)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);

        }

        if(dMan.dialogueActive){
            rb.velocity = Vector2.zero;

        }
    
	}
}
