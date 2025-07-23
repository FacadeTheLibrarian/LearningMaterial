using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarAnswer : MonoBehaviour
{
    private const string BAR = "Bar";
    [SerializeField] private BuzzAnswer _buzz = default;
    public string GetBarBuzz()
    {
        return BAR + _buzz.GetBuzz();
    }
}