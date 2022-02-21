using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flying : MonoBehaviour
{
    public float speed;
    public float max;
    public Transform dragon;
    private Vector3 limit; 
    // Start is called before the first frame update
    void Start()
    {
        limit = dragon.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = dragon.localPosition;
        if (limit.y + max >= dragon.localPosition.y && speed >= 0) {
            tmp.y += speed;
            dragon.localPosition = tmp;
        } else if (speed >= 0) {
            tmp.y = limit.y + max;
            dragon.localPosition = tmp;
            speed *= -1;
        }
        if (limit.y - max <= dragon.localPosition.y  && speed <= 0) {
            tmp.y += speed;
            dragon.localPosition = tmp;
        } else if (speed <= 0) {
            tmp.y = limit.y - max;
            dragon.localPosition = tmp;
            speed *= -1;
        }
    }
}
