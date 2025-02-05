using UnityEngine;

public class LampsFlickering : MonoBehaviour
{
    [SerializeField] float _intencityStart;
    [SerializeField] float _intencityMax;
    [SerializeField] float _intencityMin;
    [SerializeField] float _intecityTemp;

    private Light _light;
    private bool _glowMax;

    private void Start()
    {
        _light = GetComponent<Light>();

        _glowMax = false;
        _light.intensity = _intencityStart;
    }

    private void FixedUpdate()
    {
        if (_light.intensity < _intencityMax && !_glowMax)
            _light.intensity += _intecityTemp;
        else
            _glowMax = true;

        if (_light.intensity > _intencityMin && _glowMax)
            _light.intensity -= _intecityTemp;
        else
            _glowMax = false;
    }
}
