using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveNinja : MonoBehaviour
{

    public Transform goal;
    NavMeshAgent agent;
    Animator animatorPersonaje;
    public Camera camera;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animatorPersonaje = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.destination = hit.point;
            }
        }
        animatorPersonaje.SetFloat("vertical", transform.InverseTransformDirection(agent.velocity).z);
        animatorPersonaje.SetFloat("horizontal", transform.InverseTransformDirection(agent.velocity).x);
    }
    
}
