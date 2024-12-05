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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
