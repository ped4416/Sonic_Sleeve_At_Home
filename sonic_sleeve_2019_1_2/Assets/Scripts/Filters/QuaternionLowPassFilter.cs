using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionLowPassFilter : MonoBehaviour
{
    public GameObject dataIn;
    //public Quaternion dataOut;
    //public float lowPassFactor;
    //public bool connectToTransform;
    public Quaternion rawDataOut;

    //private bool init;
    //private Quaternion dataBuffer;

    // Start is called before the first frame update
    void Start()
    {
        //Initialization done once:
        //lowPassFactor = 0.8f; //Value should be between 0.01f and 0.99f. Smaller value is more damping.
        //init = true;
        //dataBuffer = new Quaternion();
    }

    // Update is called once per frame
    void Update()
    {
        rawDataOut = dataIn.transform.rotation;

        //TODO:Quaternion filter currently not working
        /*dataOut = lowPassFilterQuaternion(dataIn.transform.rotation, ref dataBuffer, lowPassFactor, init);
        if(connectToTransform)
        {
            dataIn.transform.rotation = dataOut;
        }*/
    }
 
    /*Quaternion lowPassFilterQuaternion(Quaternion targetValue, ref Quaternion intermediateValueBuf, float factor, bool init)
    {
        Quaternion calculatedVal;

        //intermediateValue needs to be initialized at the first usage.
        if (init)
        {
            intermediateValueBuf = targetValue;
            init = false;
        }

        calculatedVal = Quaternion.Lerp(intermediateValueBuf, targetValue, factor);

        intermediateValueBuf = calculatedVal;

        return calculatedVal;
    }*/
}
