using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public int health = 10;
    public float boundry = 1;
    public Transform enemy;
    public GameObject enemyOb;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Health: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 enemyPos = enemy.position;

        if (mousePos.x >= enemyPos.x - boundry && mousePos.x <= enemyPos.x + boundry && mousePos.y >= enemyPos.y - boundry && mousePos.y <= enemyPos.y + boundry)
        {
            Debug.Log("Mouse over");
          if (Input.GetMouseButtonDown(0))
          {
                health = health - 1;
                text.text = "Health: " + health;
          }
        }

        if(health <= 0)
        {
            Destroy(enemyOb);
        }
        
    }
}
