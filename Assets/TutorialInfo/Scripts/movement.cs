using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody body;
    [SerializeField] float speed = 3f;
    [SerializeField] float jump = 5f;
    bool canJump = false;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * verticalInput * speed;
        Vector3 movementRight = transform.right * horizontalInput * speed;

        body.MovePosition(body.position + movement * speed * Time.deltaTime);
        body.MovePosition(body.position + movementRight * speed * Time.deltaTime);

        

        if (Input.GetButtonDown("Jump") && canJump)
        {
            body.velocity = new Vector3(body.velocity.x, jump, body.velocity.z);
            canJump = false;
        }

        if(transform.position.y < -2)
        {
            Reset();
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "jumpPlane")
        {
            canJump = true;
        }
        if(collision.collider.tag == "enemy")
        {
            Reset();
        }
    }

    private void Reset()
    {
        transform.position = new Vector3(0,0.5f,0);
    }
}
