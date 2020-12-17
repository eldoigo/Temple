using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableSword : MonoBehaviour
{

    public float TheDistance;
    public GameObject ChestSword;
    public GameObject PlayerSword;
    public GameObject InteractionText;
    public GameObject InteractionCharacter;


        void Update()
    {
        TheDistance = CharacterRaycast.DistanceFromObject;
    }

    void OnMouseOver()
    {
       if (TheDistance <= 4) {
            InteractionText.GetComponent <Text> ().text = "Take The Sword";
            InteractionText.SetActive(true);
            InteractionCharacter.SetActive(true);
        }

       if (Input.GetButtonDown ("Interaction"))
        {
            if (TheDistance <= 4)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ChestSword.SetActive(false);
                PlayerSword.SetActive(true);
                InteractionText.SetActive(false);
                InteractionCharacter.SetActive(false);

            }
        }
    }

    void OnMouseExit()
    {
        InteractionText.SetActive(false);
        InteractionCharacter.SetActive(false);
    }

}
