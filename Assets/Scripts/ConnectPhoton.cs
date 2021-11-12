using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using Photon.Pun;
using Photon.Realtime;

public class ConnectPhoton : MonoBehaviourPunCallbacks
{
    //------------------Primeiras aplicações-------------------------
    [SerializeField]
    private GameObject _Painel_Sala;

    [SerializeField]
    private InputField _PlayerName;

    [SerializeField]
    private InputField _RoomName;

    [SerializeField]
    private GameObject[] PlayerObject;

    [SerializeField]
    private int iD;

    [SerializeField]
    private PhotonView pv;



    public void Login()
    {
        PhotonNetwork.NickName = _PlayerName.text;
        Invoke("CreateRoom", 2.0f);

    }

    public void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }


    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 3;
        PhotonNetwork.JoinOrCreateRoom(_RoomName.text, roomOptions, TypedLobby.Default);
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Online");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("OnLobby");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnected");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Join Random Failed");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room");
        print(PhotonNetwork.CurrentRoom.Name);
        print(PhotonNetwork.CurrentRoom.PlayerCount);
        print(PhotonNetwork.NickName);



        //SceneManager.LoadScene("ano1");

        PhotonNetwork.Instantiate(PlayerObject[iD].name, new Vector3((83.63f + (iD * 2)), (6.49f + iD), 119.83f), Quaternion.identity, 0);
        Debug.Log("Player instanciado");
        _Painel_Sala.SetActive(false);

    }

    public void SetID(int id)
    {
        iD = id;
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class publicfloatvelocidade; : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
