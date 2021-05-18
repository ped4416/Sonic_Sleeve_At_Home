using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTargetPosition : MonoBehaviour
{
    public Rigidbody rigidbody;
    public BoxCollider collider;

    private bool loadedTargetPosition;

    private void Start()
    {
        loadedTargetPosition = StoreTargetPosition.LoadTargetPosition();

        if (loadedTargetPosition)
        {
            Vector3 handPosition = new Vector3();
            handPosition.Set(StoreTargetPosition.l_loadedTargetPosition[0].x, StoreTargetPosition.l_loadedTargetPosition[0].y, StoreTargetPosition.l_loadedTargetPosition[0].z);
            gameObject.transform.position = handPosition;
            //collider.center = handPosition;
            //rigidbody.centerOfMass = handPosition;
            rigidbody.MovePosition(gameObject.transform.position);
            rigidbody.constraints = RigidbodyConstraints.FreezeAll;
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
                //collider.center = handPosition;
                //rigidbody.centerOfMass = handPosition;
                rigidbody.MovePosition(gameObject.transform.position);
                rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}
