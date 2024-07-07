using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform barrel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bull = Instantiate<GameObject>(bullet, barrel.position+barrel.forward/2,barrel.rotation);
            bull.transform.SetParent(this.transform, true);
            bull.transform.rotation = barrel.transform.rotation;

        }
    }
}
