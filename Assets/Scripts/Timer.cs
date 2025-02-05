using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timer;
    [SerializeField] private PauseGame _pauseGame;

    [SerializeField] private GameManager _gameManager;

    [SerializeField] private float _timerTime;

    private void Start()
    {
        _timer.text = Mathf.Round(_timerTime).ToString();
    }

    private void Update()
    {
        if (_gameManager.GameStarted)
            UpdateTimer();
    }

    private void UpdateTimer()
    {
       
       if (_timerTime > 0)
       {
            _timerTime -= Time.deltaTime;
            _timer.text = Mathf.Round(_timerTime).ToString();
       }
       else
       {
           _gameManager.loadDefeat();
           _gameManager.GameStarted = false;
       }
    }
}