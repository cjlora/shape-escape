using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public SceneController scene;

    private int health = 1;

    // Update is called once per frame
    void Update()
    {
        if (health < 1)
        {
            scene.loseGame();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Guard")
        {
            health--;
        }
        if (other.gameObject.tag == "Exit")
        {
            scene.winGame();
        }
    }
}
