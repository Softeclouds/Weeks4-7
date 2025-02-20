using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 pos;

    public collision collisionScript;

    public GameObject CollisionChecker;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;       // Create new Vector2 called pos that is equal to the obejcts position
        //collisionScript = CollisionChecker.GetComponent<collision>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < collisionScript.walls.Length; i++)
        {
            if (Input.GetKey(KeyCode.D))
            {
                if (!collisionScript.walls[i].sprite.bounds.Contains(new Vector3(pos.x + speed, pos.y, 0)))
                {
                    pos.x += speed * Time.deltaTime;
                }
              
            }

            if (Input.GetKey(KeyCode.A))
            {
                if (!collisionScript.walls[i].bounds.Contains(new Vector3(pos.x - speed, pos.y, 0)))
                {
                    pos.x -= speed * Time.deltaTime;
                }
            }
        }

            transform.position = pos;             // the objects position is set to the pos vector
        
    }
}
