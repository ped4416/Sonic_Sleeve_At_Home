using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vec3LowPassFilter : MonoBehaviour
{
    public GameObject dataIn;
    public Vector3 dataOut;
    public float lowPassFactor;
    public bool connectToTransform;

    private bool b_init;
    private Vector3 dataBuffer = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        b_init = true;
    }

    // Update is called once per frame
    void Update()
    {
        dataOut = lowPassFilter(dataIn.transform.position, ref dataBuffer, lowPassFactor, b_init);
        if(connectToTransform)
        {
            dataIn.transform.position = dataOut;
        }
    }

    Vector3 lowPassFilter(Vector3 targetValue, ref Vector3 intermediateValueBuf, float factor, bool init)
    {

        Vector3 intermediateValue;

        //intermediateValue needs to be initialized at the first usage.
        if (init)
        {
            intermediateValueBuf = targetValue;
            b_init = false;
        }

        intermediateValue.x = (targetValue.x * factor) + (intermediateValueBuf.x * (1.0f - factor));
        intermediateValue.y = (targetValue.y * factor) + (intermediateValueBuf.y * (1.0f - factor));
        intermediateValue.z = (targetValue.z * factor) + (intermediateValueBuf.z * (1.0f - factor));

        intermediateValueBuf = intermediateValue;

        return intermediateValue;
    }
}
