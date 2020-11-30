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
    [SerializeField] private List<Step> playerSteps = new List<Step>();
    [SerializeField] private List<Player> playerList = new List<Player>();
    [SerializeField] private int turn;
    [SerializeField] private int playerNumber;
    [SerializeField] private bool SetDiceRoll = false;
    [SerializeField] private GameObject[] stepObject ;
    private void Start()
    {
        Init();
        foreach (var VARIABLE in playerSteps)
        {
            Debug.Log(VARIABLE.gameObject.name);
            
        }

    }

    public void Init()
    {
        turn = 0;　/// ターン数
        playerNumber = playerSteps.Count; /// プレイ人数
        SetDiceRoll = true;
        
        foreach (var VARIABLE in playerSteps)
        {
            VARIABLE.Init();
            VARIABLE.gameObject.transform.position =
                stepObject[playerSteps[turn].GetStep()].gameObject.transform.position;
            SetPlayer(VARIABLE.gameObject.GetComponent<Player>());
        }

        for (int i = 0; i < playerSteps.Count; i++)
        {
            Player player = playerSteps[i].gameObject.GetComponent<Player>();
            player.SetPlayerNo(i+1);
        }
        
        
    }

    void ChackStep(int stepNum)
    {
        
        foreach (var VARIABLE in playerSteps)
        {
            
            if (VARIABLE.GetStep() == stepNum)
            {
                VARIABLE.gameObject.transform.position += Vector3.left;
            }
        }
    }
    

    void TurnChack()
    {
        if (playerSteps.Count == turn)
        {
            turn = 0;
        }
    }
    
    public void SetTurn()
    {
        if (!SetDiceRoll)
        {
            Debug.Log("======SetTurn=====");
            if (turn + 1 == playerSteps.Count)
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
            
            playerSteps[turn].SetStep(dice.GetDiceNumber());
            playerSteps[turn].gameObject.transform.position =
                stepObject[playerSteps[turn].GetStep()].gameObject.transform.position;
            
            TurnChack();
            SetDiceRoll = false;
        //    ChackStep(playerStep[turn].GetStep());

        }
    }

    public void SetPlayer(Player player)
    {
        if (playerList.Count == 0)
        {
            playerList.Add(player);
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
