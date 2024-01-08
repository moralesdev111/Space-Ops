using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateAction : MonoBehaviour
{
   
    [SerializeField] QuestNPCTrigger questNPCTrigger;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] Quest quest;
    [SerializeField] QuestManager questManager;
    [SerializeField] StateMachine stateSwitching;    
    [SerializeField] Button acceptButton;


    public bool buttonAccepted = false;
    public bool hasProgressed = false;
    private int currentAmount;
    public bool isActive = false;


    private void Start()
    {
        
        acceptButton.onClick.AddListener(AcceptButtonRegistered);
    }

    private void Update()
    {
        SetQuestState();
    }

    public void SetQuestState()
    {
        if(stateSwitching.currentState == StateMachine.QuestStates.none)
        {
             hasProgressed = false;
            isActive = false;

        }
        if(stateSwitching.currentState == StateMachine.QuestStates.acccepted)
        {

            
            playerMovement.activeQuest = questManager.quest;        
        

        }
        if(stateSwitching.currentState == StateMachine.QuestStates.progressMade)
        {
            
            playerMovement.activeQuest = questManager.quest;
            Progress();

        }
        if(stateSwitching.currentState == StateMachine.QuestStates.completed)
        {

            Completed();
            NullifyQuest();

        }
    }

    public void AcceptButtonRegistered()
    {
        questNPCTrigger.questCanvas.gameObject.SetActive(false);
        questManager.SetQuest();
        isActive = true;
        stateSwitching.currentState = StateMachine.QuestStates.acccepted;
        buttonAccepted = true;                    
    }

    public void Progress()
    {
        buttonAccepted = false;
        if(isActive)
        {
        currentAmount++;
        hasProgressed = true;
        }         
    }

    public bool Completed()
    {
        return currentAmount >= quest.requiredAmount;
    }

    public bool NullifyQuest()
    {
        isActive = false;
        questManager.quest = null;
        
        Debug.Log("Completed");
        return true;
    }    
}
