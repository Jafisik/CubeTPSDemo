using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotate : MonoBehaviour
{
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            var euler = cam.eulerAngles;
            var rot = Quaternion.Euler(0, euler.y, 0);
            transform.rotation = rot;
    }
}
