using UnityEngine;
using TMPro;
using UnityEngine.Playables;

public class PortalController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _countText;
    [SerializeField] private PlayableDirector _timeLine;

    public int CrystalCount = 0;

    private bool _portalIsActiv = false;

    private void Start()
    {
        updateText();
    }

    private void Update()
    {
        if (!_portalIsActiv)
        {
            if (CrystalCount == 2)
            {
                _timeLine.Play();

                _portalIsActiv = true;
            }
        }       
    }

    /// <summary>
    /// Обновляет счет в текстовом поле с задачей
    /// </summary>
    public void updateText()
    {
        _countText.text = $"Активировать кристаллы:\n {CrystalCount} из 2";
    }
}
