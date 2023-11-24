using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public PowerUp powerUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        powerUp.Apply(collision.gameObject);
    }
}
