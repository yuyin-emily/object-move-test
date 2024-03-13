using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButton(0) )
        {
            this.gameObject.SetActive(false);
        }
        else if ( Input.GetMouseButton(1) )
        {
            this.gameObject.SetActive(true);
        }
    }
}
