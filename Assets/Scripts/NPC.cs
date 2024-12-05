using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private Outline outline;

    [SerializeField] private DialogaSO dialogo;
    [SerializeField] private Texture2D cursorNPC;
    [SerializeField] private Texture2D cursorPorDefecto;
    [SerializeField] private float tiempoRotacion;

    //Este o no este el script habilitado, el awake se lanza, el start no.
    private void Awake()
    {
        outline = GetComponent<Outline>();
    }
    // Start is called before the first frame update
    
    public void Interactuar(Transform interactuador)
    {
        transform.DOLookAt(interactuador.position, tiempoRotacion, AxisConstraint.Y).OnComplete(()=> DialogoManager.dialogo.IniciarDialogo(dialogo));//Cuando se complete la accion del tween con la expresion lambda realiza lo que queremos hacer.
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

