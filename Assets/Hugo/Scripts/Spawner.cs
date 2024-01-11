using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject CharacterPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        Instantiate(CharacterPrefab, new Vector3(0, 0.2f, 0), Quaternion.identity);
    }

    public void spawnTimer()
    {
        Invoke("Spawn", 5);
    }

    
}
