using UnityEngine;
using TMPro;

public class FpsController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _fpsText;
    [SerializeField] GameObject _mark;

    private float _pollingTime = 1f;
    private float _time;
    private int _frameCount;

    private bool _fpsEnable = false;

    private void Update()
    {
        if (_fpsEnable) 
        {
            ShowFPS();
        }
        SwitchMark();
    }

    /// <summary>
    /// Включает и отключает отображение FPS
    /// </summary>
    public void FpsOnOff() 
    {
        _fpsEnable = !_fpsEnable;
    }

    private void ShowFPS()
    {
        _time += Time.deltaTime;

        _frameCount++;

        if (_time >= _pollingTime)
        {
            int frameRate = Mathf.RoundToInt(_frameCount / _time);
            _fpsText.text = $"FPS: {frameRate}";

            _time -= _pollingTime;
            _frameCount = 0;
        }
    }

    private void SwitchMark() 
    {
        if (_fpsEnable)
        {
            _mark.SetActive(true);
            _fpsText.gameObject.SetActive(true);
        }
        else 
        {
            _mark.SetActive(false);
            _fpsText.gameObject.SetActive(false);
        }            
    }
}
