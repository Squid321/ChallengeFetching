using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float canfire = 1f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canfire == 1)
            
                {
                    canfire = 0;
                    Invoke("SpawnDelay", 1);
                    Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                }
        }
    }
    void SpawnDelay ()
    {
        canfire = 1;
    }
}