using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent;

    public GameObject target;

    private void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    private void Seek(Vector3 location)
    {
        agent.SetDestination(location);
    }

    private void Flee(Vector3 location)
    {
        Vector3 fleeVector = location - this.transform.position;
        //  agent.SetDestination(this.transform.position - fleeVector);
        agent.SetDestination(fleeVector);
    }

    // Update is called once per frame
    private void Update()
    {
        // Seek(target.transform.position);
        Flee(target.transform.position);
    }
}
