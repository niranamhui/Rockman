using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    Animator anime;
    Rigidbody2D rb;
    public float speed;


    //private bool checkJump = true;
    public float JumpForce;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumeps;
    public int extraJumepsValue;

    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        extraJumeps = extraJumepsValue;
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(speed, 0, 0);
        anime.SetInteger("Run", 0);


        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        
    }

    void Update()
    {
        if (isGrounded == true)
        {
            extraJumeps = extraJumepsValue;
        }

        if (Input.GetKeyDown(KeyCode.Space) && extraJumeps > 0)
        {
            rb.velocity = Vector2.up * JumpForce;
            extraJumeps--;
            anime.SetInteger("Run", 1);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumeps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * JumpForce;
            anime.SetInteger("Run", 0);
        }

    }

    //private void OnCollisionEnter2D(Collision2D collision)
  //  {
    //    if (collision.gameObject.name == "Floor")
      //  {
       //     checkJump = true;
        //}

//    }
  //  private void OnCollisionExit2D(Collision2D collision)
    //{
      //  if (collision.gameObject.name == "Floor")
        //{
          //  checkJump = false;
       // }

  //  }


}
