using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMotor : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform targetPoint;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent> (); 
        agent.destination = targetPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
