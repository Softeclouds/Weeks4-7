using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rotator()
    {
        Vector3 rotations = new Vector3(0, 0, slider.value * 360);
        transform.eulerAngles = rotations;
    }
}
