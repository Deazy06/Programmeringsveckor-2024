using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objectToSpawn;


    void Start()
    {
        Instantiate(objectToSpawn);
        print("spawn");
    }
}
