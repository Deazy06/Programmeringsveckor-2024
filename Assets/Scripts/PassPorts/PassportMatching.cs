using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassportMatching : MonoBehaviour
{

    public List<GameObject> allowedObjects;

    public bool choice;

    public GameObject gameobject1;
    public GameObject gameobject2;
    // Start is called before the first frame update
    void Start()
    {
     

        if (string.Compare(gameobject1.tag, gameobject2.tag) == 0)
        {
            print("Tags are equal.");
            choice = true;
        }
        else
        {
            print("Tags are not equal.");

            choice = false;
        }

    }

    private void Update()
    {
        
    }

    
}
