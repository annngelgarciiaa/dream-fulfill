using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERCONTROLLLER : MonoBehaviour
{ //Velocidad del jugador
    public float moveSpeed;
    //El rigidbody del jugador
    private Rigidbody2D theRB;
    //Fuerza de salto del jugador
    public float jumpForce;
    private float moveX;
    // Start is called before the first frame update
    void Awake()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }
    private void FixedUpdate()
    {
        Vector2 velocity = theRB.velocity;
        velocity.x = moveX;
        theRB.velocity = velocity;
    }
}
