using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private Transform ruta;
    private NavMeshAgent agent;
    private Vector3 destinoActual;//Marca el destino al cual tenemos que ir

    List<Vector3> listadoPuntos= new List<Vector3> ();

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent> ();
        //Voy recorriendo todos los puntos que tiene mi ruta
        foreach (Transform punto in ruta)
        {
            //Y los añado en mi lista
            listadoPuntos.Add(punto.position);
        }
        CalcularDestino();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PatrullaryEsperar());
    }

    private IEnumerator PatrullaryEsperar()
    {
        agent.SetDestination(destinoActual);
        yield return null;
        
    }

    private void CalcularDestino()
    {
        destinoActual=listadoPuntos[0];
    }
}
