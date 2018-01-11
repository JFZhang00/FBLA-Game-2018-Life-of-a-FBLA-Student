using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    
    public float speed = 5f;
    private Rigidbody2D rb;
    private DialogueManager dMan;
    private Animator anim;
    private static bool playerExists;
    private bool playerMoving;
    private Vector2 lastMove;
    private QuitGame QuitMenu;
    public int openMenuNumber;
    public bool isPause;
    private MainMenu mainMenu;

    public int money;
    public int numberOfChocolates;


    public string startPoint;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        dMan = FindObjectOfType<DialogueManager>();
        anim = GetComponent<Animator>();
        QuitMenu = FindObjectOfType<QuitGame>();
        mainMenu = FindObjectOfType<MainMenu>();
        openMenuNumber = 0;

        if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        } else {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        playerMoving = false;
        isPause = QuitMenu.QuitOpen;

        if (openMenuNumber == 1){
            Destroy(mainMenu.Menu);
        } else {
            DontDestroyOnLoad(mainMenu.Menu);
        }
      

        if (moveHorizontal > 0.5f || moveHorizontal < -0.5f)
        {
            playerMoving = true;
            lastMove = new Vector2(moveHorizontal * Time.deltaTime, 0f);
            rb.velocity = new Vector2(moveHorizontal * speed * Time.deltaTime, rb.velocity.y);
        }
        if (moveVertical > 0.5f || moveVertical < -0.5f)
        {
            playerMoving = true;
            lastMove = new Vector2(0f, moveVertical * Time.deltaTime);
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


        if (isPause){
            rb.velocity = Vector2.zero;

        }

      
            anim.SetFloat("MoveX", moveHorizontal * Time.deltaTime);
            anim.SetFloat("MoveY", moveVertical * Time.deltaTime);
            anim.SetBool("PlayerMoving", playerMoving);
            anim.SetFloat("LastMoveX", lastMove.x * Time.deltaTime);
            anim.SetFloat("LastMoveY", lastMove.y * Time.deltaTime);
        
	}

}
