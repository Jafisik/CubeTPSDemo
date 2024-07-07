using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletFire : MonoBehaviour
{
    public Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body.velocity = body.rotation * Vector3.forward*12;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider != null)
        {
            Destroy(gameObject);
        }
    }
}
