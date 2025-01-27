using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "DialogaSO")]
public class DialogaSO : ScriptableObject  
{

    [TextArea]
    public string[] frases;
    public float tiempoEntreLetras;
    public bool tieneMision=false;

    public MisionSO mision;
 
}
