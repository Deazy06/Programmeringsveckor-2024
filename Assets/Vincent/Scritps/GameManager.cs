using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variabler f�r spawnmanager RADERA EJ :prayers:
    static public bool yes;
    static public bool no;

    public int maxAmountOfCharacters;
    public int randomMaxAmountOfCharacters;

    static public bool spawnPermit = false;

    public GameObject spawnedCharacter;
    public GameObject spawnableObj;

    public void resetPermitSpawnable() // reset functionen att id/ permits kunna spawna
    {
        if (spawnPermit == true)
        {
            spawnPermit = false;
            destroyPermit();
        }

        
    }

    public void DestroyPreviousCharacter() // f�rst�r f�rra id/ permit s� att en ny kan lyckas spawna in
    {
        if (spawnedCharacter != null)
        {
            Destroy(spawnedCharacter);

            resetPermitSpawnable();
        }
    }
    public void destroyPermit() // f�rst�r f�rra id/ permit s� att en ny kan lyckas spawna in
    {
        if (spawnableObj != null)
        {
            Destroy(spawnableObj);
            Debug.Log("Succesfully destroyed a permit");
        }
    }

}
