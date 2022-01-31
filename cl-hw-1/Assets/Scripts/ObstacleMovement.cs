using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    //decalre/set random x number to change speed each time obstacle resets
    public int xRandom = 1;

    //set speed of the oobstacle
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move obstacle to the left
        transform.position += Vector3.left * speed * Time.deltaTime * xRandom;

        //when obstacle moves off screen reset back to beginning with new x speed
        //and y position
        if (transform.position.x < -10)
        {
            xRandom = Random.Range(1, 5);
            var yRandom = Random.Range(0f, 3f);
            transform.position =  new Vector3(10, yRandom, 0);
        }
    }
}
