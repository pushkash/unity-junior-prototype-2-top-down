using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool spawned = false;
    private float decay = 1f;

    // Update is called once per frame
    void Update()
    {

        Reset();

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !spawned)
        {
            spawned = true;
            decay = 1f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    private void Reset()
    {
        if (spawned && decay > 0)
        {
            decay -= Time.deltaTime;
        }
        else if (decay < 0)
        {
            decay = 0;
            spawned = false;
        }
    }
}
