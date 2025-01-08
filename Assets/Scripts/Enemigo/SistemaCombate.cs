using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SistemaCombate : MonoBehaviour
{
    [SerializeField] private Enemigo main;
    [SerializeField] private float velocidadCombate;
    [SerializeField] private float distanciaAtaque;
    [SerializeField] private NavMeshAgent agent;
    


    //1.Define una velocidad de combate.
    //2. Referencia al NavMeshAgent con el que nos vamos a mover.
    //3. Marca como destino constantemente (Update()) al target. (Definido en main)



    private void Awake()
    {
        main.Combate = this;
       
    }

    //Este se activa cada vez que habilitas
    private void OnEnable()
    {
        agent.speed = velocidadCombate;
        agent.stoppingDistance = distanciaAtaque;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        agent.SetDestination(main.MainTarget.position);
    }
}
