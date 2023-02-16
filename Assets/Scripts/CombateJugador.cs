using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombateJugador : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float maximaVida;
    [SerializeField] private BarradeVida barradeVida;
    // Start is called before the first frame update
    void Start()
    {
        vida = maximaVida;
        barradeVida.inicializarBarraDeVida(vida);
    }

    public void tomarDano(float dano)
    {
        vida -= dano;
        barradeVida.cambiarVidaActual(vida);
        if (vida<=0)
        {
            Destroy(gameObject);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
