using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactions : MonoBehaviour
{
    public GameObject Reaction;
    public Transform player;
    public Transform objects;
    // Start is called before the first frame update
    void Start()
    {
        Reaction.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = player.position;
        Vector2 objectPos = objects.position;
        if (playerPos.x >= objectPos.x - 1 && playerPos.x <= objectPos.x + 1 && playerPos.y >= objectPos.y - 1 && playerPos.y <= objectPos.y + 1)
        {
            Reaction.SetActive(true);
        }
        else
        {
            Reaction.SetActive(false);
        }
    }
}
