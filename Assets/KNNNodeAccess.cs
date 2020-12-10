using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;
using InteractML.DataTypeNodes;

public class KNNNodeAccess : MonoBehaviour
{
    private IMLConfiguration configNode;
    private TrainingExamplesNode trainingNode;

    public void KNNRecord()
    {
        trainingNode = gameObject.GetComponent<IMLComponent>().TrainingExamplesNodesList[0];
        trainingNode.ToggleCollectExamples();
    }

    public void KNNTrain()
    {
        configNode = gameObject.GetComponent<IMLComponent>().IMLConfigurationNodesList[0];
        configNode.TrainModel();
    }

    public void KNNRun()
    {
        configNode = gameObject.GetComponent<IMLComponent>().IMLConfigurationNodesList[0];
        configNode.ToggleRunning();
    }

    public void KNNTargetValue(int targetVal)
    {
        trainingNode = gameObject.GetComponent<IMLComponent>().TrainingExamplesNodesList[0];
        IntegerNode intNode = (IntegerNode)trainingNode.TargetValues[0];
        intNode.m_UserInput = targetVal;
    }

    public void KNNDeleteTrainingExamples()
    {
        trainingNode = gameObject.GetComponent<IMLComponent>().TrainingExamplesNodesList[0];
        trainingNode.ClearTrainingExamples();
    }

    public void KNNResetModel()
    {
        configNode = gameObject.GetComponent<IMLComponent>().IMLConfigurationNodesList[0];
        configNode.ResetModel();
    }
}
