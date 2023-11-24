using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleMovement : EnemyMovement
{

    Vector2 EagleLocalScale;
    private Rigidbody2D eagleRb;
    public float EagleSpeed;

    // Inherit from the EnemyMovement class
    public EagleMovement(float xPosition, float yPosition, float speed, Vector2 localScale) : base(xPosition, yPosition, speed)
    {
        this.EagleLocalScale = localScale;
        localScale = new Vector2(localScale.x, localScale.y);
        EagleLocalScale.x = xPosition;
        EagleLocalScale.y = yPosition;
        EagleSpeed = speed;
    }

    // Make eagle move towards left side of screen
    void EagleMovingLeft()
    {
        transform.localScale = EagleLocalScale;
        eagleRb.velocity = new Vector2(EagleLocalScale.x * EagleSpeed * -1, eagleRb.velocity.y);
    }

    // Start is called before the first frame update
    void Start()
    {
        EnemyMovement myBunnyMovement = new EnemyMovement(4.234898f, 4.400221f, 1.0f);
        EagleLocalScale = transform.localScale;
        eagleRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        EagleMovingLeft();
    }

}
