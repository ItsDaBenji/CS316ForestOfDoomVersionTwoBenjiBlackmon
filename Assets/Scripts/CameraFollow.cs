using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] Transform target;

    [SerializeField] Vector3 offset = new Vector3(0, 0, -10);

    [SerializeField] float cameraSmooth;

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, cameraSmooth);
        transform.position = smoothedPosition;
    }
}
