using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 暗号解読機
/// </summary>
public class Decrypter : MonoBehaviour
{
    /* 暗号の解読方法
    * ※平文は必ず小文字アルファベットと半角スペースのみとする
    * 準備
    * 1. 小文字アルファベットと半角スペースに0から26までの数字をふる
    * 
    * 実装
    * 1. 暗号文と鍵のセットをEncryptionData型で得る
    * 2. 暗号文を一文字ずつ数字に変換する
    * 3. 鍵を一文字ずつ数字に変換する
    * 4. 変換した暗号文から変換した鍵を引く
    * 5. 0を下回った場合、26に戻って計算する
    * 6. 得た数列を対応するアルファベットと半角スペースに変換する
    * 7. 変換した文をDebug.Logで表示する
    * 8. 変換した文をstring型で返却する
    */
}
