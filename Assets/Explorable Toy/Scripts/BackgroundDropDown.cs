using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundDropDown : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] backgroundSprites;

    public void changeSprite(int index)
    {
        // change sprites based on the index in the array to switch between the options
        sr.sprite = backgroundSprites[index];
    }
}
