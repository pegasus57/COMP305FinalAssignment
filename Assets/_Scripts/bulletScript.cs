﻿using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {
    float speed;
	// Use this for initialization
	void Start () {
        speed = 80f;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 position = transform.position;
        position = new Vector2(position.x + speed * Time.deltaTime, position.y);
        transform.position = position;
        //Vector2 max = Camera.main.ScreenToViewportPoint(new Vector2(1, 1));
        //if (transform.position.y > max.y)
        //{
        //    Destroy(gameObject);
        //}
	
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {     
            Destroy(other.gameObject);   
        }
    }
}
