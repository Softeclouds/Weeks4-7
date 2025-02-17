using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerDropDown : MonoBehaviour
{
    public GameObject[] items;
    private GameObject currentItem;
    public Slider slider;
    private SpriteRenderer sprite;



    // Start is called before the first frame update
    void Start()
    {
        currentItem = items[0];

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        if (Input.GetMouseButtonDown(1))
        {
            GameObject spawnedItems = Instantiate(currentItem, mousePos, Quaternion.identity);
        }
    }

    public void changeItem(int index)
    {
        currentItem = items[index];
    }
}
