using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variabler f�r spawnmanager RADERA EJ :prayers:
    static public bool yes;
    static public bool no;

    static public bool spawnPermit = false;

    public void resetPermitSpawnable()
    {
        if (spawnPermit == true)
        {
            spawnPermit = false;
        }
    }

}
