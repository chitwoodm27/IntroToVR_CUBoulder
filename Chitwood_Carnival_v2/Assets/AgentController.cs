using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class AgentController : MonoBehaviour
{
    public Transform target; // The destination point

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetDestination();
    }

    void SetDestination()
    {
        if (target != null)

        //if (Input.GetMouseButtonDown(0) && target != null)

        {
            agent.SetDestination(target.position);
        }
    }
}

