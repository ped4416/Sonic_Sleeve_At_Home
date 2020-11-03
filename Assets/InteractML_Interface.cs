using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;

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
            //find tran the machine node
          //model.MLController.nodes.
        }
    }
}
