using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spamBar : MonoBehaviour
{
    public GameObject slider;
    private Slider tmpslider;
    // Start is called before the first frame update
    void Start()
    {
        tmpslider = slider.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            tmpslider.value += 5;
        }
    }
}
