using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTargetPosition : MonoBehaviour
{
    private bool loadedTargetPosition;

    private void Start()
    {
        loadedTargetPosition = StoreTargetPosition.LoadTargetPosition();
        if (loadedTargetPosition)
        {
            Vector3 handPosition = new Vector3();
            handPosition.Set(StoreTargetPosition.l_loadedTargetPosition[0].x, StoreTargetPosition.l_loadedTargetPosition[0].y, StoreTargetPosition.l_loadedTargetPosition[0].z);
            gameObject.transform.position = handPosition;
            /*gameObject.GetComponent<BoxCollider>().center = handPosition;
            gameObject.GetComponent<Rigidbody>().centerOfMass = handPosition;*/
            float scaleVal = 0.2f;
            Vector3 scale = new Vector3();
            scale.Set(scaleVal, scaleVal, scaleVal);
            gameObject.transform.localScale = scale;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            loadedTargetPosition = StoreTargetPosition.LoadTargetPosition();
            if (loadedTargetPosition)
            {
                Vector3 handPosition = new Vector3();
                handPosition.Set(StoreTargetPosition.l_loadedTargetPosition[0].x, StoreTargetPosition.l_loadedTargetPosition[0].y, StoreTargetPosition.l_loadedTargetPosition[0].z);
                gameObject.transform.position = handPosition;
                /*gameObject.GetComponent<BoxCollider>().center = handPosition;
                gameObject.GetComponent<Rigidbody>().centerOfMass = handPosition;*/
                float scaleVal = 0.2f;
                Vector3 scale = new Vector3();
                scale.Set(scaleVal, scaleVal, scaleVal);
                gameObject.transform.localScale = scale;
            }
        }
    }
}
