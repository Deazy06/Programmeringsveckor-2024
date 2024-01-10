using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Permit : GameManager
{

    public GameObject permit_Prefab;


    public void Update()
    {
        if (spawnPermit == true)
        {

            SpawnPermitOnCharacterSpawn();
            resetPermitSpawnable();

        }
    }

    public void Start()
    {
        spawnableObj = Instantiate(permit_Prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void SpawnPermitOnCharacterSpawn()
    {
        spawnableObj = Instantiate(permit_Prefab, new Vector3(0, 0, 0), Quaternion.identity);
        Debug.Log("Succesfully spawned a permit");
    }

}
