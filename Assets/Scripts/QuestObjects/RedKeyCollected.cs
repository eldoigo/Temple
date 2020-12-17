using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedKeyCollected : MonoBehaviour
{

    public GameObject QuestCompleted;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter()
    {
        QuestCompleted.GetComponent<Text>().text = "You have collected The Eleven Red Key!";
        QuestCompleted.SetActive(true);
        
    }
  
    // Update is called once per frame
    void Update()
    {
        
    }
}
