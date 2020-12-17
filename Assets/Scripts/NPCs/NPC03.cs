using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC03 : MonoBehaviour
{
    public float TheDistance;
    public GameObject ElvenNPC;
    public GameObject InteractionText;


    void Update()
    {
        TheDistance = CharacterRaycast.DistanceFromObject;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            InteractionText.GetComponent<Text>().text = "Press F To Talk To The King";
            InteractionText.SetActive(true); 
        }

        if (Input.GetButtonDown("Interaction"))
        {
            if (TheDistance <= 3)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene(4);
            }
        }



    }

    void OnMouseExit()
    {
        InteractionText.SetActive(false);
    }

}