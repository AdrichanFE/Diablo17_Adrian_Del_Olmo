using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour,IInteractuable
{
    private Outline outline;
    [SerializeField] private Texture2D cursorCofre;
    [SerializeField] private Texture2D cursorPorDefecto;
    private bool estaSiendoInteractuado = false;

    public void Interactuar(Transform interactuador)
    {
        if (estaSiendoInteractuado)
            return;
        estaSiendoInteractuado = true;
        Destroy(gameObject, 1);
    }



    //Este o no este el script habilitado, el awake se lanza, el start no.
    private void Awake()
    {
        outline = GetComponent<Outline>();
    }
    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorCofre, Vector2.zero, CursorMode.Auto);
        outline.enabled = true;
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(cursorPorDefecto, Vector2.zero, CursorMode.Auto);
        outline.enabled = false;
    }
}
