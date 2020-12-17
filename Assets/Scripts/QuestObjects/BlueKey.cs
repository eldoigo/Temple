using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueKey : MonoBehaviour
{

    public int RotateSpeed;
    public AudioSource CollectSound;
    public GameObject thisblue_key;
    public GameObject thisBlueKeyNeeded;

    void Start()
    {
        thisBlueKeyNeeded.SetActive(false);
    }



    void Update()
    {
        RotateSpeed = 1;
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }

    // isn't working
    void OnTriggerEnter()
    {
        CollectSound.Play();
        thisBlueKeyNeeded.SetActive(true);
        thisblue_key.SetActive(false);
    }
}