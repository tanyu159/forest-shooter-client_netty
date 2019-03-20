﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 开始游戏请求类-房间面板房主点击开始游戏后的请求
/// </summary>
public class StartGameRequest : BaseRequest {
    private RoomPanel _roomPanel;
    public override void Awake()
    {
        //设置RequestCode与ActionCode
        
        requestType = RequestType.Game;
        actionType = ActionType.StartGame;
        base.Awake();
    }

    private void Start()
    {
        _roomPanel = this.GetComponent<RoomPanel>();
    }
    /// <summary>
    /// 发送开始游戏请求
    /// </summary>
    public  void SendRequest(string p2Name)
    {
        string data;
        if (p2Name != null && p2Name != "")
        {
            data = p2Name;
        }
        else {
            data = "EMPTY";
        }
        Request startGameRequest = new Request((int)requestType, (int)actionType, data);
        byte[] dataBytes = ConverterTool.SerialRequestObj(startGameRequest);
        GameFacade.Instance.ClientManager.SendMsgToServer(dataBytes);
        
    }
    /// <summary>
    /// 处理开始游戏请求的响应
    /// </summary>
    /// <param name="data"></param>
    public override void OnResponse(string data)
    {
        ReturnType returnType= (ReturnType)(int.Parse(data));
        if (returnType == ReturnType.Successful)
        {
            //剩下交给RoomPanel来进行
            _roomPanel.HandleStartGameResponse(true);
        }
        else if (returnType == ReturnType.Failed)
        {
            //剩下交给RoomPanel来进行
            _roomPanel.HandleStartGameResponse(false);
        }
    }

}
