using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variabler för spawnmanager RADERA EJ :prayers:
    static public bool yes;
    static public bool no;

    static public bool spawnPermit = false;

    public GameObject spawnedCharacter;
    public GameObject spawnableObj;

    public void resetPermitSpawnable()
    {
        if (spawnPermit == true)
        {
            spawnPermit = false;
            destroyPermit();
        }

        
    }

    public void DestroyPreviousCharacter()
    {
        if (spawnedCharacter != null)
        {
            Destroy(spawnedCharacter);

            resetPermitSpawnable();
        }
    }
    public void destroyPermit()
    {
        if (spawnableObj != null)
        {
            Destroy(spawnableObj);
            Debug.Log("Succesfully destroyed a permit");
        }
    }
}
