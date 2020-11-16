using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームの審判です
/// ゲーム内での進行、判定などを全て引き受けるスクリプトです
/// </summary>

public class GameLogic : MonoBehaviour
{
    [SerializeField] private Dice dice;
    [SerializeField] private List<Step> playerStep = new List<Step>();
    [SerializeField] private int turn;
    [SerializeField] private int playerNumber;
    [SerializeField] private bool SetDiceRoll = false;
    [SerializeField] private GameObject[] stepObject ;
    private void Start()
    {
        Init();
        foreach (var VARIABLE in playerStep)
        {
            Debug.Log(VARIABLE.gameObject.name);
        }
    }

    public void Init()
    {
        turn = 0;　/// ターン数
        playerNumber = playerStep.Count; /// プレイ人数
        SetDiceRoll = true;
        foreach (var VARIABLE in playerStep)
        {
            VARIABLE.Init();
        }
    }

    void TurnChack()
    {
        if (playerStep.Count == turn)
        {
            turn = 0;
        }
    }
    
    public void SetTurn()
    {
        if (!SetDiceRoll)
        {
            Debug.Log("======SetTurn=====");
            if (turn + 1 == playerStep.Count)
            {
                turn = 0;
            }
            else
            {
                turn += 1;
            }
        }
        SetDiceRoll = true;
    }

    public void SetTurn(int turnNo)
    {
        turn += turnNo;
    }
    
    public void DiceRoll()
    {
        if (SetDiceRoll)
        {
            playerStep[turn].SetStep(dice.GetDiceNumber());
            TurnChack();
            SetDiceRoll = false;
        }
    }

    public void SetGameSteps(GameObject[] addStepObject)
    {
        stepObject = addStepObject;
    }

    public void SetGameStep(GameObject addStep)
    {
        Array.Resize(ref stepObject,stepObject.Length +1);
        stepObject[stepObject.Length - 1] = addStep;
    }
}
