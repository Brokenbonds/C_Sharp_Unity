using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;//this namespace is important for working iwht Cinemachine

public class Spawner : MonoBehaviour
{
    public int checkpoint = 0;
    public GameObject car;
    public CinemachineVirtualCamera vCamera;//Created a Cinemachine Virtual Vamera
    public Transform[] waypoints;

    private Transform start;
    private GameObject pCar;
    

    // Start is called before the first frame update
    void Awake()
    {
        if (waypoints.Length == 0)
        {
            waypoints = new Transform[1];
            SetStartWaypoint();
        }
        
        //SetStartWaypoint();

        pCar = Instantiate(car, waypoints[checkpoint].position,waypoints[checkpoint].rotation);
        vCamera.LookAt = pCar.transform;
        vCamera.Follow = pCar.transform;


    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void SetStartWaypoint()
    {
        start = this.transform;
        waypoints[checkpoint] = start;
    }

    public void SpawnNewCar()
    {
        Destroy(pCar);
        pCar = Instantiate(car, waypoints[checkpoint].position, waypoints[checkpoint].rotation);
        vCamera.LookAt = pCar.transform;
        vCamera.Follow = pCar.transform;
    }

    public void CheckPointSetter(int point)
    {
        if (checkpoint < point)
        {
            checkpoint++;
        }
        
    }
}
