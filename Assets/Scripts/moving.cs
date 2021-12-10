using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class moving : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private PhotonView pv;
    [SerializeField]
    private Text nome;

    public float velocidade = 15f;
    public Vector3 jump;
    public float jumpForce = 9.0f;

    public bool isGrounded;
    Rigidbody rb;




    void Start()
    {
        pv.GetComponent<PhotonView>();
        Debug.Log("Conectando no photon" + pv);

        {
            rb = GetComponent<Rigidbody>();
            jump = new Vector3(0.0f, 9.0f, 0.0f);
        }
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

   
              
      


void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        
        if (pv.IsMine)
        {
            //Debug.Log("Função pegou jogador");
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(0, 0, (25f * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.transform.Translate(0, 0, (-25f * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Translate((25f * Time.deltaTime), 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Translate((-25f * Time.deltaTime), 0, 0);
            }

        }

        if(transform.position.x > 43.24628f)
        {
            transform.position = new Vector3(5.2f, transform.position.y, 117);
        }
        
        else if (transform.position.x <-5.2f)
        
        {
            transform.position = new Vector3(43.24628f, transform.position.y, 117);
        }
    }
   
    
}