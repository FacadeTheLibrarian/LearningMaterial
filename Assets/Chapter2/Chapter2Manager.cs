using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// マネージャクラス
/// </summary>
public class Chapter2Manager : MonoBehaviour
{
    /* 条件
     * 1. 新しいクラスの追加は一つまでとする
     * 2. 各クラスの通信は、メソッドのみとする(公開フィールドやアクセッサを使わないこと)
     * 3. EncryptionDataの上書きは禁止とする
     */
    /* マネージャクラスの動作
     * 準備
     * 1. シーン上のボタンを押すと OnButtonClick が動作(発火)する
     * 実装
     * 1. OnButtonClick で _plainText を Encrypter に与えて暗号化し、 EncriptionData型の値を得る
     * 2. 得たEncryptionData型の値を、アクセッサを使い _key, _cipher それぞれに代入する
     * 3. 同じく得た値をを Decrypter に与え復号しstring型の平文を得る
     * 4. 得た平文を _decrypted に代入する
     */
    [SerializeField] private string _plainText = default;
    [SerializeField] private string _key = default;
    [SerializeField] private string _cipher = default;
    [SerializeField] private string _decrypted = default;
    public void OnButtonClick() {
        
    }
}
