using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    [SerializeField]
    private Player main;




    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        main.PlayerAnimation = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void EjecutarAtaque()
    {
        anim.SetBool("AttackP", true);
    }

    private void PararAtaque()
    {
        anim.SetBool("AttackP", false);
    }
}
