using UnityEngine;

public class TransparentController : MonoBehaviour
{
    [SerializeField] private Material[] _transparents;

    private Color[] _color;

    private float _alphaNormal = 1;
    private float _alphaTransparent = 0.5f;

    private int _arrayLenght;

    private bool _objectTransparent;

    private void Start()
    {
        _arrayLenght = _transparents.Length;

        SetLengthOfTheArrays();
    }    

    /// <summary>
    /// Делает объект прозрачным или возвращает непрозрачность
    /// </summary>
    public void ChangeTransparent()
    {
        if (!_objectTransparent)
        {
            for (int i = 0; i < _arrayLenght; i++)
            {
                _color[i].a = _alphaTransparent;
                _transparents[i].color = _color[i];
            }

            _objectTransparent = true;
        }
        else
        {
            for (int i = 0; i < _arrayLenght; i++)
            {
                _color[i].a = _alphaNormal;
                _transparents[i].color = _color[i];
            }

            _objectTransparent = false;
        }
    }
    
    private void SetLengthOfTheArrays()
    {
        _color = new Color[_transparents.Length];

        for (int i = 0; i < _transparents.Length; i++)
        {
            _color[i] = _transparents[i].color;
        }
    }
}
