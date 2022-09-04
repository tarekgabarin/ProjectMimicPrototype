using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float MouseSensitivity = 300f;

    public Transform PlayerBody;

    public float sensX;
    public float sensY;

    private float xRotation = 0f;
    private float yRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensX;
        float MouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensY;

        xRotation -= MouseY;
        yRotation += MouseX;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        PlayerBody.Rotate(Vector3.up * MouseX);


    }
}
