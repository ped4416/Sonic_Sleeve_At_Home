using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RunStopChangeText : MonoBehaviour
{
    public TextMeshProUGUI mytext;
    //public mytext = GetComponent<TextMeshPro>();
    public int counter = 0;
    public void changeText()
    {
        counter++;
        if (counter % 2 == 1)
        {
            mytext.color = Color.red;
            mytext.text = "Stop";
        }
        else
        {
            mytext.color = Color.black;
            mytext.text = "Run";
        }
    }
}
