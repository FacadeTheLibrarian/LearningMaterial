using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaugeView : MonoBehaviour
{
    //GaugeWarpperは、GaugeWrapper.fillAmountで値を取得・設定することができる
    [SerializeField] private GaugeWrapper _gaugeWrapper = default;
}
