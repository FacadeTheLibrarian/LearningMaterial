using UnityEngine;
using UnityEngine.UI;

internal sealed class GaugeWrapper : MonoBehaviour {
    [SerializeField] private Image _image = default;
    private float _rawFillAmount = 0.0f;

    public float fillAmount {
        get { return _image.fillAmount; }
        set {
            _rawFillAmount = value;
            _image.fillAmount = _rawFillAmount;
        }
    }
}
