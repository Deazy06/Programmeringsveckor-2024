using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class SpawnManager : GameManager
{

    public GameObject char_Prefab;

    public float timer;

    public void Update()
    {        

        if (yes == true)
        {
            timer += Time.deltaTime;
            Debug.Log("Succesfully sent him awway, TO GLORYY!");
            yes = false;
            SpawnChar_Prefab();
        }
        if (no == true)
        {
            timer += Time.deltaTime;
            Debug.Log("Succesfully sent him awway, TO HIS DEATH!");
            no = false;
            SpawnChar_Prefab();

        }

    }



    public void SpawnChar_Prefab()
    {
        DestroyPreviousCharacter();
        spawnedCharacter = Instantiate(char_Prefab, new Vector3(0, 3, 0), Quaternion.identity);
        Debug.Log("New character spawned SEND THEM TO HELL");
    }

    public void Start()
    {
        spawnedCharacter = Instantiate(char_Prefab, new Vector3(0, 3, 0), Quaternion.identity);
        spawnPermit = true;

        yes = false;
        no = false;
    }



    public void Ja()
    {
        yes = true;
        spawnPermit = true;
    }

    public void Nej()
    {
        no = true;
        spawnPermit = true;
    }

}
