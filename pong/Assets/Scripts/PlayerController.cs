using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D player;
    float vertical;
    public float moveSpeed;
    
    // Use this for initialization
	void Start ()
    {
        player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        vertical = Input.GetAxisRaw("Vertical");
	}

    void FixedUpdate()
    {
        player.velocity = new Vector2(0, vertical * moveSpeed);
    }
}
