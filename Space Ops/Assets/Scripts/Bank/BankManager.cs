using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BankManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI screenUIMoney;
    public bool coinCanBeAdded = true;
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
        coinCanBeAdded = false;       
    }

    public void ReduceBalance(int amout)
    {
        CurrentBalance-= amout;
        coinCanBeAdded = false;         
    }

    public void ResetCoinOperations()
    {
         coinCanBeAdded = true;
    }
    private void UpdateUI()
    {
        screenUIMoney.text = CurrentBalance.ToString();
    }
}
