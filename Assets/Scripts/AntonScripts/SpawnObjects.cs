using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objectToSpawn;

    public float timer = 3f;

    private bool countdown = true;

    void Start()
    {
        

    }

    void Update()
    {
        if (countdown)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Instantiate(objectToSpawn, new Vector3(0, 0, 0), Quaternion.identity);//Instatiate object at 0,0,0
                countdown = false;
            }
        }
        
    }
}
