using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Mision")]
public class MisionSO : ScriptableObject
{
    public string ordenInicial;//La orden con la que inicia la mision.Recoge....
    public string ordenFinal;//La orden con la que acaba la mision. Vuelve a hablar con....

    public bool repetir;//Si la mision tiene varios pasos.
    public int repeticionesTotales;
    [NonSerialized]
    public int estadoActual=0;
    public int indiceMision;//Identificador unico.

   

}
