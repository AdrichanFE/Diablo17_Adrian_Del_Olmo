using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField] private float distanciaInteraccion;
    private NavMeshAgent agent;
    private Camera cam;

    private NPC npcActual;//Guardo la informacion del NPC actual con el que voy a hablar


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cam=Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        if (npcActual)
        {
            //Comprobar si ha llegado al NPC
            if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
            {
                npcActual.Interactuar(this.transform);
                npcActual = null;
                agent.isStopped = true;
                agent.stoppingDistance = 0;
            }
        }
        
    }

    void Movimiento()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Para saber a que a impactado
                if (hit.transform.TryGetComponent(out NPC npc))
                {
                    npcActual = npc;
                    agent.stoppingDistance = distanciaInteraccion;
                }
                agent.SetDestination(hit.point);
            }
        }
    }
}
