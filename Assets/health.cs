using UnityEngine;
using UnityEngine.SceneManagement; // Aggiungi questo namespace per gestire le scene

public class PlayerHealth : MonoBehaviour {
    public int startingLives = 3; // Numero di vite iniziali del giocatore
    private int currentLives; // Vite attuali del giocatore

    [SerializeField] private GameObject hp1; // Prefab per il primo Health Point
    [SerializeField] private GameObject hp2; // Prefab per il secondo Health Point
    [SerializeField] private GameObject hp3; // Prefab per il terzo Health Point

    void Start() {
        currentLives = startingLives;
    }

    // Metodo per ridurre le vite del giocatore
    public void TakeDamage(int damageAmount) {
    currentLives -= damageAmount;
    Debug.Log("vite: " + currentLives);

    // Controlla se il giocatore ha esaurito tutte le vite
    if (currentLives <= 0) {
        currentLives = 0; // Assicura che il numero di vite non sia negativo
        // Esegui le azioni per la fine del gioco, ad esempio il game over
        Debug.Log("Game Over!");
        if (hp1 != null) hp1.SetActive(false);
        EndGame(); // Chiama il metodo per gestire la fine del gioco
    } else {
        // Se il giocatore ha ancora vite rimanenti, disattiva un prefab degli Health Points
        switch (currentLives) {
            case 3:
                if (hp3 != null) hp3.SetActive(true);
                if (hp2 != null) hp2.SetActive(true);
                if (hp1 != null) hp1.SetActive(true);
                break;
            case 2:
                if (hp3 != null) hp3.SetActive(false);
                break;
            case 1:
                if (hp2 != null) hp2.SetActive(false);
                break;
            case 0:
                if (hp1 != null) hp1.SetActive(false);
                break;
        }
    }
}

    // Metodo per ottenere il numero di vite attuali del giocatore
    public int GetCurrentLives() {
        return currentLives;
    }

    // Metodo per gestire la fine del gioco
    private void EndGame() {
        // Disattiva il GameObject del giocatore e degli asteroidi
        gameObject.SetActive(false);
        GameObject[] asteroids = GameObject.FindGameObjectsWithTag("Asteroid");
        foreach (GameObject asteroid in asteroids) {
            asteroid.SetActive(false);
        }

        // Carica la scena di Game Over o attiva il pannello di Game Over
        SceneManager.LoadScene("GameOverScene"); // Cambia "GameOverScene" con il nome della tua scena di Game Over
    }
}