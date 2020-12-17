using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueKeyCollected : MonoBehaviour
{

    public GameObject QuestCompleted;
    //public GameObject SecondTextUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter()
    {
        QuestCompleted.GetComponent<Text>().text = "You have collected The Forbidden Blue Key!";
        QuestCompleted.SetActive(true);
        Debug.Log("yay it worked");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
