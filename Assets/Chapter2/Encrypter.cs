using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 暗号生成機
/// </summary>
public class Encrypter : MonoBehaviour
{
    /* 暗号の作り方
     * ※平文は必ず小文字アルファベットと半角スペースのみとする
     * 準備
     * 1. 小文字アルファベットと半角スペースに0から26までの数字をふる
     * 
     * 実装
     * 1. 平文をstringで得る
     * 2. 平文の文字の長さ分、数字を振ったアルファベットと半角スペースの中からランダムに選ぶ
     * 　　これを鍵とする
     * 3. 平文を一文字ずつ数字に変換する
     * 4. 変換した平文とカギを一文字ずつ足す
     * 5. 26を超えた分は0に戻って計算する
     * 6. 得た数列を対応するアルファベットと半角スペースに変換する
     * 　　これを暗号文とする
     * 8. 暗号文をDebug.Logで表示する
     * 9. 暗号文と鍵のセットをEncryptionData型で返却する
     */
}
