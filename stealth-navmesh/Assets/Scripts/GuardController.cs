using UnityEngine;
using UnityEngine.AI;


public class GuardController : MonoBehaviour
{ 
    public NavMeshAgent agent;
    public Transform pointA;
    public Transform pointB;
    public Transform player;

    private MeshRenderer guardColor;
    private bool onPatrol;

    // Update is called once per frame
    private void Start()
    {
        guardColor = GetComponent<MeshRenderer>();
        onPatrol = true;
    }
    private void Update()
    {
        if(!onPatrol)
            agent.SetDestination(player.position);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Point A")
        {
            Debug.Log("Going B");
            agent.SetDestination(pointB.position);

        }
        else if (other.gameObject.tag == "Point B")
        {
            Debug.Log("Going A");
            agent.SetDestination(pointA.position);
        }
    }

    public void ReturnToPatrol()
    {
        onPatrol = true;
        guardColor.material.color = Color.white;
        agent.SetDestination(pointA.position);

    }

    public void EnemySpotted()
    {
        onPatrol = false;
        guardColor.material.color = Color.red;
    }
}
