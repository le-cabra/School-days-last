using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class movingMiniGame : MonoBehaviour
{
    [SerializeField]
    private PhotonView pv;

    void Start()
    {
        
    }

    void Update()
    {
        if (pv.IsMine)
        {
            //Debug.Log("Função pegou jogador");
            if (Input.GetKey(KeyCode.W))
            {
                
                Debug.Log("Pulo");
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Translate((-17f * Time.deltaTime), 0, 0);
                Debug.Log("Esquerda");
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Translate((17f * Time.deltaTime), 0, 0);
                Debug.Log("Direita");
            }
        }
    }
}
