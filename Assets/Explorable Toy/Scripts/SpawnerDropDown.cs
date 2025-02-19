using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnerDropDown : MonoBehaviour
{
    bool isShowing = true;

    public bool isFlipped = false;

    public GameObject[] items;
    private GameObject currentItem;
    public Slider slider;

    public TextMeshProUGUI layerText;

    private SpriteRenderer sprite;
    private GameObject previewItem;
    private SpriteRenderer previewSprite;

    public Slider timer;

    private List<GameObject> placedItems = new List<GameObject>();

    float t = 0f;
    public float timerT;
    bool isClearing = false;

    void Start()
    {
        currentItem = items[0]; // start the currentItem at the first option
        showPreview(); // show the preview

    }

    void Update()
    {
        layerText.text = "Layer: " + slider.value; // shows the text with the layer value

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        if (previewItem != null)
        {
            // set the preview item to follow the mouse position
            previewItem.transform.position = mousePos;

      
        }

        // if the rmb is pressed place an item at the mouse position
        if (Input.GetMouseButtonDown(1))
        {
            placeItem(mousePos);
        }

        if (isClearing)
        {
            t += Time.deltaTime;
            timer.value = t % timer.maxValue; // Update the slider according to the time

            if (t >= timerT) // After the timer is up, clear objects
            {
                foreach (GameObject item in placedItems) // looping over all items in the list to destroy themif
                {
                    Destroy(item);
                }

                placedItems.Clear(); // Clear the list
                isClearing = false; // Stop clearing
            }
        }
    }

    public void changeItem(int index)
    {
        // sets the currentItem to the item in the array with that index
        currentItem = items[index];

        showPreview(); // showing preview again to change the drawn preview sprite
    }

    void showPreview() // Showing a preview of what the spawned item would look like
    {
        if (previewItem != null) // if there is already a preview, destroy it
        {
            Destroy(previewItem);
        }

        // draw the previewed item with the correct sprite
        // the showPreview function isnt constantly so we cant update its postition here
        previewItem = Instantiate(currentItem, Vector3.zero, Quaternion.identity);

        previewSprite = previewItem.GetComponent<SpriteRenderer>();
        // draw the preview on the sorting layer according to the slider
        previewSprite.sortingOrder = (int)slider.value;
    }

    void placeItem(Vector3 pos) // a vector3 is fed into this function to determine where its placed
    {
        GameObject placedItem = Instantiate(currentItem, pos, Quaternion.identity); // instantiate item
       
        SpriteRenderer placedSprite = placedItem.GetComponent<SpriteRenderer>(); // getting the sprite renderer from the current placed item
        placedSprite.sortingOrder = (int)slider.value; // drawing the sprite in the correct layer according to the slider

        placedSprite.flipX = isFlipped; // flip x if the toggle is triggered

        placedItems.Add(placedItem); // add item to list so it can be destroyed later
    }

    // update the sprite previews sorting layer if the slider value has changed
    public void OnSliderValueChanged(float value)
    {
        if (previewSprite != null)
        {
            previewSprite.sortingOrder = (int)value;
        }
    }

    // stop drawing the preview if the UI panel is hidden
    public void disablePreview()
    {
        isShowing = !isShowing;
        if(!isShowing)
        {
            Destroy(previewItem);
        }
        else
        {
            showPreview();
        }
    }

    public void clearAll()
    {
        t = 0f; // Reset the timer
        isClearing = true; // Start the timer to clear items
    }

    public void flipX()
    {
        isFlipped = !isFlipped;
        
        if (previewSprite != null)
        {
            previewSprite.flipX = isFlipped; // flip x if the toggle is triggered
        }
    }


}
