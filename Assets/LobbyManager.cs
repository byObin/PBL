using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public Button loginBtn;
    public Text IDtext;
    public Text ConnectionStatus;

    void Awake() => Screen.SetResolution(960, 540, false);


    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        loginBtn.interactable = false;
        ConnectionStatus.text = "Connecting to Master Server...";
    }


    public void Connect()
    {
        if (IDtext.text.Equals(""))
        {
            return;
        }
        else
        {
            PhotonNetwork.LocalPlayer.NickName = IDtext.text;
            loginBtn.interactable = false;
            if (PhotonNetwork.IsConnected)
            {
                ConnectionStatus.text = "connecting to room...";
                PhotonNetwork.JoinRandomRoom();
            }
            else
            {
                ConnectionStatus.text = "Offline : failed to connect.\nreconnecting...";
                PhotonNetwork.ConnectUsingSettings();
            }

        }

    }
    public override void OnConnectedToMaster()
    {
        loginBtn.interactable = true;
        ConnectionStatus.text = "Online : connected to master server";
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        loginBtn.interactable = false;
        ConnectionStatus.text = "Offline : failed to connect.\nreconnecting...";
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        ConnectionStatus.text = "No empty room. creating new room...";
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = 4 });
    }
    public override void OnJoinedRoom()
    {
        ConnectionStatus.text = "Success to join room";
        PhotonNetwork.LoadLevel("ChatMain");
    }
}