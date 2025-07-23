using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FooAnswer : MonoBehaviour
{
    private const string FOO = "Foo";
    [SerializeField] private BarAnswer _bar = default;
    public void StartLog()
    {
        Debug.Log(FOO + _bar.GetBarBuzz());
    }
}
