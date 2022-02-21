using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rouille : MonoBehaviour
{
    // Start is called before the first frame update
    float blue = 0;
    float green = 0;
    float red = 0;
    Color newColor = new Color(1, 1, 1, 1);
    public Color toFindColor;

    
    void Start()
    {
        int _red = Random.Range(0, 2);
        int _green = Random.Range(0, 2);
        int _blue = _red == _green ? (_red == 0 ? 1 : 0) : Random.Range(0, 2);

        toFindColor = new Color(
            _red, 
            _green, 
            _blue,
            1
        );
        GameObject go = GameObject.FindGameObjectWithTag("ToFind");
        var cubeRenderer = go.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", toFindColor);
    }

    void changeColor()
    {
        if (red == 0 && green == 0 && blue == 0)
            newColor = new Color(1, 1, 1, 1);
        else
            newColor = new Color(red, green, blue, 1);
        GameObject go = GameObject.FindGameObjectWithTag("Color");
        var cubeRenderer = go.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", newColor);
    }

    void updateBlue() {
        GameObject go = GameObject.FindGameObjectWithTag("ColorBlue");
        var cubeRenderer = go.GetComponent<Renderer>();
        if (blue == 1)
            cubeRenderer.material.SetColor("_Color", new Color(0, 0, blue, 1));
        else
            cubeRenderer.material.SetColor("_Color", new Color(1, 1, 1, 1));

    }

    void updateGreen() {
        GameObject go = GameObject.FindGameObjectWithTag("ColorGreen");
        var cubeRenderer = go.GetComponent<Renderer>();
        if (green == 1)
            cubeRenderer.material.SetColor("_Color", new Color(0, green, 0, 1));
        else
            cubeRenderer.material.SetColor("_Color", new Color(1, 1, 1, 1));
    }

    void updateRed() {
        GameObject go = GameObject.FindGameObjectWithTag("ColorRed");
        var cubeRenderer = go.GetComponent<Renderer>();
        if (red == 1)
            cubeRenderer.material.SetColor("_Color", new Color(red, 0, 0, 1));
        else
            cubeRenderer.material.SetColor("_Color", new Color(1, 1, 1, 1));
    }

    // Update is called once per frame
    void Update()   
    {
        if (newColor.Equals(toFindColor) == false) {
            if (Input.GetKeyDown("a")) {
                blue = blue == 0 ?  1 : 0;
                updateBlue();
                changeColor();
            } else if (Input.GetKeyDown("z")) {
                green = green == 0 ?  1 : 0;
                updateGreen();
                changeColor();
            } else if (Input.GetKeyDown("e")) {
                red = red == 0 ?  1 : 0;
                updateRed();
                changeColor();
            } else if (Input.GetKeyDown("r")) {
                blue = red = green = 0;
                updateRed();
                updateGreen();
                updateBlue();
                changeColor();
            }
        } else
            SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }
}
