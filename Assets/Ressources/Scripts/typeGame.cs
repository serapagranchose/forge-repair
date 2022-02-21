using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class typeGame : MonoBehaviour
{
    public string enchant = "test";
    public Text display;
    private int pos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string input = Input.inputString;
        char lastChar = 'a';
        if ( input != "") {
            lastChar = input[input.Length - 1];
            if (lastChar != enchant[pos]) {
                Debug.Log("lol");
                display.text = "";
                pos = 0;
            } else {
                display.text += input;
                pos++;
            }
            if ( input == enchant) {
                Debug.Log("win");
            }
        }
    }
}