using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployAsteroids : MonoBehaviour {
    public GameObject asteroidPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private bool gameIsOver = false; // Aggiungi una variabile per controllare lo stato del gioco

    // Use this for initialization
    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }

    private void spawnEnemy(){
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator asteroidWave(){
        while(!gameIsOver){ // Continua a spawnare asteroidi finché il gioco non è finito
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }

    // Metodo per gestire la fine del gioco
public void EndGame() {
    gameIsOver = true; // Imposta lo stato del gioco su "finito" per fermare il respawn degli asteroidi
    
}
}
