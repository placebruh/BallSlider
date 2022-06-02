using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform targetTransform;
    Vector3 tempVec3 = new Vector3();
    void LateUpdate()
    {
        tempVec3.x = 0;
        tempVec3.y = 16;
        tempVec3.z = targetTransform.position.z - 13;

        this.transform.position = tempVec3;
    }
}
