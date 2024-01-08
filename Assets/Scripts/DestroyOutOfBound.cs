using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{

    public float topBoundry = 30;
    public float bottomBoundry = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBoundry)
        {
            Destroy(gameObject);
        } else if (transform.position.z < bottomBoundry)
        {
            Destroy(gameObject);
        }
    }
}
