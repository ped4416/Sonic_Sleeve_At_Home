using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IDSetter : MonoBehaviour
{
    public DataTracker dataTracker;
    public TMP_InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        inputField.text = PlayerPrefs.GetString("ID");
    }

    public void SetID()
    {
        dataTracker.ID = inputField.text;
        PlayerPrefs.SetString("ID", (string)dataTracker.ID);
    }
}
