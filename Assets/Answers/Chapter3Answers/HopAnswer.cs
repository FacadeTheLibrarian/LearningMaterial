using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HopAnswer : MonoBehaviour
{
    public event Action OnHop = default;
    private const string HOP = "Hop";

    [SerializeField] private Chapter3ManagerAnswer _chapter3ManagerAnswer = default;
    private void Awake() {
        _chapter3ManagerAnswer.OnStart += DoHop;
    }
    private void OnDestroy() {
        _chapter3ManagerAnswer.OnStart -= DoHop;
    }
    private void DoHop() {
        Debug.Log(HOP);
        OnHop?.Invoke();
    }
}
