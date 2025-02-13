using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankMove : MonoBehaviour
{
    public float speed;
    public Slider speedSlider;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = speedSlider.value;
        Vector2 pos = transform.position;       // Create new Vector2 called pos that is equal to the obejcts position
        if (Input.GetKey(KeyCode.D))            // if either D, A, W, or S are pressed, move character accordingly with speed
        {
            pos.x += speed * Time.deltaTime;    // Time.deltaTime is used to keep the movement consistent, instead of using the framerate, which could cause inconsistent movement
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;             // the objects position is set to the pos vector
    }
}
