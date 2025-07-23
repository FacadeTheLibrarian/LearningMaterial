using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepAnswer : MonoBehaviour
{
    public event Action OnStep = default;
    private const string STEP = "Step";

    [SerializeField] private HopAnswer _hop = default;
    private void Awake() {
        _hop.OnHop += DoStep;
    }
    private void OnDestroy() {
        _hop.OnHop -= DoStep;
    }
    private void DoStep() {
        Debug.Log(STEP);
        OnStep?.Invoke();
    }
}
