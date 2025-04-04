using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seta : MonoBehaviour,IInteractuable
{
    private Outline outline;
    [SerializeField] private EventManagerSO eventManager;
    [SerializeField] private Texture2D cursorPorDefecto;
    [SerializeField] private Texture2D cursorSeta;

    [SerializeField] private MisionSO misionAsociada;
    public void Interactuar(Transform interactuador)
    {
        misionAsociada.estadoActual++;//Estamos a un paso mas de completar la mision
        if (misionAsociada.estadoActual < misionAsociada.repeticionesTotales)
        {
            eventManager.ActualizarMision(misionAsociada);
        }
        else
        {
            eventManager.TerminarMision(misionAsociada);
        }
        
        Destroy(this.gameObject);
    }

    private void Awake()
    {
        
        outline = GetComponent<Outline>();
    }
    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorSeta, Vector2.zero, CursorMode.Auto);
        outline.enabled = true;
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(cursorPorDefecto, Vector2.zero, CursorMode.Auto);
        outline.enabled = false;
    }
}
