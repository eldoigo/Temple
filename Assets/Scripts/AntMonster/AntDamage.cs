using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntDamage : MonoBehaviour
{

    public int DamageAmount = 4;
    public float AntDistance;
    public float AntAttackDistance = 2.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                AntDistance = hit.distance;
                if (AntDistance <= AntAttackDistance)
                {
                    hit.transform.SendMessage("AntHit", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
