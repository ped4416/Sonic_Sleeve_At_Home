using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionLowPassFilter : MonoBehaviour
{
    public GameObject dataIn;
    public Quaternion dataOut;
    public float lowPassFactor;

    private bool init;
    private Quaternion prevData;

    // Start is called before the first frame update
    void Start()
    {
        //Initialization done once:
        lowPassFactor = 0.8f; //Value should be between 0.01f and 0.99f. Smaller value is more damping.
        init = true;
        prevData = new Quaternion();
    }

    // Update is called once per frame
    void Update()
    {
        //Called every frame:
        dataOut = lowPassFilterQuaternion(prevData, dataIn.transform.rotation, lowPassFactor, init);
        prevData = dataOut;

    }
 
    Quaternion lowPassFilterQuaternion(Quaternion intermediateValue, Quaternion targetValue, float factor, bool init)
    {
        //intermediateValue needs to be initialized at the first usage.
        if (init)
        {
            intermediateValue = targetValue;
            init = false;
        }

        intermediateValue = Quaternion.Lerp(intermediateValue, targetValue, factor);
        return intermediateValue;
    }
}
