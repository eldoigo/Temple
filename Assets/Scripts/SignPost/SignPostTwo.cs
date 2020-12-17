using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignPostTwo : MonoBehaviour
{
    public float TheDistance;
    public GameObject TheSignPost;
    public GameObject InteractionText;

    void Update()
    {
        TheDistance = CharacterRaycast.DistanceFromObject;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 4)
        {
            InteractionText.GetComponent<Text>().text = "Ravenclaw 300 Yards Ahead Through Mountain Pass";
            InteractionText.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        InteractionText.SetActive(false);
    }

}
