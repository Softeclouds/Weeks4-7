using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundDropDown : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] backgroundSprites;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void changeSprite(int index)
    {
        sr.sprite = backgroundSprites[index];
    }
}
