using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public GameObject objectToSpawn;
   

    public void OnButtonPress()
    {
        Instantiate(objectToSpawn, new Vector3(3, -3, 0), Quaternion.identity);//Instatiate object at 3,-3,0
    }
}
