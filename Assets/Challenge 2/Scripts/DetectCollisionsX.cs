using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour

{
public GameObject[] ballPrefabs;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ballz")){}
        else
        {
            Destroy(gameObject);
        }
    }
}
