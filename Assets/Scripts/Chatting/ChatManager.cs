using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using UnityEngine.SceneManagement;


public class ChatManager : MonoBehaviourPunCallbacks
{
    
    public Button sendBtn;
    public Text chatLog;
    public Text chattingList;
    public InputField input;
    ScrollRect scroll_rect = null;
    string chatters;

    //void Awake() => Screen.SetResolution(960, 540, false);


    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.IsMessageQueueRunning = true;
        scroll_rect = GameObject.FindObjectOfType<ScrollRect>();
    }

    public void SendButtonOnClicked()
    {
        if (input.text.Equals("")) { Debug.Log("Empty"); return; }
        string msg = string.Format("[{0}] {1}", PhotonNetwork.LocalPlayer.NickName, input.text);
        photonView.RPC("ReceiveMsg", RpcTarget.OthersBuffered, msg);
        ReceiveMsg(msg);
        input.ActivateInputField(); // 반대는 input.select(); (반대로 토글)
        input.text = "";
    }

    void Update()
    {
        chatterUpdate();
        if (Input.GetKeyDown(KeyCode.Return) && !input.isFocused) SendButtonOnClicked();
    }

    void chatterUpdate()
    {
        chatters = "Player List\n";
        foreach (Photon.Realtime.Player player in PhotonNetwork.PlayerList)
        {
            chatters += player.NickName + "\n";
        }
        chattingList.text = chatters;
    }

    public void backToChat()
    {
        SceneManager.LoadScene("Planet1");
    }

    public void LeaveRoom() => PhotonNetwork.LeaveRoom();

    public void Disconnect() => PhotonNetwork.Disconnect();

    public override void OnDisconnected(DisconnectCause cause)
    {
        SceneManager.LoadScene("Planet1");
    }

    [PunRPC]
    public void ReceiveMsg(string msg)
    {
        chatLog.text += "\n" + msg;
        scroll_rect.verticalNormalizedPosition = 0.0f;
    }
}
