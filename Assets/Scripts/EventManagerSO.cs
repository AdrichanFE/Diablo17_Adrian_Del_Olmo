using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Event Manager")]
public class EventManagerSO : ScriptableObject
{
    public event Action<MisionSO> OnNuevaMision;//EVENTO
    public event Action<MisionSO> OnActualizarMision;
    public event Action<MisionSO> OnTerminarMision;
    public void NuevaMision(MisionSO mision)
    {
        //Aqui lanzo la notificacion (el evento) por si a alguien le interesa
        //?.:Invocacion Segura. Se asegura de que haya subcriptores 
        OnNuevaMision?.Invoke(mision);
    }

    public void ActualizarMision(MisionSO mision)
    {
        //Aqui lanzo la notificacion (el evento) por si a alguien le interesa
        //?.:Invocacion Segura. Se asegura de que haya subcriptores 
        OnActualizarMision?.Invoke(mision);
    }

    public void TerminarMision(MisionSO mision)
    {
        //Aqui lanzo la notificacion (el evento) por si a alguien le interesa
        //?.:Invocacion Segura. Se asegura de que haya subcriptores 
        OnTerminarMision?.Invoke(mision);
    }
}
