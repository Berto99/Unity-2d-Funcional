using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed;
    private Rigidbody2D m_rig;
    public shot tiro;
    public Transform player_posc;
    public Vector2 posicion;

    // Start is called before the first frame update
    void Start()
    {
        player_posc = GameObject.Find("Player").transform;
    }

    void Update()
    {
        if (player_posc.position.x > this.transform.position.x)
        {
            m_rig = GetComponent<Rigidbody2D>();
            m_rig.AddForce(Vector2.right * speed);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            Invoke("Destruir_", 1f);
        }

        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX= true;
            m_rig = GetComponent<Rigidbody2D>();
            m_rig.AddForce(Vector2.left * speed);
            Invoke("Destruir_", 1f);
        }

        
    }

    // Update is called once per frame
    void Destruir_()
    {
        Destroy(this.gameObject);
    }

    
}
