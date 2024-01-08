using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] StateAction stateAction;

    public QuestStates currentState;




    public enum QuestStates
    {
        none,
        acccepted,
        progressMade,
        completed
    }

    
    void Update()
    {
        StateMachines();       
    }

   
    private QuestStates StateMachines()
    {
        QuestStates nextState = currentState;

        switch(currentState)
        {

            case QuestStates.none:            
            {
                if(stateAction.buttonAccepted)
                {
                    nextState = QuestStates.acccepted;

                }
                break;

            }
            case QuestStates.acccepted:            
            {
                if(stateAction.hasProgressed)
                {
                    nextState = QuestStates.progressMade;

                }
                break;

            }
            case QuestStates.progressMade:            
            {
                if(stateAction.Completed())
                {
                    nextState = QuestStates.completed;

                }
                break;
            }
            case QuestStates.completed:            
            {
                if(stateAction.NullifyQuest())
                {
                    nextState = QuestStates.none;

                }
               
            }
            break;
        default:
            break;
         }
    currentState = nextState; // Update currentState with nextState
    return currentState; // Return the updated currentState
    }
}

    

