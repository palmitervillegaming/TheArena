using Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Ally, IDisposable {

    public Rigidbody2D rb;
    public BaseCharacter character;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate()
    {
        Vector2 velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}
