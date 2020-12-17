using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedKey : MonoBehaviour{

    public int RotateSpeed;
    public AudioSource CollectSound;
    public GameObject thisred_key;
    public GameObject thisRedKeyNeeded;
    //public GameObject KeyQuestBox;
    //public GameObject SecondText;

    void Start()
    {
        thisRedKeyNeeded.SetActive(false);
    }



    void Update(){
        RotateSpeed = 1;
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }

   
    void OnTriggerEnter() {
        CollectSound.Play();
        thisRedKeyNeeded.SetActive(true);
        thisred_key.SetActive(false);
    }
}
