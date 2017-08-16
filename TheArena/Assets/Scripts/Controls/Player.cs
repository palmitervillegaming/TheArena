using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speedx;
    public float speedy;
    public Rigidbody2D rb;
    public BaseCharacter character;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate()
    {
        Vector2 velocity = new Vector2(Input.GetAxis("Horizontal") * speedx, Input.GetAxis("Vertical") * speedy);
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Collided!");
    }
}
