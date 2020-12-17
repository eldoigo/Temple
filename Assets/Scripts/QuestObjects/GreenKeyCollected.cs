using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenKeyCollected : MonoBehaviour
{

    public GameObject QuestCompleted;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter()
    {
        QuestCompleted.GetComponent<Text>().text = "You have collected The Mythic Green Key!";
        QuestCompleted.SetActive(true);
        Debug.Log("yay it worked");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
