using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MuvementMaze : MonoBehaviour
{
    [SerializeField] private TouchInput _touchInput;

    [SerializeField] private float _torqueForce;
    [SerializeField] private float _maxRotation;

    private Rigidbody _rigidbody;

    public bool _Controllable = true;

    private void Start()
    {
        if (_touchInput == null)
            Debug.LogError("TouchInput not specified!");

        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoveMaze();
    }

    private void MoveMaze() 
    {
        if (_touchInput.IsThereTouchOnScreen() && _Controllable)
        {
            float touchPositionX;
            float touchPositionY;

            _rigidbody.isKinematic = false;

            if (Mathf.Abs(_rigidbody.rotation.z) < _maxRotation)
            {
                touchPositionX = _touchInput.GetTouchPosition().x;
            }
            else
            {
                if (_rigidbody.rotation.z > 0 && _touchInput.GetTouchPosition().x < 0 || _rigidbody.rotation.z < 0 && _touchInput.GetTouchPosition().x > 0)
                {
                    touchPositionX = 0f;
                }
                else
                {
                    touchPositionX = _touchInput.GetTouchPosition().x;
                }
            }

            if (Mathf.Abs(_rigidbody.rotation.x) < _maxRotation)
            {
                touchPositionY = _touchInput.GetTouchPosition().y;
            }
            else
            {
                if (_rigidbody.rotation.x > 0 && _touchInput.GetTouchPosition().y > 0 || _rigidbody.rotation.x < 0 && _touchInput.GetTouchPosition().y < 0)
                {
                    touchPositionY = 0f;
                }
                else
                {
                    touchPositionY = _touchInput.GetTouchPosition().y;
                }
            }

            _rigidbody.AddTorque(touchPositionY * _torqueForce, 0f, -touchPositionX * _torqueForce, ForceMode.Force);

            Quaternion rotation = new Quaternion(transform.rotation.x, 0, transform.rotation.z, transform.rotation.w);
            transform.rotation = rotation;
        }
        else
            _rigidbody.isKinematic = true;
    }
}
