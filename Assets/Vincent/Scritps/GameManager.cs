using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool yes;
    public bool no;

    private void Update()
    {
        if (!yes)
        {
            no = false;
        }
    }

    public void Ja()
    {

    }

    public void Nej()
    {

    }

}
