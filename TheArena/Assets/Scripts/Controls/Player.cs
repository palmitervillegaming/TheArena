using Assets.Scripts.Controls.Camera;
using Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Ally, IDisposable {

    public Rigidbody2D rb;
    public BaseCharacter character;
    public bool isActivePlayer = true;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        gameObject.AddComponent<GameCamera>();
	}

    void FixedUpdate()
    {
        if (isActivePlayer)
        {
            Vector2 velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
            Vector2 newPosition = rb.position + velocity * Time.fixedDeltaTime;
            rb.MovePosition(newPosition);
        } else
        {
            //TODO make AI move player
        }
    }
}
