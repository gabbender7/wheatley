using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    public AudioSource audioSource;  // La fonte audio che vuoi mutare
    private Button button;  // Il bottone che userai per mutare

    void Start()
    {
        button = GetComponent<Button>();  // Ottieni il componente Button
        button.onClick.AddListener(ToggleMute);  // Aggiungi l'evento click al bottone
    }

    void ToggleMute()
    {
        if (audioSource != null)
        {
            audioSource.mute = !audioSource.mute;  // Inverte lo stato di muting
        }
    }
}
