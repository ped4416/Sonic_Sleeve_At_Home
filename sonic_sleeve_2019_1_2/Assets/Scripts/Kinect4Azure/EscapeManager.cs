using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
            print("QUIT APPLICATION NOW ESC BUTTON");
            Debug.Log("Text TEST QUIT");
        }
    }
}
