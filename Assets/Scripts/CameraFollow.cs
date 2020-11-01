using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform cameraTarget;
    [SerializeField]
    Transform objectTarget;

    [SerializeField]
    private Vector3 offsetPosition;

    void LateUpdate()
    {
        if (cameraTarget == null || objectTarget == null)
        {
            Debug.LogWarning("Missing target ref !", this);
            return;
        }

        transform.position = cameraTarget.transform.position;
        transform.rotation = objectTarget.rotation;
    }
}
