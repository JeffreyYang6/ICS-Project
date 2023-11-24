using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollisionController : MonoBehaviour
{
    public CoinManager cm;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            cm.CoinCount++;
        }
    }
}
