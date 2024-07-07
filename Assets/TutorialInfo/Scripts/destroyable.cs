using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class destroyable : MonoBehaviour
{
    public int lives = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "bullet")
        {
            lives--;
            if (lives == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
