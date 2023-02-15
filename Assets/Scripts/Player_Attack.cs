using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class Player_Attack : MonoBehaviour {
    //Variables para comprobar si ha  pulsado la tecla de atacar y seguir el combo
    private Animator ani;
    public int nroP;
    public bool canP;
    public bool attackJump;
 
    
    // Start is called before the first frame update
    void Start()
    {
        canP = true;
        nroP = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            
            if (canP && nroP<3){
                nroP++;
                gameObject.GetComponent<Animator>().SetInteger("attack",nroP);
                canP = false;
            }

        }

        if ((gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("idle")|| 
             gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("move"))&& nroP==0)
        {
            canP = true;
        }

        if (Input.GetKeyDown("s"))
        {
            gameObject.GetComponent<Animator>().SetBool("attack_down",true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2( 0, -2500f* Time.deltaTime));
            
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            attackJump = false;
            gameObject.GetComponent<Animator>().SetBool("attack_down", false);
        }
        
    }

    public void verificarCombo()
    {
        if (canP)
        {
            canP = false;
            nroP = 0;
            gameObject.GetComponent<Animator>().SetInteger("attack", nroP);
        }
    }

    public void canPTrue()
    {
        canP = true;
        gameObject.GetComponent<Animator>().SetBool("attack_down",false);
    }
    
    
}
