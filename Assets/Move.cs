using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb; 
    private bool moveLeft; 
    private bool moveRight;
    private bool moveDown; 
    private bool moveUp; 
    private Animator animator;

    

    private float horizontalMove;
    private float verticalMove; 
    public float speed = 5; 

    private void Awake()
    {
        animator = GetComponent<Animator>(); 
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        moveLeft = false; 
        moveRight = false; 
    }

    public void PointerDownLeft()
    {
        moveLeft = true; 
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }

    public void PointerUpRight()
    {
        moveRight = false; 
    }

    public void PointerUpUp() { moveUp = false; }
    public void PointerDownUp(){ moveUp = true; }
    public void pointerDownDown(){ moveDown = true; }
    public void PointerUpDown(){ moveDown = false; }

    // Update is called once per frame
    void Update()
    {
        MovePlayer (); 
    }

    private void MovePlayer()
    {
        if(moveLeft) {
            horizontalMove = - speed; 
            animator.SetFloat("moveX", -1); 
            animator.SetFloat("moveY", 0); 
            animator.SetBool("isMoving", true); 
        }
        else if(moveRight) {
            horizontalMove = speed;
            animator.SetFloat("moveX", 1); 
            animator.SetFloat("moveY", 0);
            animator.SetBool("isMoving", true); 
        }
        else if(moveUp){ 
            verticalMove = speed;
            animator.SetFloat("moveX", 0); 
            animator.SetFloat("moveY", -1);
            animator.SetBool("isMoving", true); 
        }
        else if(moveDown) {
            verticalMove = -speed; 
            animator.SetFloat("moveX", 0); 
            animator.SetFloat("moveY", 1);
            animator.SetBool("isMoving", true); 

        }
        else{
            horizontalMove = 0; 
            verticalMove = 0; 
            animator.SetBool("isMoving", false); 
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, verticalMove); 
    }
    
}
