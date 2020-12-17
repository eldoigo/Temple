using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CastleEnter : MonoBehaviour
{ 
    public float TheDistance;
    public GameObject ThePlayer;
    public GameObject ActionDisplay;
    public GameObject InteractionText;



    void Update()
    {
        TheDistance = CharacterRaycast.DistanceFromObject;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 4)
        {
            InteractionText.GetComponent<Text>().text = "Enter Castle";
            InteractionText.SetActive(true);
            ActionDisplay.SetActive(true);
        }

        if (Input.GetButtonDown("Interaction"))
        {
            if (CharacterRaycast.DistanceFromObject <= 4)
            {
                SceneManager.LoadScene(3);
            }
        }
    }

    void OnMouseExit(){
        ActionDisplay.SetActive (false);
        InteractionText.SetActive(false);
    }

}
