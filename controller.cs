using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

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
        if(Input.touchCount == 1)
        {
            ball.SetActive(false);
        }
        else
        {
            ball.SetActive(true);
        }
        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        ball.SetActive(true);
    }
}
