using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCompleteSpecial : MonoBehaviour
{
    [SerializeField] QuestManager questManager;
    [SerializeField] BankManager bankManager;
    [SerializeField] StateAction questStates;

    

    private void OnTriggerStay(Collider collider)
    {
        if(questStates.isActive)
        {
            if(collider.CompareTag("Player"))
                {            
                    if(Input.GetKey(KeyCode.L))
                    {
                        questStates.Progress();
                
                        if(questStates.Completed())
                        {                
                            bankManager.CurrentBalance += questManager.quests[questManager.questIndex].goldReward;
                            questStates.NullifyQuest();
                        }
                    }
            }
        }
    }
}
