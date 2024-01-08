using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuestNPCTrigger : MonoBehaviour
{
    [SerializeField] QuestManager questManager;
    public int ID; 
    public Canvas questCanvas;
    
    private void Awake()
    {
        questManager.questIndex = ID;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {    
            questManager.questIndex = ID;       
            questCanvas.gameObject.SetActive(true);           
        }
    }
}
