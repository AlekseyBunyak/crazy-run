using UnityEngine;

public class TransparentTrigger : MonoBehaviour
{
    [SerializeField] TransparentController _transparentController;
    [SerializeField] GameObject _MountianRoof;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _transparentController.ChangeTransparent();
        }

        _MountianRoof.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _transparentController.ChangeTransparent();
        }

        _MountianRoof.SetActive(true);
    }
}
