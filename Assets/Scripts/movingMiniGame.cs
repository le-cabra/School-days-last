using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class movingMiniGame : MonoBehaviour
{
    [SerializeField]
    private PhotonView pv;

    

    void Update()
    {
        if (pv.IsMine)
        {
            //Debug.Log("Função pegou jogador");
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(0, (17f * Time.deltaTime), 0);

            }
            if (Input.GetKey(KeyCode.S))
            {
                this.transform.Translate(0, (-17f * Time.deltaTime), 0);

            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Translate(0, 0, (-17f * Time.deltaTime));
                Debug.Log("Esquerda");
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Translate(0, 0, (17f * Time.deltaTime));
                Debug.Log("Direita");
            }
        }
    }
}
