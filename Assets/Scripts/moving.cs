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

    public float velocidade = 5f;



    void Start()
    {
        pv.GetComponent<PhotonView>();
        Debug.Log("Conectando no photon" + pv);

    }


    void Update()
    {
        if (pv.IsMine)
        {
            Debug.Log("Função pegou jogador");
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Translate(0, 0, (5f * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Translate(0, 0, (-5f * Time.deltaTime));
            }
        }
    }
}
