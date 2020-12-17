using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignPostOne : MonoBehaviour
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
            InteractionText.GetComponent<Text>().text = "Elven Village 200 yards ahead";
            InteractionText.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        InteractionText.SetActive(false);
    }

}
