using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter1Manager : MonoBehaviour
{
    /* 条件
     * 1. 新しくクラスを作らないこと
     * 2. Chapter1ManagerがFoo.StartLog()を呼び出す
     * 3. 各クラスにフィールドを新しく追加しないこと
     * 4. 各クラスが持てる他クラスの参照は1つまで、かつ呼び出せるメソッドは1つまでとする
     */
    /* 実装
     * 1. Foo.StartLog()を呼び出されたとき、
     * 　　"FooBarBuzz"という文字列をコンソールに表示する
     */

    [SerializeField] private Foo _foo = default;
    private void Start() {
        _foo.StartLog();
    }
}
