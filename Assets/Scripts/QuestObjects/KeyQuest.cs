using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyQuest : MonoBehaviour
{

    public float TheDistance;
    public GameObject ThePlayer;
    public GameObject ActionDisplay;
    public GameObject UIQuest;
    public GameObject NoticeCam;
    public GameObject QuestPanel;

    void Update()
    {
        TheDistance = CharacterRaycast.DistanceFromObject;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 4)
        {
            ActionDisplay.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (Input.GetButtonDown("Interaction"))
        {
            if (CharacterRaycast.DistanceFromObject <= 4)
            {
                QuestPanel.SetActive(true);
                ActionDisplay.SetActive(false);
                UIQuest.SetActive(true);
                NoticeCam.SetActive(true);
                ThePlayer.SetActive(false);
            }
        }
    }

    void OnMouseExit(){
        ActionDisplay.SetActive (false);
    }

}
