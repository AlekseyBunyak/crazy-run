using UnityEngine;

public class SecretDoor : MonoBehaviour
{
    [SerializeField] private Animator _anumator;
    [SerializeField] private AudioSource _audioSource;

    private void OnTriggerEnter(Collider Object)
    {
        if (Object.CompareTag("Player")) 
        {
            _audioSource.Play();
            _anumator.SetBool("Open", true);

            Destroy(gameObject);
        }           
    }
}
