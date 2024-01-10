using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointsystem : MonoBehaviour
{

    public bool choice;

    public int Money =  0;

    void Start()
    {
      
    }

    void Update()
    {
        if (choice= true) // om man gör rätt val får man 100 pengar
        {
            print("Point added");
            Money += 100;
        }
        else
        {
            print("No point added");
            //möjlighet för "dålig preformance" (man får sparken efter x antal fel)
        }
    }
}
