using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendStatusController : MonoBehaviour {

    //表示したいプレイヤー(フレンド)の番号
    public int index = 0;
    //FriendDAOクラスの読み込み
    private GameObject friendDAO;
    //フレンドリストを格納
    private FriendEntity friend;
    //スプライト画像を格納
    private Sprite mainImageSprite;

	// Use this for initialization
	void Start () {
        //friendDAOを取得
        friendDAO = GameObject.Find("FriendDAOController");
        //フレンドリストを1件取得
        friend = friendDAO.GetComponent<FriendDAO>().Find(index);
        //フレンドのスプライト画像を取得
        mainImageSprite = Resources.Load<Sprite>(friend.MainImage());
        //子オブジェクトのテキストを取得
        Text nameText = gameObject.transform.Find("NameText").GetComponent<Text>();
        Text hpLabel = gameObject.transform.Find("HPLabel").GetComponent<Text>();
        Text nameLabel = gameObject.transform.Find("NameLabel").GetComponent<Text>();
        Text attackLabel = gameObject.transform.Find("AttackLabel").GetComponent<Text>();
        Text rankLabel = gameObject.transform.Find("RankLabel").GetComponent<Text>();
        Image mainImage = gameObject.transform.Find("MainImage").GetComponent<Image>();

        //UIテキストにステータス表示
        nameText.text = friend.name;
        hpLabel.text = friend.hp.ToString();
        nameLabel.text = friend.name;
        attackLabel.text = friend.attack.ToString();
        rankLabel.text = friend.rank.ToString();
        mainImage.sprite = mainImageSprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
