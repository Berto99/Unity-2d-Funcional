using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public Transform player_posc;
    public float speed;
    public float distancia_frenado;
    public float distancia_retraso;

    public Transform punto_distancia;
    public GameObject bala;
    private float tiempo;


    // Start is called before the first frame update
    void Start()
    {
        player_posc = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        //movimiento
        #region
        if (Vector2.Distance(transform.position, player_posc.position)>distancia_frenado)
        {
            transform.position = Vector2.MoveTowards(transform.position, player_posc.position, speed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, player_posc.position) < distancia_retraso)
        {
            transform.position = Vector2.MoveTowards(transform.position, player_posc.position, -speed * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, player_posc.position) < distancia_frenado && Vector2.Distance(transform.position, player_posc.position) > distancia_retraso)
        {
            transform.position = transform.position;
        }
        #endregion

        //flip
        #region
        if (player_posc.position.x>this.transform.position.x)
        {
            this.transform.localScale = new Vector2(-0.012f, 0.012f);
        }
        else
        {
            this.transform.localScale = new Vector2(0.012f, 0.012f);
        }

        #endregion

        //disparo
        #region
        tiempo += Time.deltaTime;

        if (tiempo>=2)
        {
            Instantiate(bala,punto_distancia.position,Quaternion.identity);
            tiempo= 0;
        }

        #endregion

    }
}
