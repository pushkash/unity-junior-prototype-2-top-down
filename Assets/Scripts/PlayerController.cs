using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float boundary = 10.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -boundary)
        {
            transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);
        } else if (transform.position.x > boundary)
        {
            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from player's position
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }

    }
}
