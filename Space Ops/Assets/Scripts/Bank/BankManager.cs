using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BankManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI screenUIMoney;
    public bool canUpdateCoin = true;
    private int currentBalance = 0;
    public int CurrentBalance
    {
        get => currentBalance;
        set{
            currentBalance = Mathf.Clamp(value,0,500);
            UpdateUI();
        }
    }


    void Start()
    {
        SetInitialBalance();
    }

    private void SetInitialBalance()
    {
        CurrentBalance = 0;
    }

    public void AddBalance(int amount)
    {        
        CurrentBalance += amount;
        canUpdateCoin = false;       
    }

    public void ReduceBalance(int amout)
    {
        CurrentBalance-= amout;
        canUpdateCoin = false;         
    }

    public void ResetCoinOperations()
    {
         canUpdateCoin = true;
    }
    private void UpdateUI()
    {
        screenUIMoney.text = CurrentBalance.ToString();
    }
}
