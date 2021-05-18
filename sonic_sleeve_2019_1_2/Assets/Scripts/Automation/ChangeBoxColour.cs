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
        col = Color.green;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("HITTTT");
        StartCoroutine(ColourChangeCoroutine());
    }

    IEnumerator ColourChangeCoroutine()
    {
        mat = gameObject.GetComponent<Renderer>().material;
        mat.color = col;
        yield return new WaitForSeconds(1.0f);
        mat.color = Color.white;
    }    

    /*private void OnCollisionExit(Collision collision)
    {
        print("EXIT");
        mat = gameObject.GetComponent<Renderer>().material;
        mat.color = Color.white;
    }*/
}
