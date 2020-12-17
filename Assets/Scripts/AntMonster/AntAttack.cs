using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntAttack : MonoBehaviour
{
    public GameObject TheCharacter;
    public GameObject TheAnt;
    public float DistanceToAnt;
    public float AntAttackDistance = 25;
    public int AntTarget;
    public float AntSpeed;
    public RaycastHit Shot;

    void Update()
    {
        transform.LookAt(TheCharacter.transform);
            if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            DistanceToAnt = Shot.distance;
            if (DistanceToAnt <= AntAttackDistance)
            {
                AntSpeed = 0.06f;
                if (AntTarget == 0)
                {
                    TheAnt.GetComponent<Animation>().Play("walk");
                    transform.position = Vector3.MoveTowards(transform.position, TheCharacter.transform.position, AntSpeed);
                }
            }
            else 
            {
                AntSpeed = 0;
                TheAnt.GetComponent<Animation>().Play("idle");
            }
        }
            if (AntTarget == 1)
            {
            AntSpeed = 0;
            TheAnt.GetComponent<Animation>().Play("attack");
            }
    }

    void OnTriggerEnter()
    {
        AntTarget = 1;
    }

    void OnTriggerExit()
    {
        AntTarget = 0;
    }
}
