using Cinemachine;
using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float ZoomOutSensitivity = 1f;
    [SerializeField] float ZoomInSensitivity = 0.5f;
    [SerializeField] FirstPersonController fpsController;
    bool zoomedInToggle = false;

    private void Start()
    {
        fpsController = GetComponent<FirstPersonController>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.m_Lens.FieldOfView = zoomedInFOV;
                fpsController.RotationSpeed = ZoomInSensitivity; // If want to change x and y sensitivity individually, then go To FirstPersonController.cs and follow rotationSpeed Variable, you will get the way to change. 
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.m_Lens.FieldOfView = zoomedOutFOV;
                fpsController.RotationSpeed = ZoomOutSensitivity; // If want to change x and y sensitivity individually, then go To FirstPersonController.cs and follow rotationSpeed Variable, you will get the way to change. 
            }
            Debug.Log("Scope");
        }
    }
}
