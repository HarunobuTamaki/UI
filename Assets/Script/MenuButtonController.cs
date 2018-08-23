using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonController : MonoBehaviour {

    //ボタン用シーン遷移メソッド
    public void ChangeScene(string title)
    {
        switch (title)
        {
            case "Title":
                //タイトル画面に遷移
                SceneManager.LoadScene("Title");
                break;
            case "Status":
                //ステータス画面に遷移
                SceneManager.LoadScene("Status");
                break;
            case "Friend":
                //フレンド管理画面に遷移
                SceneManager.LoadScene("Friend");
                break;
            case "Gacha":
                //ガチャ画面に遷移
                SceneManager.LoadScene("Gacha");
                break;
            case "Lobby":
                //ロビー画面に遷移
                SceneManager.LoadScene("Lobby");
                break;
            default:
                SceneManager.LoadScene("Title");
                break;
        }
    }
}
