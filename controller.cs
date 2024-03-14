using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public DeviceType device;

    void Start()
    {
        ball = GameObject.Find("ball");
        device = SystemInfo.deviceType;
        print(device.ToString());
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
