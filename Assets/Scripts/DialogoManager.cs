using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoManager : MonoBehaviour
{
    [SerializeField] private GameObject marcos;
    [SerializeField] private TMP_Text textoDialogo;

    private bool escribiendo;//Determina si el sistema esta escribiendo o no
    private int indiceFraseActual;//Marca la frase por la que voy
    
    public static DialogoManager dialogo;

    private void Awake()
    {
        //Si el dialogo esta vacio...
        if(dialogo == null)
        {
            //Reclamo ese espacio para sacar mi dialogo
            dialogo = this;
            //Y no me destruyo entre escenas
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IniciarDialogo(DialogaSO dialogo)
    {
        marcos.SetActive(true);
    }

    //Que el texto aparezca letra por letra
    private void EscribirFrase()
    {

    }

    private void SiguienteFrase()
    {

    }

    private void FinalizarDialogo()
    {

    }
}
