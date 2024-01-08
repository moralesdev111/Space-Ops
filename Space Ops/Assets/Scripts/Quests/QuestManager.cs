using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI descriptionText;
    [SerializeField] TextMeshProUGUI rewardText;

    public List<Quest> quests = new List<Quest>();
    public Quest quest;
    public int questIndex;


    private void Start()
    {        
        CreateQuests();        
    }

    private void Update()
    {
        UpdateUIWithCurrentQuest();
    }

    public Quest SetQuest()
    {        
        return quest = quests[questIndex];       
    }

    private void UpdateUIWithCurrentQuest()
    {        
        titleText.text = quests[questIndex].title;
        descriptionText.text = quests[questIndex].description;
        rewardText.text = quests[questIndex].goldReward.ToString();        
    }

    private List<Quest> CreateQuests()
    {        
        quests.Add(new Quest{title = "Go to A", description = "Explore to your heart content A", goldReward = 2, requiredAmount = 1});
        quests.Add(new Quest{title = "Go to B", description = "B is the best area go fast", goldReward = 13, requiredAmount = 1});
        return quests.ToList();       
    }
}
