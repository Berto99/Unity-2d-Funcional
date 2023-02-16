using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Animator animator;
    public Rigidbody2D rb2d;
    public Transform jugador;
    private bool mirandoDerecha = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator=GetComponent<Animator>();
        rb2d=GetComponent<Rigidbody2D>();
        jugador=GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void tomarDano()
    {

    }


}
