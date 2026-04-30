using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class AIMovement : MonoBehaviour
{
    //List of points to traverse 
    [SerializeField] private List<Transform> _points = new List<Transform>();

    //track the destination
    private int _endPoint;

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
    }

    // Update is called once per frame
    void Update()
    {

    }
}
