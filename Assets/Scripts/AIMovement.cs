using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class AIMovement : MonoBehaviour
{
    //List of points to traverse 
    [SerializeField] private List<Transform> _points = new List<Transform>();

    //track the destination
    private int _destination;

    //store nav mesh agent reference
    private NavMeshAgent _agent;


    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();

        if (_agent == null)
        {
            Debug.LogError("Nav Mesh Agent is null!");
        }
        _agent.autoBraking = false;
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_agent.pathPending)
            Move();
    }
    private void Move()
    {
        _destination = 1;
       _agent.destination = _points[_destination].position;
    }
}
