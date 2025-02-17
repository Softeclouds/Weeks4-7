using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HideShowUI : MonoBehaviour
{
    bool isShowing = true;
    public GameObject panel;
    public TextMeshProUGUI buttonText;

    public float panelShown;
    public float panelHidden;

    void Update()
    {
        if (isShowing)
        {
            buttonText.text = "Hide UI";
        }
        else
        {
            buttonText.text = "Show UI";
        }

    }
    public void hideShow()
    {
        isShowing = !isShowing;
        panel.SetActive(isShowing);
    }

}



