using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCompleteTrigger : MonoBehaviour
{
    [SerializeField] QuestManager questManager;
    [SerializeField] BankManager bankManager;
    [SerializeField] StateAction questStates;
   
    

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {            
            if(questStates.isActive)
            {
                questStates.Progress();
            }
            
            if(questStates.Completed() && questStates.isActive)
            {                
                bankManager.CurrentBalance += questManager.quests[questManager.questIndex].goldReward;
                questStates.NullifyQuest();
            }
        }
    }
}
