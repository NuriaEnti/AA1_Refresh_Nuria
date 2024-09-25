using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    public float rotationSpeed = 5f;
    public float maxVerticalAngle = 45f;

    private float currentVerticalAngle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y");

        currentVerticalAngle += mouseY * rotationSpeed;
        currentVerticalAngle = Mathf.Clamp(currentVerticalAngle, -maxVerticalAngle, maxVerticalAngle);

        transform.localEulerAngles = new Vector3(currentVerticalAngle, transform.localEulerAngles.y, 0);
    }
}
