using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spheremoving : MonoBehaviour
{
    public float posX;
    public float posZ;
    // Start is called before the first frame update
    void Start()
    {
        posX = Random.Range(-0.6f, 0.6f);
        posZ = 0;
        Vector3 spawnPos = new Vector3(posX, 0.2f, posZ);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = transform.forward * 0.2f;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
