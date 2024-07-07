using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform objectToOrbit;
    public float radius = 3;
    public float sensitivity = 10;
    bool inSomething = false;

    // Update is called once per frame
    void Update()
    {
        if (!inSomething)
        {
            radius += Input.mouseScrollDelta.y;
            transform.position = objectToOrbit.position - (transform.forward * radius);
            transform.RotateAround(objectToOrbit.position, Vector3.up, Input.GetAxis("Mouse X") * sensitivity);
            transform.RotateAround(objectToOrbit.position, transform.right, -Input.GetAxis("Mouse Y") * sensitivity);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            inSomething = true;
            Debug.Log("touching");
        }
        else
        {
            inSomething = false;
        }
    }
}
