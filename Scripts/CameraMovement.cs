using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;
    [SerializeField] private float distanceToTarget = 10;

    private Vector3 previousPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Debug.Log(cam.ScreenToViewportPoint(Input.mousePosition));
            Debug.Log ("The problemIt happens here");
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = cam.ScreenToViewportPoint(Input.mousePosition);
            Vector3 direction = previousPosition - newPosition;

            float rotationAroundYAxis = -direction.x * 180; 
            

            cam.transform.position = target.position;

            
            cam.transform.Rotate(new Vector3(0, 1, 0), rotationAroundYAxis, Space.World); 

            cam.transform.Translate(new Vector3(0, 1, -distanceToTarget));

            previousPosition = newPosition;
        }
    }
}