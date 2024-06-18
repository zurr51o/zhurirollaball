using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public Transform target;
    public Vector3 posOffset;
    
    private void LateUpdate()
    {
        transform.position = target.position + posOffset; //moves camera to target location plus the position offset.
    }

}
