using UnityEngine;

public class TouchInput : MonoBehaviour
{

    /// <summary>
    /// ����� ���������� deltaPosition ������� ������
    /// </summary>
    /// <returns></returns>
    public Vector2 GetTouchPosition()
    {
        if(Input.touchCount > 0) 
        {
          return Input.GetTouch(0).deltaPosition;
        }
        else
            return Vector2.zero;
    }
    
    /// <summary>
    /// ����� ��������� ���� �� ������ ������� ������
    /// </summary>
    /// <returns>�� ��� ���, ������ ��� ����</returns>
    public bool IsThereTouchOnScreen() 
    {
        if (Input.touchCount > 0)
            return true;
        else
            return false;
    }
}
