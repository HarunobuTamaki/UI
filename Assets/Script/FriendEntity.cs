using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FriendEntity :CreatureEntity {
    
    //メインイメージパス作成
    public string MainImage()
    {
        string result = "we_characters/friend" + this.index.ToString("00");
        return result;
    }

    //サムネイルイメージパス作成
    public string Thumbnail()
    {
        string result = "we_characters/th_friend" + this.index.ToString("00");
        return result;
    }

}
