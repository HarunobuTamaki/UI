using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//レア度を列挙型で作成
public enum Rank { normal,rare,ultraRare}

//プレイヤー・モンスターの親クラス
[System.Serializable]
public abstract class CreatureEntity{

    //miniJSONでパースするため、数値型はlongにする
    public string email;
    public long index;
    public string name;
    public long hp;
    public long attack;
    public Rank rank;

}
