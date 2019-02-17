using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMotor : MonoBehaviour
{
    private NavMeshAgent agent;
    //private Rigidbody myRigidbody; 
    //I built capabuility to do an update movment like the promp said but switched to Nav mesh for cooler results. 
    //You can remove the comment sleshes and comment out the agent destination to use the other sistem. 
    public Transform targetPoint;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent> (); 
        agent.destination = targetPoint.position;
        //myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //myRigidbody.velocity = transform.forward * .5f;
    }
}
