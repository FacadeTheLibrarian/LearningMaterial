using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter4Manager : MonoBehaviour
{
    /* 条件
     * 1. ゲージとは、画面中央の長方形のことである
     * 　 ゲージは0.0f ~ 1.0fの値を持ち、0.0fが左端、1.0fが右端を表す
     * 2. このChapterでは、増減の値は0.1fとし、FLUCTUATIONに定義する
     * 3. ゲージを扱うとき、"Model"クラスには"GaugeValue"、"View"クラスには"GaugeWrapper"クラスを使うこと
     * 　 使用するべき各クラスは、クラスの内容を確認してはいけない(ファイルを開いてはいけない)
     * 4. 既存の定数、フィールドを上書きしないこと
     * 6. "Model", "View", "Presenter" クラスを使用して実装すること
     * 　 したがって、処理を一つのクラスで行っている場合不正解とする
     * 7. 増減においてある処理をしている場合加点する
    */
    /* マネージャクラスの動作
     * 実装
     * 1. キーボードの'A'が押されたときゲージを左に、'D'が押されたときゲージを右に動かす
     */

    private const float FLUCTUATION = 0.1f;
    [SerializeField] private GaugeModel _model = default;

    private void Update() {
        
    }
}
