using UnityEngine;

public class UfoLamps : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private float _timeInterval;

    private float _timer;
    private bool _emission;

    private void Start()
    {
        _timer = _timeInterval;
    }

    private void Update()
    {
        LampsFlickers();
    }

    private void LampsFlickers()
    {
        if (_timer <= 0)
        {
            if (!_emission)
            {
                _material.EnableKeyword("_EMISSION");
                _emission = true;
            }
            else
            {
                _material.DisableKeyword("_EMISSION");
                _emission = false;
            }

            _timer = _timeInterval;
        }

        _timer -= Time.deltaTime;
    }
}
