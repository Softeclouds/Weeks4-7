using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideShowUI : MonoBehaviour
{
    bool isShowing = true;
    public GameObject panel;
    public Button button;

    public float panelShown;
    public float panelHidden;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = button.transform.position;
        if (isShowing)
        {
            pos.x = panelShown;
        }
        else
        {
            pos.x = panelHidden;
        }
        button.transform.position = pos;
    }

    public void hideShow()
    {
        isShowing = !isShowing;
        panel.SetActive(isShowing);
    }

}



