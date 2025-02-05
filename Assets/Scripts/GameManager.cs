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
    /// ������������� ����, ���������.
    /// </summary>
    public void loadDefeat()
    {
        _pauseGame.SetOrRemovePause();
        _gameOverPanel.SetActive(true);
        _OptionButton.interactable = false;
    }

    /// <summary>
    /// ������������� ����, ������.
    /// </summary>
    public void LoadVictory()
    {
        _pauseGame.SetOrRemovePause();
        _victoryPanel.SetActive(true);
        _OptionButton.interactable = false;
    }

    /// <summary>
    /// ������������� ������� �������
    /// </summary>
    public void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// ��������� ��������� �������
    /// </summary>
    /// <param name="level">����� ������</param>
    public void LoadLevel(int level) 
    {
        SceneManager.LoadScene(level);
    }

    /// <summary>
    /// ��������� ������ �������
    /// </summary>
    public void StartGame() 
    {
        GameStarted = true;
    }

    /// <summary>
    /// ��������� ����
    /// </summary>
    public void ExitTheGame()
    {
        Application.Quit();
    }
}
