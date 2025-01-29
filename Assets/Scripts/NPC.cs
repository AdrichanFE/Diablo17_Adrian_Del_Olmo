using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour,IInteractuable
{
    private Outline outline;
    [SerializeField] EventManagerSO eventManager;
    [SerializeField] private MisionSO misionAsociada;
    [SerializeField] private DialogaSO dialogo;
    [SerializeField] private DialogaSO dialogo2;
    [SerializeField] private Texture2D cursorNPC;
    [SerializeField] private Texture2D cursorPorDefecto;
    [SerializeField] private float tiempoRotacion;
    [SerializeField] private Transform cameraPoint;
    [SerializeField] private GameObject miniMapa;

    private DialogaSO dialogoActual;

    //Este o no este el script habilitado, el awake se lanza, el start no.
    private void Awake()
    {
        outline = GetComponent<Outline>();
        dialogoActual = dialogo;
    }

    private void OnEnable()
    {
        //Me subscribo al evento para estar atento de cuando cambiar el dialogo
        eventManager.OnTerminarMision += CambiarDialogo;
    }

    private void CambiarDialogo(MisionSO misionTerminada)
    {
        if (misionTerminada == misionAsociada)
        {
            dialogoActual = dialogo2;
        }
        if (dialogoActual == dialogo2)
        {
            miniMapa.SetActive(true);
        }
        
    }

    // Start is called before the first frame update

    public void Interactuar(Transform interactuador)
    {
        transform.DOLookAt(interactuador.position, tiempoRotacion, AxisConstraint.Y).OnComplete(()=> DialogoManager.dialogo.IniciarDialogo(dialogoActual,cameraPoint));//Cuando se complete la accion del tween con la expresion lambda realiza lo que queremos hacer.

    }

    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorNPC, Vector2.zero, CursorMode.Auto);
        outline.enabled = true;
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(cursorPorDefecto, Vector2.zero, CursorMode.Auto);
        outline.enabled = false;
    }
}

