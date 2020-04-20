using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Player_Look : MonoBehaviour
{

    [SerializeField] private string mouseXInputName, mouseYInputName;
    [SerializeField] private float mouseSensitivity;

    [SerializeField] private Transform PlayerBody;
    private float xAxisClap;


    private void Awake()
    {
        LockCursor();
        xAxisClap = 0.0f;
    }


    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    // Update is called once per frame
    void Update()
    {
        CameraRotation();
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        xAxisClap += mouseY;

        if(xAxisClap > 90.0f)
        {
            xAxisClap = 90.0f;
            mouseY = 0.0f;
            clampXAxisRotationSetValue(270.0f);
        }
        else if (xAxisClap < -90.0f)        
        {
            xAxisClap = -90.0f;
            mouseY = 0.0f;
            clampXAxisRotationSetValue(90.0f);
        }

        transform.Rotate(Vector3.left * mouseY);        //transform.Rotate(-transform.right * mouseY);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }

    private void clampXAxisRotationSetValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
