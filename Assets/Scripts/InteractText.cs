using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractText : MonoBehaviour
{
    public GameObject interactText;
    public Transform player;
    public Transform chest;

    // Start is called before the first frame update
    void Start()
    {
        interactText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = player.position;
        Vector2 chestPos = chest.position;
        if(playerPos.x >= chestPos.x -1 && playerPos.x <= chestPos.x+1 && playerPos.y >= chestPos.y -1 && playerPos.y <= chestPos.y+1)
        {
            interactText.SetActive(true);
        }
        else
        {
            interactText.SetActive(false);
        }
    }
}
