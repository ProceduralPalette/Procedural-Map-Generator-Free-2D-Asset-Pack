using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapNavigation : MonoBehaviour
{
    [Header("ADJUSTABLE")]

    //Camera speed
    public float dragSpeed = 2;

    private Vector3 dragOrigin;


    float cameraDistanceMax = 100f;
    float cameraDistanceMin = 10f;
    float cameraDistance = 50f;
    float scrollSpeed = 5f;

    [SerializeField] Camera camera;


    void Update()
    {
        //Move camera
        MoveCamera();

        //Zoom logic
        cameraDistance -= Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
        cameraDistance = Mathf.Clamp(cameraDistance, cameraDistanceMin, cameraDistanceMax);

        camera.orthographicSize = cameraDistance;
    }

    private void MoveCamera()
    {
        if (Input.GetMouseButtonDown(2))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(2)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(dragOrigin - Input.mousePosition);
        Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);

        transform.Translate(move, Space.World);
    }
}