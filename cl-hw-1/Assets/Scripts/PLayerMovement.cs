using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    public GameObject player;
    public KeyCode jump;
    public KeyCode left;
    public KeyCode right;

    private Rigidbody rb2D;

    public float jumpAmount = 10;


    // Start is called before the first frame update
    void Start()
    {
        //Get player rigidbody
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody rb = player.GetComponent<Rigidbody>();

        if (Input.GetKeyDown(jump))
        {
            Debug.Log("Jump key is pressed");
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            
        }


    }

    void Jump()
    {
        rb.velocity = 
    }
}
