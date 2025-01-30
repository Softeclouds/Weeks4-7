using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public SpriteRenderer sr;
    public EnableDisable script;
    public GameObject menu;
    public AudioSource audioS;
    public AudioClip clip;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            sr.enabled = false;
            //script.enabled = false;
            menu.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = true;
            //script.enabled = true;
            menu.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if(audioS.isPlaying == false)
            {
                //audioS.Play();
                audioS.PlayOneShot(clip);
            }
            
        }
    }
}
