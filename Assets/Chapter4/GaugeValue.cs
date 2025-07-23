using UnityEngine;

internal sealed class GaugeValue : MonoBehaviour
{
    private float _value = 0.0f;
    private float _rawValue = 0.0f;

    public GaugeValue(float initialValue = 0.0f) {
        _value = initialValue;
        _rawValue = initialValue;
    }

    public float Value {
        get { return _value; }
        set { 
            _rawValue += value;
            _value = Mathf.Clamp01(_rawValue);
        }
    }
}
