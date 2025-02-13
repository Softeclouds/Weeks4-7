using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBodyDropDown : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] tankSprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void changeSprite(int index)
    {
     sr.sprite = tankSprites[index];
    }
}
