using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float MaxHealth = 5f;
    public float CurrentHealth;

    //Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    //Damage controller
    void TakeDamage(int amount)
    {
        CurrentHealth -= amount;

        //Check if player has died
        if (CurrentHealth <= 0)
        {
            SceneManager.LoadScene(sceneName: "EndScreen");
        }
    }

    void Update()
    {
        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
    }
}
