using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PauseGame _pauseGame;
    [SerializeField] private Timer _timer;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private GameObject _victoryPanel;
    [SerializeField] private Button _OptionButton;
    [SerializeField] private TextMeshProUGUI _aplicationVersion;

    public bool GameStarted = false;

    private void Start()
    {
        if(_aplicationVersion != null) 
        {
            _aplicationVersion.text = $"Version: {Application.version}";
        }        
    }

    /// <summary>
    /// Останавливает игру, поражение.
    /// </summary>
    public void loadDefeat()
    {
        _pauseGame.SetOrRemovePause();
        _gameOverPanel.SetActive(true);
        _OptionButton.interactable = false;
    }

    /// <summary>
    /// Останавливает игру, победа.
    /// </summary>
    public void LoadVictory()
    {
        _pauseGame.SetOrRemovePause();
        _victoryPanel.SetActive(true);
        _OptionButton.interactable = false;
    }

    /// <summary>
    /// Перезагружает текущий уровень
    /// </summary>
    public void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// загружает указанный уровень
    /// </summary>
    /// <param name="level">номер уровня</param>
    public void LoadLevel(int level) 
    {
        SceneManager.LoadScene(level);
    }

    /// <summary>
    /// Запускает отсчет времени
    /// </summary>
    public void StartGame() 
    {
        GameStarted = true;
    }

    /// <summary>
    /// Закрывает игру
    /// </summary>
    public void ExitTheGame()
    {
        Application.Quit();
    }
}
