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

    //[SerializeField]
    //private PhotonView pv;


    void awake()
    {
        Application.targetFrameRate = 30;
    }
    public void Login()
    {
        PhotonNetwork.NickName = _PlayerName.text;
        CreateRoom();
        //CreateRoom();
        //Invoke("OnJoinedRoom", 1.0f);
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
        Debug.Log("CreateRoom");

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
       //print(PhotonNetwork.CurrentRoom.Name);
       //print(PhotonNetwork.CurrentRoom.PlayerCount);
       //print(PhotonNetwork.NickName);

        PhotonNetwork.Instantiate(PlayerObject[iD].name, new Vector3(1105.333f, 15.81229f, -437.0499f), Quaternion.identity, 0);
        Debug.Log("Player instanciado");
        _Painel_Sala.SetActive(false);
    }

    public void SetID(int id)
    {
        iD = id;
        Debug.Log("ID selecionado: " + id);
    }
}