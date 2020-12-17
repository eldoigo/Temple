using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRaycast : MonoBehaviour{
    /// <summary>
    /// 
    /// </summary>
    public static float DistanceFromObject;
    public float DistanceToObject;

    public float DotProduct;
    public float GlideStartAngle;
    public float GlideEndAngle;

    public static bool isCharacterGliding = false;
    public static Vector3 characterGlidingVector = Vector3.zero;

    private float glideSpeed = 4.5f;

    private void Start()
    {
        //Dont go under 10 degree
        GlideStartAngle = 1 - Mathf.Cos(Mathf.Deg2Rad * 75);
        GlideEndAngle = 1 - Mathf.Cos(Mathf.Deg2Rad * 30);
    }

    void Update(){
        RaycastHit Hit;
        if (Physics.Raycast (transform.position, transform.forward, out Hit)){
            DistanceToObject = Hit.distance;
            DistanceFromObject = DistanceToObject;
        }


       
        if (Physics.SphereCast(transform.position, 0.5f, Vector3.down, out Hit, 2))
        {
            Debug.DrawRay(transform.position, new Vector3(0, -2, 0), Color.green);
            Vector3 normal = Hit.normal;
            DotProduct = 1 - Vector3.Dot(normal, Vector3.up);
            //Debug.Log("Dot " + DotProduct);

            if (isCharacterGliding)
            {

                if (DotProduct < GlideEndAngle)
                {
                    isCharacterGliding = false;
                    characterGlidingVector = Vector3.zero;
                }
                else 
                {
                    Vector3 dir = transform.position - Hit.point;
                    dir.y = 0;
                    characterGlidingVector = Vector3.ProjectOnPlane(dir, normal).normalized * glideSpeed;
                }
            }
            else
            {
                if (DotProduct > GlideStartAngle)
                {
                    isCharacterGliding = true;
                }
            }
        }
        else 
        {
            Debug.DrawRay(transform.position, new Vector3(0, -2, 0), Color.red);
            if (isCharacterGliding) 
            {
                isCharacterGliding = false;
                characterGlidingVector = Vector3.zero;
            }
        }
    }

}
