using UnityEngine;

public class GlyphTrigger : MonoBehaviour
{
    [SerializeField] private PortalController _portalController;
    [SerializeField] private Material _crystal;
    [SerializeField] private Material _glyph;
    [SerializeField] private GameObject _walls;
    [SerializeField] private GameObject _light;
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        _crystal.DisableKeyword("_EMISSION");
        _glyph.EnableKeyword("_EMISSION");
    }

    private void OnTriggerEnter(Collider other)
    {      
        if (other.CompareTag("Player"))
        {
            _audioSource.Play();

            _light.SetActive(true);
            _crystal.EnableKeyword("_EMISSION");

            _glyph.DisableKeyword("_EMISSION");
            _walls.SetActive(false);

            _portalController.CrystalCount++;
            _portalController.updateText();

            Destroy(gameObject.GetComponent<Collider>());
        }        
    }
}
