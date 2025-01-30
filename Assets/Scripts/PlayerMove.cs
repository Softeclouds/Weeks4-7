using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;       // Create new Vector2 called pos that is equal to the obejcts position
        if (Input.GetKey(KeyCode.D))            // if either D, A, W, or S are pressed, move character accordingly with speed
        {
            pos.x += speed * Time.deltaTime;    // Time.deltaTime is used to keep the movement consistent, instead of using the framerate, which could cause inconsistent movement
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }

        transform.position = pos;             // the objects position is set to the pos vector
    }
}
