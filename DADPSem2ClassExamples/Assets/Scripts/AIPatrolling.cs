using UnityEngine;

public class AIPatrolling : MonoBehaviour
{

    private UnityEngine.AI.NavMeshAgent agent;
    public Transform[] patrolPoints;
    private int currentPoint = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            currentPoint ++;

//            if (currentPoint)
        }
    }
}
