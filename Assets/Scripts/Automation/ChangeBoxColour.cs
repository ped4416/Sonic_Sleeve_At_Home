using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBoxColour : MonoBehaviour
{
    private Material mat;
    private Color col = new Color();
     
    // Start is called before the first frame update
    void Start()
    {
        col = Color.red;
    }

    private void OnCollisionEnter(Collision collision)
    {
        mat = gameObject.GetComponent<Renderer>().material;
        mat.color = col;
    }

    private void OnCollisionExit(Collision collision)
    {
        mat = gameObject.GetComponent<Renderer>().material;
        mat.color = Color.white;
    }
}
