using UnityEngine;

public class TouchInput : MonoBehaviour
{

    /// <summary>
    /// Метод возвращает deltaPosition касания экрана
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
    /// Метод проверяет есть ли сейчас касания экрана
    /// </summary>
    /// <returns>да или нет, правда или ложь</returns>
    public bool IsThereTouchOnScreen() 
    {
        if (Input.touchCount > 0)
            return true;
        else
            return false;
    }
}
