using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TenSecTimer : MonoBehaviour
{
    public OnTenRepsListener tenRepsListener;
    // Start is called before the first frame update
    void Start()
    {
        tenRepsListener.Response.AddListener(Begin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Begin()
    {
        print("10 second timer start!");
    }
}
