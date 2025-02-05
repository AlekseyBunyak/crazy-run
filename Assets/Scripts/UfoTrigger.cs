using UnityEngine;
using UnityEngine.Playables;

public class UfoTrigger : MonoBehaviour
{
    [SerializeField] private MuvementMaze _muvementMaze;
    [SerializeField] private PlayableDirector _playableDirector;
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _maze;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Rigidbody _sphereRB;

    [SerializeField] private float _force;
    [SerializeField] private float _rotationForce;

    private bool _triggerOn = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {            
            _triggerOn = true;
        }
    }

    private void Update()
    {
        if (_triggerOn)
        {
            ActivateTrigger();
        }
    }

    private void ActivateTrigger()
    {
        _muvementMaze._Controllable = false;
        _sphereRB.isKinematic = true;

        _maze.rotation = Quaternion.RotateTowards(_maze.rotation, Quaternion.identity, Time.deltaTime * _rotationForce);

        _player.position = Vector3.MoveTowards(_player.position, _target.position, Time.deltaTime * _force);               

        if (Vector3.Distance(_player.position, _target.position) < 0.1f)
        {
            _playableDirector.Play();

            _muvementMaze._Controllable = true;
            _sphereRB.isKinematic = false;

            Destroy(gameObject);
        }
    }
}
