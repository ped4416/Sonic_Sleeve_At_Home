using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveArmSelection : MonoBehaviour
{

    public GameObject dropbox;

    private int i_val;

    // Start is called before the first frame update
    void Start()
    {
        dropbox.GetComponent<TMP_Dropdown>().value = PlayerPrefs.GetInt("Arm Dropdown");
        print(dropbox.GetComponent<TMP_Dropdown>().value);
    }

    public void SaveState()
    {
        i_val = dropbox.GetComponent<TMP_Dropdown>().value;
        PlayerPrefs.SetInt("Arm Dropdown", i_val);
    }
}
