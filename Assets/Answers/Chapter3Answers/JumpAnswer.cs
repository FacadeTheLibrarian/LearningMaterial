using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnswer : MonoBehaviour
{
    private const string JUMP = "Jump";

    [SerializeField] private StepAnswer _step = default;
    private void Awake() {
        _step.OnStep += DoJump;
    }
    private void OnDestroy() {
        _step.OnStep -= DoJump;
    }
    private void DoJump() {
        Debug.Log(JUMP);
    }
}
