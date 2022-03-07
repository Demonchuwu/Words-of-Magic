using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropping : MonoBehaviour
{
    public GameObject bridge;

    public void OnTriggerEnter(Collider col)
    {
        if(GameObject.FindGameObjectWithTag("Dropping"))
        {
            Instantiate(bridge, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
