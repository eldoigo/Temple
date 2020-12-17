using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKey : MonoBehaviour
{

    public int RotateSpeed;
    public AudioSource CollectSound;
    public GameObject thisgreen_key;
    public GameObject thisGreenKeyNeeded;

    void Start()
    {
        thisGreenKeyNeeded.SetActive(false);
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
        thisgreen_key.SetActive(false);
        thisGreenKeyNeeded.SetActive(true);
    }



}