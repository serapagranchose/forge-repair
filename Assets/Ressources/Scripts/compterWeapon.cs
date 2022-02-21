using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class compterWeapon : MonoBehaviour
{

    private GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("Weapon");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w")) {
            int value = int.Parse(UI.GetComponent<Text>().text) + 1;
            UI.GetComponent<Text>().text = value + "";
        }
    }
}
