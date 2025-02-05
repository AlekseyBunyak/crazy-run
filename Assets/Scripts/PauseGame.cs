using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool _pause = false;
    public bool Pause => _pause;

    /// <summary>
    /// ������ ���� �� ����� ��� ������� � ��
    /// </summary>
    public void SetOrRemovePause() 
    {
        if (!_pause)
        {
            Time.timeScale = 0;
            _pause = true;
        }
        else 
        {
            Time.timeScale = 1;
            _pause = false;
        }
    }
}
