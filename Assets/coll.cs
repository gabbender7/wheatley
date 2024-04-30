using UnityEngine;

public class coll : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            Debug.Log("Collisione con il giocatore rilevata");
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null) {
                playerHealth.TakeDamage(1);
            }
            Destroy(gameObject); // Distruggi l'asteroide
            
        }
    }
}