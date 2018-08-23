using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MiniJSON;
using System.IO;
using System.Linq;

public class FriendDAO : MonoBehaviour {

    public List<FriendEntity> friendList = new List<FriendEntity>();

    public List<FriendEntity> FindAll()
    {
        //JSONファイル名
        string src = "friends";

        //Resourceフォルダのテキストファイルを読み込み
        var textAsset = Resources.Load(src) as TextAsset;

        //JSONテキストの読み込み
        var jsonText = textAsset.text;

        //文字列をJSONに合わせて構成された辞書型に変換
        IList jsonDic = (IList)Json.Deserialize(jsonText);

        //件数分JSONデータを変換
        foreach(IDictionary json in jsonDic)
        {
            //インスタンスに値を代入
            FriendEntity friend = new FriendEntity();
            friend.email = (string)json["email"];
            friend.index = (long)json["index"];
            friend.name = (string)json["name"];
            friend.hp = (long)json["hp"];
            friend.attack = (long)json["attack"];
            //リストに追加
            friendList.Add(friend);
        }
        return friendList;
    }

    //フレンドリストからインデックス番号で1件取得
    public FriendEntity Find(int index)
    {
        //フレンドデータを全件取得
        FindAll();
        //LinQで1件取得して返り値に格納
        var friend = friendList.First(f => f.index == index);
        return friend;
    }

}
