using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public DeviceType device_type;
    public string device_name;

    void Start()
    {
        ball = GameObject.Find("ball");
        device_type = SystemInfo.deviceType;
        device_name = SystemInfo.deviceName;
        print(device_type.ToString());
        print(device_name.ToString());
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
