using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;

    void Start()
    {
        ball = GameObject.Find("ball");
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButton(0) )
        {
            ball.SetActive(false);
        }
        else if ( Input.GetMouseButton(1) )
        {
            ball.SetActive(true);
        }
    }
}
