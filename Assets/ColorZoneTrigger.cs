using UnityEngine;

public class ColorZoneTrigger : MonoBehaviour
{
    public AudioClip zoneSound;
    private AudioSource audioSource;
    private static string lastZone = "";

    void Start()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = Camera.main.gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (lastZone != gameObject.name)
            {
                audioSource.clip = zoneSound;
                audioSource.Play();
                lastZone = gameObject.name;
            }
        }
    }
}
