using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("hit detected");
        Destroy(gameObject);
        //this.gameObject.SetActive(false);
    }
}