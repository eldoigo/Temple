using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignPostThree : MonoBehaviour
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
            InteractionText.GetComponent<Text>().text = "King's Forrest - 150 Yards | The Castle - 300 Yards Ahead";
            InteractionText.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        InteractionText.SetActive(false);
    }

}
