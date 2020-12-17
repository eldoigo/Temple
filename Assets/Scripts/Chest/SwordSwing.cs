using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    public GameObject EpicSword;
    public int HasSwung;
    public AudioSource SwooshySword;



    void Update()
    {
        if (Input.GetButtonDown("Fire1") && HasSwung ==0)
        {
            StartCoroutine(EnableSword());
        }
    }

    IEnumerator EnableSword ()
    {
        HasSwung = 1;
        EpicSword.GetComponent<Animation>().Play("SwordSwing");
        SwooshySword.Play();
        HasSwung = 2;
        yield return new WaitForSeconds(1);
        HasSwung = 0;
    }
}
