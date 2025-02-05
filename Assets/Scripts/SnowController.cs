using UnityEngine;

public class SnowController : MonoBehaviour
{
    [SerializeField] private GameObject _snow;

    [SerializeField] private float _frequency;

    private float _timer;
    private int _letItSnow = 0;
    
    private void Update()
    {
        RandomSnow();
    }

    private void RandomSnow()
    {
        _timer += Time.deltaTime;

        if (_timer > _frequency)
        {
            _letItSnow = Random.Range(0, 2);

            _timer = 0;
        }

        if (_letItSnow == 1)
            _snow.SetActive(true);
    }
}
