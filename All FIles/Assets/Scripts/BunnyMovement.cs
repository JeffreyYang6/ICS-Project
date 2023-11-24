using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyMovement : EnemyMovement
{
    Vector2 BunnyLocalScale;
    private Rigidbody2D bunnyRb;
    public float BunnySpeed;

    // Inherit from the EnemyMovement class
    public BunnyMovement(float xPosition, float yPosition, float speed, Vector2 localScale) : base(xPosition, yPosition, speed)
    {
        this.BunnyLocalScale = localScale;
        localScale = new Vector2(localScale.x, localScale.y);
        BunnyLocalScale.x = xPosition;
        BunnyLocalScale.y = yPosition;
        BunnySpeed = speed;
    }

    // Make bunny move towards left side of screen
    void BunnyMovingLeft()
    {
        transform.localScale = BunnyLocalScale;
        bunnyRb.velocity = new Vector2(BunnyLocalScale.x * BunnySpeed * -1, bunnyRb.velocity.y);
    }

    // Start is called before the first frame update
    void Start()
    {
        EnemyMovement myBunnyMovement = new EnemyMovement(4.234898f, 4.400221f, 1.0f);
        BunnyLocalScale = transform.localScale;
        bunnyRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BunnyMovingLeft();
    }

}
