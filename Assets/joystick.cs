using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour {
    public Transform player;
    public float speed = 5.0f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;
    public float accel = 1.5f;

    public Transform circle;
    public Transform outerCircle;

	// Update is called once per frame
    void Update () {
        if(Input.GetMouseButtonDown(0)){
            pointA = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            circle.transform.position = pointA;
            outerCircle.transform.position = pointA;
            circle.GetComponent<SpriteRenderer>().enabled = true;
            outerCircle.GetComponent<SpriteRenderer>().enabled = true;
        }
        if(Input.GetMouseButton(0)){
            touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        } 
        else {
            touchStart = false;
        }
    }
     private void FixedUpdate(){
        if(touchStart){
            Vector2 offset = pointA - pointB;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction * -1);

            circle.transform.position = pointA - direction;
        } 
        else {
            circle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    void moveCharacter(Vector2 direction){
        player.Translate(direction * speed * Time.deltaTime * accel);
    }
}