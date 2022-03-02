using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    private Spawner spawnScript;
    private GameObject spawn;
    public int checkpointNumber;

    private void Start()
    {
        spawn = GameObject.Find("SpawnPoints");
        spawnScript = spawn.GetComponent<Spawner>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            spawnScript.CheckPointSetter(checkpointNumber);
        }
           
            
        
    }
}
