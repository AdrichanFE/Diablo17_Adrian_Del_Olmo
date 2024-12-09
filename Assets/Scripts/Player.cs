using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    [SerializeField] private float distanciaInteraccion;
    private NavMeshAgent agent;
    private Camera cam;

    private Transform ultimoClick;//Guardo la informacion del NPC actual con el que voy a hablar


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cam=Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            Movimiento();
        }
        
        if (ultimoClick&& ultimoClick.TryGetComponent(out NPC npc))
        {
            agent.stoppingDistance = distanciaInteraccion;
            //Comprobar si ha llegado al NPC
            if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
            {
                npc.Interactuar(this.transform);
                ultimoClick = null;  
            }
        }
        else if (ultimoClick)
        {
            agent.stoppingDistance = 0f;
        }
        
    }

    void Movimiento()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                agent.SetDestination(hit.point);
                ultimoClick = hit.transform;
            }
        }
    }
}
