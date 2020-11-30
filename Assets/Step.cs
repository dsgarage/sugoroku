using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StepStatus
{
    stay　= 1,
    Rest = 2,
}

[RequireComponent((typeof(Player)))]
public class Step : MonoBehaviour
{
    [SerializeField] private int stepValu = 0;
    [SerializeField] private StepStatus status = StepStatus.stay;

    public void Init()
    {
        stepValu = 0;
        status = StepStatus.stay;
    }

    public void SetStep(int diceNo)
    {
        stepValu += diceNo;
        Debug.Log(gameObject.name + " StepValu:" + stepValu);
    }

    public int GetStep()
    {
        return stepValu;
    }

    public StepStatus GetStepStatus()
    {
        return status;
    }
    
}
