using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    public GameObject player;

    //add controls
    public KeyCode jump;
    private Rigidbody2D rb2d;
    private BoxCollider2D call;
    public float jumpAmount = 10;
    [SerializeField] private LayerMask ground;
    private bool doubleJump;


    // Start is called before the first frame update
    void Awake()
    {
        //Get player rigidbody
        rb2d = player.GetComponent<Rigidbody2D>();

        //get the player collider
        call = player.GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Controls();
    }


    void Controls()
    {
        //reset double jump when player hits ground
        if (IsGrounded())
        {
            doubleJump = true;
        }

        //use Unity Input Controller API and get the Horizontal controller
        float dirX = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(dirX * 7f, rb2d.velocity.y);


        //player double jump
        if (Input.GetKeyDown(jump))
        {
            if (IsGrounded())
            {
                rb2d.velocity = Vector2.up * jumpAmount;
            }
            else
            {
                if (doubleJump)
                {
                    rb2d.velocity = Vector2.up * jumpAmount;
                    doubleJump = false;
                }
            }
        }
    }

    private bool IsGrounded()
    {
       return Physics2D.BoxCast(call.bounds.center, call.bounds.size, 0f, Vector2.down, .1f, ground);
    }
}
