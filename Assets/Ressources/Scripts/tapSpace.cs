using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tapSpace : MonoBehaviour
{
    private Transform bar;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar");
        bar.localScale = new Vector3(0,1F);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 oldValue = bar.localScale;
        if ( oldValue.x > 0)
            oldValue.x -= .0005F;
        if (Input.GetKeyDown("space") && bar.localScale.x <= 1)
        {
            oldValue.x += .03F;
            bar.localScale = oldValue;
        } else if (bar.localScale.x >= 1) {
            bar.localScale = new Vector3(1F,1F);
            SceneManager.LoadScene("Rouillasse", LoadSceneMode.Single);
            SceneManager.LoadScene("menu", LoadSceneMode.Additive);
            return;
        }
        else
            bar.localScale = oldValue;

    }
}
