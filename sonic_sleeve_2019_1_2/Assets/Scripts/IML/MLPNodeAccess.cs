using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InteractML;
using InteractML.DataTypeNodes;

public class MLPNodeAccess : MonoBehaviour
{
    public IMLComponent imlComponent;

    private IMLConfiguration configNode;
    private TrainingExamplesNode trainingNode;

    /*public void Awake()
    {
        imlComponent = gameObject.GetComponent<IMLComponent>();
        imlComponent.LoadAllModelsFromDisk();
    }*/

    public void MLPRecord()
    {
        trainingNode = gameObject.GetComponent<IMLComponent>().TrainingExamplesNodesList[0];
        trainingNode.ToggleCollectExamples();
    }

    public void MLPTrain()
    {
        configNode = gameObject.GetComponent<IMLComponent>().IMLConfigurationNodesList[0];
        configNode.TrainModel();
    }

    public void MLPRun()
    {
        configNode = gameObject.GetComponent<IMLComponent>().IMLConfigurationNodesList[0];
        configNode.ToggleRunning();
    }

    public void MLPTargetValue(float targetVal)
    {
        trainingNode = gameObject.GetComponent<IMLComponent>().TrainingExamplesNodesList[0];
        FloatNode floatNode = (FloatNode)trainingNode.TargetValues[0];
        floatNode.m_UserInput = targetVal;
    }

    public void MLPDeleteTrainingExamples()
    {
        trainingNode = gameObject.GetComponent<IMLComponent>().TrainingExamplesNodesList[0];
        trainingNode.ClearTrainingExamples();
    }

    public void MLPResetModel()
    {
        configNode = gameObject.GetComponent<IMLComponent>().IMLConfigurationNodesList[0];
        configNode.ResetModel();
    }

    public void OnApplicationQuit()
    {
        imlComponent.SaveAllModels();
    }
}
