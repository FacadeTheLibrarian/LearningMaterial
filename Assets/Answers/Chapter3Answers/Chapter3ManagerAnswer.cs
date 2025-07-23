using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3ManagerAnswer : MonoBehaviour
{
    /* 条件
     * 1. 既存の定数を上書きしないこと
     * 2. 各クラスの通信に公開(public)メソッド・公開アクセッサ、静的変数・メソッド等を使わないこと
     * 3. "Hop", "Step", "Jump"クラスのAwakeで他クラスの公開メソッドを呼び出さないこと
     * 4. 各クラスのAwake, Startの内容は1行のみとする
     * 5. "後処理"をしている場合加点する
     */
    /* マネージャクラスの動作
     * 実装
     * 1. Chapter3Manager.Start()が呼び出された時、
     * 　 "Hop", "Step", "Jump" を別にそれぞれコンソールに表示する
     */

    public event Action OnStart = default;

    private void Start() {
        OnStart?.Invoke();
    }
}
