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

    //private void OnCollisionEnter(Collision collision) //bug with physics iterfering. try trigger instead 
    private void OnTriggerStay(Collider other) //can use OnTriggerEnter so it runs only once rather than Stay 
    {

    
        if (other.CompareTag("Player"))
        {
            print("HITTTT");
            //StartCoroutine(ColourChangeCoroutine());
            mat = gameObject.GetComponent<Renderer>().material;
            mat.color = Color.green;
        }
    }

    /*IEnumerator ColourChangeCoroutine()
    {
        mat = gameObject.GetComponent<Renderer>().material;
        mat.color = col;
        yield return new WaitForSeconds(1.0f);
        mat.color = Color.white;
    }*/

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("EXIT");
            mat = gameObject.GetComponent<Renderer>().material;
            mat.color = Color.white;
        }
    }
}
