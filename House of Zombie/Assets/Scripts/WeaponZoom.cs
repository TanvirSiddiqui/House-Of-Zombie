using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFov = 20f;

    [SerializeField] float zoomOutSensitivity =2f;
    [SerializeField] float zoomInSensitivity = 0.5f;
    bool zoomedInToggle = false;

    RigidbodyFirstPersonController fpsController;

     void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomInFov;
                fpsController.mouseLook.XSensitivity = zoomInSensitivity;
                fpsController.mouseLook.YSensitivity= zoomInSensitivity;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomOutFOV;
                fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
                fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
            }
        }
    }
}
