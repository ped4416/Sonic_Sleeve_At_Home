using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;

/// <summary>
/// This class will receive commands from the Sonic Sleeve GUI and call the relevant 
/// interactML methods.
/// </summary>
public class InteractML_Interface : MonoBehaviour
{

    public IMLComponent model;
    public IMLTrainingExamplesUI trainingNode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r"))
        {
            //find train the machine node
          //model.MLController.nodes.
        }
    }
}
