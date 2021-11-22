using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;


    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;


    public int extraJumps;
    public int extraJumpsValue;


    private Animator anim;

    void Start(){
	anim = GetComponent<Animator>();
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate(){

	isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);


        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    

    }

    void Update(){

        if(moveInput > 0){
            anim.SetInteger("is left or right", 1);
	} else if(moveInput < 0){
            anim.SetInteger("is left or right", -1);
	}

        if (moveInput == 0) {
            anim.SetBool("is running", false);
} else {
            anim.SetBool("is running", true);
}

        if(isGrounded == true){
             extraJumps = extraJumpsValue;
}

        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0){
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        } else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0 && isGrounded == true){
            rb.velocity = Vector2.up * jumpForce;
        }        if(Input.GetKeyDown(KeyCode.Space) && extraJumps > 0){
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        } else if(Input.GetKeyDown(KeyCode.Space) && extraJumps > 0 && isGrounded == true){
            rb.velocity = Vector2.up * jumpForce;
        }
    }

}
