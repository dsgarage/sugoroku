using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    [SerializeField]private Text diceNumberView;
    private const int DiceFastNumber = 1;
    [SerializeField]private int face = 6;
    [SerializeField]private int times = 1;
    [SerializeField]private int diceNumber = 0;
    
    public void Init()
    {
        diceNumber = 0;
        if (diceNumberView != null)
        {
            diceNumberView.text = diceNumber.ToString();
        }
    }

    public int GetDiceNumber()
    {
        Init();
        
        int rollNumber = 0;

        rollNumber = Random.Range(DiceFastNumber, face+1);

        return rollNumber;
    }

    public void DiceRoll()
    {
        diceNumber = GetDiceNumber();
        if (diceNumberView != null)
        {
            diceNumberView.text = diceNumber.ToString();
        }
    }
}
