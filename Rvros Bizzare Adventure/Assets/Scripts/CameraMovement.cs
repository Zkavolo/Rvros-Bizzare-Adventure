using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform followObject;
    public Vector3 offset; [Range(1,10)]
    public float smoothFactor;
    public Vector3 minValue, maxValue;

    void FixedUpdate(){
        Vector3 PlayerPosition = followObject.position + offset;

        Vector3 BoundPosition = new Vector3(
            Mathf.Clamp(PlayerPosition.x, minValue.x, maxValue.x),
            Mathf.Clamp(PlayerPosition.y, minValue.y, maxValue.y),
            Mathf.Clamp(PlayerPosition.z, minValue.z, maxValue.z));
        
        Vector3 smoothPosition = Vector3.Lerp(transform.position, BoundPosition, smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
        }
}
