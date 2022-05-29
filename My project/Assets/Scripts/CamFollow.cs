using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform targetTransform;
    public Transform targetTransform1;
    public Transform targetTransform2;
    Vector3 tempVec3 = new Vector3();
    void LateUpdate()
    {
        tempVec3.x = targetTransform.position.x;
        tempVec3.y = targetTransform1.position.y;
        tempVec3.z = targetTransform2.position.z - 13;

        this.transform.position = tempVec3;
    }
}
