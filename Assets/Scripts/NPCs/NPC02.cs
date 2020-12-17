using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC02 : MonoBehaviour
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
            InteractionText.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        InteractionText.SetActive(false);
    }

}