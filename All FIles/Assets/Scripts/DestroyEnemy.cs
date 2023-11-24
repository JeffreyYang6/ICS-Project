using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyEnemy : MonoBehaviour
{
    // If player collides with enemy at a certain spot they destroy it
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyTarget")
        {
            Destroy(collision.gameObject);
        }
    }

}
