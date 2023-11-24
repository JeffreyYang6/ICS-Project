using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform firepoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //take player position and shoot a bullet 
            GameObject newBullet = Instantiate(bullet, firepoint.position, firepoint.rotation);

            // Access the bullet's Rigidbody2D component
            Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();

            // Apply continuous movement to the bullet in a specific direction
            bulletRB.velocity = firepoint.right * 20f; // Adjust the speed as needed
        }
    }

}
