using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{

    private float time;
    private bool touchGround = false;

    private GameObject spawn;
    private Spawner spawnScript;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("SpawnPoints");
        spawnScript = spawn.GetComponent<Spawner>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (touchGround)
        {
            time = time + Time.deltaTime;
        }

        DeadYet();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            touchGround = true;

        }
    }

    void DeadYet()
    {
        if(time >= 5 && touchGround)
        {
            touchGround = false;
            spawnScript.SpawnNewCar();
            time = 0;


        }
    }
}
