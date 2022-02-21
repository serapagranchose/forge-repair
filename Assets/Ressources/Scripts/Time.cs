using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Time : MonoBehaviour {
    
    private GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("Time");
        InvokeRepeating("UpdateTimer", .0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    { 
    }

    void UpdateTimer()
    {
        int actualValue = int.Parse(UI.GetComponent<Text>().text);
        if (actualValue != 0) {
            int value = actualValue - 1;
            UI.GetComponent<Text>().text = value + "";
        } else
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}
