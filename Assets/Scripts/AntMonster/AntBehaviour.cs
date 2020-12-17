using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntBehaviour : MonoBehaviour { 

    public GameObject TheAnt;
    public int AntStatus;
    public int AntHealth = 8;
    public AntAttack AntAttackScript;


    void Start()
    {
        AntAttackScript = GetComponent<AntAttack>();
    }

    void AntHit(int DamageAmount)
    {
        AntHealth -= DamageAmount;
    }



    void Update()
    {
        if (AntHealth <= 0)
        {
            if (AntStatus == 0)
            {
                StartCoroutine(AntDeath());
            }
        }
    }

    IEnumerator AntDeath ()
    {
        AntAttackScript.enabled = false;
        AntStatus = 3;
        yield return new WaitForSeconds(0.7f);
        TheAnt.GetComponent<Animation>().Play("die");
        Debug.Log("yay");
    }

}
