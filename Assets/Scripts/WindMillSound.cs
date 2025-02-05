using UnityEngine;

public class WindMillSound : MonoBehaviour
{
    [SerializeField] private AudioSource _WindMillAudio;
    [SerializeField] private GameManager _GameManager;
    [SerializeField] private PauseGame _pauseGame;

    private void Update()
    {
        if(!_pauseGame.Pause) 
        {
            if (!_WindMillAudio.isPlaying)
            {
                _WindMillAudio.Play();
            }
        }
        else
            _WindMillAudio.Stop();
    }
}
