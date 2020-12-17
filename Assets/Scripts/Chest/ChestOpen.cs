using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestOpen : MonoBehaviour
{

    public float TheDistance;
    public GameObject TheChest;
    public GameObject DisplayButton;
    public GameObject InteractionText;
    public GameObject green_key;
    public GameObject QuestCompleteTriggerG;
    public GameObject TakeSword;


        void Update()
    {
        TheDistance = CharacterRaycast.DistanceFromObject;
    }

    void OnMouseOver()
    {
       if (TheDistance <= 4) {
            InteractionText.GetComponent <Text> ().text = "Open Chest";
            InteractionText.SetActive(true);
            DisplayButton.SetActive(true);
        }

       if (Input.GetButtonDown ("Interaction"))
        {
            if (TheDistance <= 4)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                TheChest.GetComponent<Animation>().Play("ChestOpen");
                TakeSword.SetActive(true);
                InteractionText.SetActive(false);
                DisplayButton.SetActive(false);
                green_key.SetActive(true);
                QuestCompleteTriggerG.SetActive(true);
            }
        }
    }

    void OnMouseExit()
    {
        InteractionText.SetActive(false);
        DisplayButton.SetActive(false);
    }

}
